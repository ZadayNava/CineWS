﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CineWS.GeneroService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="GeneroPelicula_VO", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class GeneroPelicula_VO : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private int Id_GeneroField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Nombre_GeneroField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Id_Genero {
            get {
                return this.Id_GeneroField;
            }
            set {
                if ((this.Id_GeneroField.Equals(value) != true)) {
                    this.Id_GeneroField = value;
                    this.RaisePropertyChanged("Id_Genero");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string Nombre_Genero {
            get {
                return this.Nombre_GeneroField;
            }
            set {
                if ((object.ReferenceEquals(this.Nombre_GeneroField, value) != true)) {
                    this.Nombre_GeneroField = value;
                    this.RaisePropertyChanged("Nombre_Genero");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfAnyType", Namespace="http://tempuri.org/", ItemName="anyType")]
    [System.SerializableAttribute()]
    public class ArrayOfAnyType : System.Collections.Generic.List<object> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GeneroService.GeneroServiceSoap")]
    public interface GeneroServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento genero del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert_Genero", ReplyAction="*")]
        CineWS.GeneroService.Insert_GeneroResponse Insert_Genero(CineWS.GeneroService.Insert_GeneroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Insert_Genero", ReplyAction="*")]
        System.Threading.Tasks.Task<CineWS.GeneroService.Insert_GeneroResponse> Insert_GeneroAsync(CineWS.GeneroService.Insert_GeneroRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento parametros del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGenero", ReplyAction="*")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CineWS.GeneroService.GeneroPelicula_VO))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CineWS.GeneroService.ArrayOfAnyType))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(CineWS.GeneroService.GeneroPelicula_VO[]))]
        CineWS.GeneroService.GetGeneroResponse GetGenero(CineWS.GeneroService.GetGeneroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGenero", ReplyAction="*")]
        System.Threading.Tasks.Task<CineWS.GeneroService.GetGeneroResponse> GetGeneroAsync(CineWS.GeneroService.GetGeneroRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento GetGeneroxIDResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGeneroxID", ReplyAction="*")]
        CineWS.GeneroService.GetGeneroxIDResponse GetGeneroxID(CineWS.GeneroService.GetGeneroxIDRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGeneroxID", ReplyAction="*")]
        System.Threading.Tasks.Task<CineWS.GeneroService.GetGeneroxIDResponse> GetGeneroxIDAsync(CineWS.GeneroService.GetGeneroxIDRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento id del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateGenero", ReplyAction="*")]
        CineWS.GeneroService.UpdateGeneroResponse UpdateGenero(CineWS.GeneroService.UpdateGeneroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateGenero", ReplyAction="*")]
        System.Threading.Tasks.Task<CineWS.GeneroService.UpdateGeneroResponse> UpdateGeneroAsync(CineWS.GeneroService.UpdateGeneroRequest request);
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento Delete_GeneroResult del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete_Genero", ReplyAction="*")]
        CineWS.GeneroService.Delete_GeneroResponse Delete_Genero(CineWS.GeneroService.Delete_GeneroRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Delete_Genero", ReplyAction="*")]
        System.Threading.Tasks.Task<CineWS.GeneroService.Delete_GeneroResponse> Delete_GeneroAsync(CineWS.GeneroService.Delete_GeneroRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Insert_GeneroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert_Genero", Namespace="http://tempuri.org/", Order=0)]
        public CineWS.GeneroService.Insert_GeneroRequestBody Body;
        
        public Insert_GeneroRequest() {
        }
        
        public Insert_GeneroRequest(CineWS.GeneroService.Insert_GeneroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Insert_GeneroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CineWS.GeneroService.GeneroPelicula_VO genero;
        
        public Insert_GeneroRequestBody() {
        }
        
        public Insert_GeneroRequestBody(CineWS.GeneroService.GeneroPelicula_VO genero) {
            this.genero = genero;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Insert_GeneroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Insert_GeneroResponse", Namespace="http://tempuri.org/", Order=0)]
        public CineWS.GeneroService.Insert_GeneroResponseBody Body;
        
        public Insert_GeneroResponse() {
        }
        
        public Insert_GeneroResponse(CineWS.GeneroService.Insert_GeneroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Insert_GeneroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Insert_GeneroResult;
        
        public Insert_GeneroResponseBody() {
        }
        
        public Insert_GeneroResponseBody(string Insert_GeneroResult) {
            this.Insert_GeneroResult = Insert_GeneroResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGeneroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGenero", Namespace="http://tempuri.org/", Order=0)]
        public CineWS.GeneroService.GetGeneroRequestBody Body;
        
        public GetGeneroRequest() {
        }
        
        public GetGeneroRequest(CineWS.GeneroService.GetGeneroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGeneroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CineWS.GeneroService.ArrayOfAnyType parametros;
        
        public GetGeneroRequestBody() {
        }
        
        public GetGeneroRequestBody(CineWS.GeneroService.ArrayOfAnyType parametros) {
            this.parametros = parametros;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGeneroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGeneroResponse", Namespace="http://tempuri.org/", Order=0)]
        public CineWS.GeneroService.GetGeneroResponseBody Body;
        
        public GetGeneroResponse() {
        }
        
        public GetGeneroResponse(CineWS.GeneroService.GetGeneroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGeneroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CineWS.GeneroService.GeneroPelicula_VO[] GetGeneroResult;
        
        public GetGeneroResponseBody() {
        }
        
        public GetGeneroResponseBody(CineWS.GeneroService.GeneroPelicula_VO[] GetGeneroResult) {
            this.GetGeneroResult = GetGeneroResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGeneroxIDRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGeneroxID", Namespace="http://tempuri.org/", Order=0)]
        public CineWS.GeneroService.GetGeneroxIDRequestBody Body;
        
        public GetGeneroxIDRequest() {
        }
        
        public GetGeneroxIDRequest(CineWS.GeneroService.GetGeneroxIDRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGeneroxIDRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public GetGeneroxIDRequestBody() {
        }
        
        public GetGeneroxIDRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGeneroxIDResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGeneroxIDResponse", Namespace="http://tempuri.org/", Order=0)]
        public CineWS.GeneroService.GetGeneroxIDResponseBody Body;
        
        public GetGeneroxIDResponse() {
        }
        
        public GetGeneroxIDResponse(CineWS.GeneroService.GetGeneroxIDResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGeneroxIDResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CineWS.GeneroService.GeneroPelicula_VO GetGeneroxIDResult;
        
        public GetGeneroxIDResponseBody() {
        }
        
        public GetGeneroxIDResponseBody(CineWS.GeneroService.GeneroPelicula_VO GetGeneroxIDResult) {
            this.GetGeneroxIDResult = GetGeneroxIDResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateGeneroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateGenero", Namespace="http://tempuri.org/", Order=0)]
        public CineWS.GeneroService.UpdateGeneroRequestBody Body;
        
        public UpdateGeneroRequest() {
        }
        
        public UpdateGeneroRequest(CineWS.GeneroService.UpdateGeneroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateGeneroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CineWS.GeneroService.GeneroPelicula_VO id;
        
        public UpdateGeneroRequestBody() {
        }
        
        public UpdateGeneroRequestBody(CineWS.GeneroService.GeneroPelicula_VO id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UpdateGeneroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="UpdateGeneroResponse", Namespace="http://tempuri.org/", Order=0)]
        public CineWS.GeneroService.UpdateGeneroResponseBody Body;
        
        public UpdateGeneroResponse() {
        }
        
        public UpdateGeneroResponse(CineWS.GeneroService.UpdateGeneroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class UpdateGeneroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string UpdateGeneroResult;
        
        public UpdateGeneroResponseBody() {
        }
        
        public UpdateGeneroResponseBody(string UpdateGeneroResult) {
            this.UpdateGeneroResult = UpdateGeneroResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Delete_GeneroRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Delete_Genero", Namespace="http://tempuri.org/", Order=0)]
        public CineWS.GeneroService.Delete_GeneroRequestBody Body;
        
        public Delete_GeneroRequest() {
        }
        
        public Delete_GeneroRequest(CineWS.GeneroService.Delete_GeneroRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Delete_GeneroRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int id;
        
        public Delete_GeneroRequestBody() {
        }
        
        public Delete_GeneroRequestBody(int id) {
            this.id = id;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Delete_GeneroResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Delete_GeneroResponse", Namespace="http://tempuri.org/", Order=0)]
        public CineWS.GeneroService.Delete_GeneroResponseBody Body;
        
        public Delete_GeneroResponse() {
        }
        
        public Delete_GeneroResponse(CineWS.GeneroService.Delete_GeneroResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Delete_GeneroResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Delete_GeneroResult;
        
        public Delete_GeneroResponseBody() {
        }
        
        public Delete_GeneroResponseBody(string Delete_GeneroResult) {
            this.Delete_GeneroResult = Delete_GeneroResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface GeneroServiceSoapChannel : CineWS.GeneroService.GeneroServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GeneroServiceSoapClient : System.ServiceModel.ClientBase<CineWS.GeneroService.GeneroServiceSoap>, CineWS.GeneroService.GeneroServiceSoap {
        
        public GeneroServiceSoapClient() {
        }
        
        public GeneroServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public GeneroServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeneroServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public GeneroServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CineWS.GeneroService.Insert_GeneroResponse CineWS.GeneroService.GeneroServiceSoap.Insert_Genero(CineWS.GeneroService.Insert_GeneroRequest request) {
            return base.Channel.Insert_Genero(request);
        }
        
        public string Insert_Genero(CineWS.GeneroService.GeneroPelicula_VO genero) {
            CineWS.GeneroService.Insert_GeneroRequest inValue = new CineWS.GeneroService.Insert_GeneroRequest();
            inValue.Body = new CineWS.GeneroService.Insert_GeneroRequestBody();
            inValue.Body.genero = genero;
            CineWS.GeneroService.Insert_GeneroResponse retVal = ((CineWS.GeneroService.GeneroServiceSoap)(this)).Insert_Genero(inValue);
            return retVal.Body.Insert_GeneroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CineWS.GeneroService.Insert_GeneroResponse> CineWS.GeneroService.GeneroServiceSoap.Insert_GeneroAsync(CineWS.GeneroService.Insert_GeneroRequest request) {
            return base.Channel.Insert_GeneroAsync(request);
        }
        
        public System.Threading.Tasks.Task<CineWS.GeneroService.Insert_GeneroResponse> Insert_GeneroAsync(CineWS.GeneroService.GeneroPelicula_VO genero) {
            CineWS.GeneroService.Insert_GeneroRequest inValue = new CineWS.GeneroService.Insert_GeneroRequest();
            inValue.Body = new CineWS.GeneroService.Insert_GeneroRequestBody();
            inValue.Body.genero = genero;
            return ((CineWS.GeneroService.GeneroServiceSoap)(this)).Insert_GeneroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CineWS.GeneroService.GetGeneroResponse CineWS.GeneroService.GeneroServiceSoap.GetGenero(CineWS.GeneroService.GetGeneroRequest request) {
            return base.Channel.GetGenero(request);
        }
        
        public CineWS.GeneroService.GeneroPelicula_VO[] GetGenero(CineWS.GeneroService.ArrayOfAnyType parametros) {
            CineWS.GeneroService.GetGeneroRequest inValue = new CineWS.GeneroService.GetGeneroRequest();
            inValue.Body = new CineWS.GeneroService.GetGeneroRequestBody();
            inValue.Body.parametros = parametros;
            CineWS.GeneroService.GetGeneroResponse retVal = ((CineWS.GeneroService.GeneroServiceSoap)(this)).GetGenero(inValue);
            return retVal.Body.GetGeneroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CineWS.GeneroService.GetGeneroResponse> CineWS.GeneroService.GeneroServiceSoap.GetGeneroAsync(CineWS.GeneroService.GetGeneroRequest request) {
            return base.Channel.GetGeneroAsync(request);
        }
        
        public System.Threading.Tasks.Task<CineWS.GeneroService.GetGeneroResponse> GetGeneroAsync(CineWS.GeneroService.ArrayOfAnyType parametros) {
            CineWS.GeneroService.GetGeneroRequest inValue = new CineWS.GeneroService.GetGeneroRequest();
            inValue.Body = new CineWS.GeneroService.GetGeneroRequestBody();
            inValue.Body.parametros = parametros;
            return ((CineWS.GeneroService.GeneroServiceSoap)(this)).GetGeneroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CineWS.GeneroService.GetGeneroxIDResponse CineWS.GeneroService.GeneroServiceSoap.GetGeneroxID(CineWS.GeneroService.GetGeneroxIDRequest request) {
            return base.Channel.GetGeneroxID(request);
        }
        
        public CineWS.GeneroService.GeneroPelicula_VO GetGeneroxID(int id) {
            CineWS.GeneroService.GetGeneroxIDRequest inValue = new CineWS.GeneroService.GetGeneroxIDRequest();
            inValue.Body = new CineWS.GeneroService.GetGeneroxIDRequestBody();
            inValue.Body.id = id;
            CineWS.GeneroService.GetGeneroxIDResponse retVal = ((CineWS.GeneroService.GeneroServiceSoap)(this)).GetGeneroxID(inValue);
            return retVal.Body.GetGeneroxIDResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CineWS.GeneroService.GetGeneroxIDResponse> CineWS.GeneroService.GeneroServiceSoap.GetGeneroxIDAsync(CineWS.GeneroService.GetGeneroxIDRequest request) {
            return base.Channel.GetGeneroxIDAsync(request);
        }
        
        public System.Threading.Tasks.Task<CineWS.GeneroService.GetGeneroxIDResponse> GetGeneroxIDAsync(int id) {
            CineWS.GeneroService.GetGeneroxIDRequest inValue = new CineWS.GeneroService.GetGeneroxIDRequest();
            inValue.Body = new CineWS.GeneroService.GetGeneroxIDRequestBody();
            inValue.Body.id = id;
            return ((CineWS.GeneroService.GeneroServiceSoap)(this)).GetGeneroxIDAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CineWS.GeneroService.UpdateGeneroResponse CineWS.GeneroService.GeneroServiceSoap.UpdateGenero(CineWS.GeneroService.UpdateGeneroRequest request) {
            return base.Channel.UpdateGenero(request);
        }
        
        public string UpdateGenero(CineWS.GeneroService.GeneroPelicula_VO id) {
            CineWS.GeneroService.UpdateGeneroRequest inValue = new CineWS.GeneroService.UpdateGeneroRequest();
            inValue.Body = new CineWS.GeneroService.UpdateGeneroRequestBody();
            inValue.Body.id = id;
            CineWS.GeneroService.UpdateGeneroResponse retVal = ((CineWS.GeneroService.GeneroServiceSoap)(this)).UpdateGenero(inValue);
            return retVal.Body.UpdateGeneroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CineWS.GeneroService.UpdateGeneroResponse> CineWS.GeneroService.GeneroServiceSoap.UpdateGeneroAsync(CineWS.GeneroService.UpdateGeneroRequest request) {
            return base.Channel.UpdateGeneroAsync(request);
        }
        
        public System.Threading.Tasks.Task<CineWS.GeneroService.UpdateGeneroResponse> UpdateGeneroAsync(CineWS.GeneroService.GeneroPelicula_VO id) {
            CineWS.GeneroService.UpdateGeneroRequest inValue = new CineWS.GeneroService.UpdateGeneroRequest();
            inValue.Body = new CineWS.GeneroService.UpdateGeneroRequestBody();
            inValue.Body.id = id;
            return ((CineWS.GeneroService.GeneroServiceSoap)(this)).UpdateGeneroAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CineWS.GeneroService.Delete_GeneroResponse CineWS.GeneroService.GeneroServiceSoap.Delete_Genero(CineWS.GeneroService.Delete_GeneroRequest request) {
            return base.Channel.Delete_Genero(request);
        }
        
        public string Delete_Genero(int id) {
            CineWS.GeneroService.Delete_GeneroRequest inValue = new CineWS.GeneroService.Delete_GeneroRequest();
            inValue.Body = new CineWS.GeneroService.Delete_GeneroRequestBody();
            inValue.Body.id = id;
            CineWS.GeneroService.Delete_GeneroResponse retVal = ((CineWS.GeneroService.GeneroServiceSoap)(this)).Delete_Genero(inValue);
            return retVal.Body.Delete_GeneroResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CineWS.GeneroService.Delete_GeneroResponse> CineWS.GeneroService.GeneroServiceSoap.Delete_GeneroAsync(CineWS.GeneroService.Delete_GeneroRequest request) {
            return base.Channel.Delete_GeneroAsync(request);
        }
        
        public System.Threading.Tasks.Task<CineWS.GeneroService.Delete_GeneroResponse> Delete_GeneroAsync(int id) {
            CineWS.GeneroService.Delete_GeneroRequest inValue = new CineWS.GeneroService.Delete_GeneroRequest();
            inValue.Body = new CineWS.GeneroService.Delete_GeneroRequestBody();
            inValue.Body.id = id;
            return ((CineWS.GeneroService.GeneroServiceSoap)(this)).Delete_GeneroAsync(inValue);
        }
    }
}
