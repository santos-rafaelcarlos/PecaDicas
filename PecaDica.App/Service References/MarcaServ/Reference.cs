﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PecaDica.App.MarcaServ {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StructuralObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.MarcaServ.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.MarcaServ.Marca))]
    public partial class StructuralObject : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.MarcaServ.Marca))]
    public partial class EntityObject : PecaDica.App.MarcaServ.StructuralObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.MarcaServ.EntityKey EntityKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PecaDica.App.MarcaServ.EntityKey EntityKey {
            get {
                return this.EntityKeyField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityKeyField, value) != true)) {
                    this.EntityKeyField = value;
                    this.RaisePropertyChanged("EntityKey");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Marca", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Marca : PecaDica.App.MarcaServ.EntityObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Guid Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nome {
            get {
                return this.NomeField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeField, value) != true)) {
                    this.NomeField = value;
                    this.RaisePropertyChanged("Nome");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityKey", Namespace="http://schemas.datacontract.org/2004/07/System.Data", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class EntityKey : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntityContainerNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.MarcaServ.EntityKeyMember[] EntityKeyValuesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EntitySetNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntityContainerName {
            get {
                return this.EntityContainerNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityContainerNameField, value) != true)) {
                    this.EntityContainerNameField = value;
                    this.RaisePropertyChanged("EntityContainerName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PecaDica.App.MarcaServ.EntityKeyMember[] EntityKeyValues {
            get {
                return this.EntityKeyValuesField;
            }
            set {
                if ((object.ReferenceEquals(this.EntityKeyValuesField, value) != true)) {
                    this.EntityKeyValuesField = value;
                    this.RaisePropertyChanged("EntityKeyValues");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EntitySetName {
            get {
                return this.EntitySetNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EntitySetNameField, value) != true)) {
                    this.EntitySetNameField = value;
                    this.RaisePropertyChanged("EntitySetName");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="EntityKeyMember", Namespace="http://schemas.datacontract.org/2004/07/System.Data")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.MarcaServ.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.MarcaServ.StructuralObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.MarcaServ.EntityKey))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.MarcaServ.EntityKeyMember[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.MarcaServ.Marca))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.MarcaServ.DetalhamentoFalha))]
    public partial class EntityKeyMember : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string KeyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object ValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Key {
            get {
                return this.KeyField;
            }
            set {
                if ((object.ReferenceEquals(this.KeyField, value) != true)) {
                    this.KeyField = value;
                    this.RaisePropertyChanged("Key");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object Value {
            get {
                return this.ValueField;
            }
            set {
                if ((object.ReferenceEquals(this.ValueField, value) != true)) {
                    this.ValueField = value;
                    this.RaisePropertyChanged("Value");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DetalhamentoFalha", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common")]
    [System.SerializableAttribute()]
    public partial class DetalhamentoFalha : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MensagemInternaField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mensagem {
            get {
                return this.MensagemField;
            }
            set {
                if ((object.ReferenceEquals(this.MensagemField, value) != true)) {
                    this.MensagemField = value;
                    this.RaisePropertyChanged("Mensagem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MensagemInterna {
            get {
                return this.MensagemInternaField;
            }
            set {
                if ((object.ReferenceEquals(this.MensagemInternaField, value) != true)) {
                    this.MensagemInternaField = value;
                    this.RaisePropertyChanged("MensagemInterna");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MarcaServ.IMarcaService")]
    public interface IMarcaService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcaService/Inserir", ReplyAction="http://tempuri.org/IMarcaService/InserirResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PecaDica.App.MarcaServ.DetalhamentoFalha), Action="http://tempuri.org/IMarcaService/InserirDetalhamentoFalhaFault", Name="DetalhamentoFalha", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common")]
        void Inserir(PecaDica.App.MarcaServ.Marca item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcaService/Deletar", ReplyAction="http://tempuri.org/IMarcaService/DeletarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PecaDica.App.MarcaServ.DetalhamentoFalha), Action="http://tempuri.org/IMarcaService/DeletarDetalhamentoFalhaFault", Name="DetalhamentoFalha", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common")]
        void Deletar(PecaDica.App.MarcaServ.Marca item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMarcaService/Alterar", ReplyAction="http://tempuri.org/IMarcaService/AlterarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PecaDica.App.MarcaServ.DetalhamentoFalha), Action="http://tempuri.org/IMarcaService/AlterarDetalhamentoFalhaFault", Name="DetalhamentoFalha", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common")]
        void Alterar(PecaDica.App.MarcaServ.Marca item);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMarcaServiceChannel : PecaDica.App.MarcaServ.IMarcaService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MarcaServiceClient : System.ServiceModel.ClientBase<PecaDica.App.MarcaServ.IMarcaService>, PecaDica.App.MarcaServ.IMarcaService {
        
        public MarcaServiceClient() {
        }
        
        public MarcaServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MarcaServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarcaServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MarcaServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Inserir(PecaDica.App.MarcaServ.Marca item) {
            base.Channel.Inserir(item);
        }
        
        public void Deletar(PecaDica.App.MarcaServ.Marca item) {
            base.Channel.Deletar(item);
        }
        
        public void Alterar(PecaDica.App.MarcaServ.Marca item) {
            base.Channel.Alterar(item);
        }
    }
}
