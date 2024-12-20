using CineWS.GeneroService;
using CineWS.SalaService;
using CineWS.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CineWS.Catalogos.GeneroPelicula
{
    public partial class FormularioGeneroPelicula : System.Web.UI.Page
    {
       GeneroService.GeneroServiceSoapClient Genero_WS;
        protected void Page_Load(object sender, EventArgs e)
        {
            Genero_WS = new GeneroServiceSoapClient();

            if (!IsPostBack)
            {
                if (Request.QueryString["Id"] != null)
                {
                    int id_gen = int.Parse(Request.QueryString["Id"].ToString());
                    GeneroPelicula_VO _gen = Genero_WS.GetGeneroxID(id_gen);

                    if (_gen.Id_Genero != null)
                    {
                        //Relleno el formulario
                        Titulo.Text = "Actualizar Genero";
                        txtNombre.Text = _gen.Nombre_Genero.ToString();
                    }
                    else
                    {
                        //sweet alert
                        SweetAlert.Sweet_Alert("Ops...", "No pudimos encontrar el objeto que buscas", "info", this.Page, this.GetType(), "~/Catalogos/GeneroPelicula/ListadoGenero.aspx");
                    }
                }
                else
                {
                    //voy a insertar
                    Titulo.Text = "Agregar nuevo genero";

                }
            }
        }

        protected void btngurdar_Click(object sender, EventArgs e)
        {
            //preparo mi objeto para enviar
            GeneroPelicula_VO _genero = new GeneroPelicula_VO();
            //variables para el sweet
            string titulo, msg, tipo, respuesta;
            try
            {
                //asigno mis valores del formulario al objeto
                _genero.Nombre_Genero = txtNombre.Text;
                //valido si voy a insertar o a actualizar
                if (Request.QueryString["Id"] != null)
                {
                    //voy a actualizar
                    _genero.Id_Genero = int.Parse(Request.QueryString["Id"]);
                    respuesta = Genero_WS.UpdateGenero(_genero);
                }
                else
                {
                    //voy a insertar
                    respuesta = Genero_WS.Insert_Genero(_genero);
                }
                //Preparo mis sweet alert
                if (respuesta.ToUpper().Contains("ERROR"))
                {
                    titulo = "Error";
                    msg = respuesta;
                    tipo = "error";
                    //sweet alert
                    SweetAlert.Sweet_Alert(titulo, msg, tipo, this.Page, this.GetType());
                }
                else
                {
                    titulo = "OK!";
                    msg = respuesta;
                    tipo = "success";
                    //sweet alert
                    SweetAlert.Sweet_Alert(titulo, msg, tipo, this.Page, this.GetType(), "/Catalogos/GeneroPelicula/ListadoGeneroPelicula.aspx");
                }
            }
            catch (Exception ex)
            {
                titulo = "Error";
                msg = ex.Message;
                tipo = "error";
                //sweet alert
                SweetAlert.Sweet_Alert(titulo, msg, tipo, this.Page, this.GetType());
            }
        }
    }
}