using CineWS.SalaService;
using CineWS.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CineWS.Catalogos.Sala
{
    public partial class FormularioSala : System.Web.UI.Page
    {
        SalaService.SalaServiceSoapClient salaWS;

        protected void Page_Load(object sender, EventArgs e)
        {
            salaWS = new SalaServiceSoapClient();

            if (!IsPostBack)
            {
                //voy a insertar
                Titulo.Text = "Agregar nueva Pelicula";
            }

        }


        protected void btngurdar_Click(object sender, EventArgs e)
        {

            //preparo mi objeto para enviar
            Sala_VO _sala = new Sala_VO();
            //variables para el sweet
            string titulo, msg, tipo, respuesta;
            try
            {
                //asigno mis valores del formulario al objeto
                _sala.NomSala = txtNombre.Text;
                _sala.TipoSala = txtTipoSala.Text;
                _sala.Asientos_ID = int.Parse(txtIdAsiento.Text);
                //voy a insertar
                respuesta = salaWS.Insert_Sala(_sala);
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
                    SweetAlert.Sweet_Alert(titulo, msg, tipo, this.Page, this.GetType(), "/Catalogos/Sala/ListadoSala.aspx");
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