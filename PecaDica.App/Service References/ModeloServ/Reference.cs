﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PecaDica.App.ModeloServ {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StructuralObject", Namespace="http://schemas.datacontract.org/2004/07/System.Data.Objects.DataClasses", IsReference=true)]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.ModeloServ.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.ModeloServ.Modelo))]
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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.ModeloServ.Modelo))]
    public partial class EntityObject : PecaDica.App.ModeloServ.StructuralObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.ModeloServ.EntityKey EntityKeyField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PecaDica.App.ModeloServ.EntityKey EntityKey {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Modelo", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Modelo : PecaDica.App.ModeloServ.EntityObject {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.Guid> MarcaIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Ano {
            get {
                return this.AnoField;
            }
            set {
                if ((this.AnoField.Equals(value) != true)) {
                    this.AnoField = value;
                    this.RaisePropertyChanged("Ano");
                }
            }
        }
        
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
        public System.Nullable<System.Guid> MarcaID {
            get {
                return this.MarcaIDField;
            }
            set {
                if ((this.MarcaIDField.Equals(value) != true)) {
                    this.MarcaIDField = value;
                    this.RaisePropertyChanged("MarcaID");
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
        private PecaDica.App.ModeloServ.EntityKeyMember[] EntityKeyValuesField;
        
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
        public PecaDica.App.ModeloServ.EntityKeyMember[] EntityKeyValues {
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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.ModeloServ.Modelo))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.ModeloServ.DetalhamentoFalha))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.ModeloServ.EntityObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.ModeloServ.StructuralObject))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.ModeloServ.EntityKey))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(PecaDica.App.ModeloServ.EntityKeyMember[]))]
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ModeloServ.IModeloService")]
    public interface IModeloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModeloService/Inserir", ReplyAction="http://tempuri.org/IModeloService/InserirResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PecaDica.App.ModeloServ.DetalhamentoFalha), Action="http://tempuri.org/IModeloService/InserirDetalhamentoFalhaFault", Name="DetalhamentoFalha", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common")]
        void Inserir(PecaDica.App.ModeloServ.Modelo item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModeloService/Deletar", ReplyAction="http://tempuri.org/IModeloService/DeletarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PecaDica.App.ModeloServ.DetalhamentoFalha), Action="http://tempuri.org/IModeloService/DeletarDetalhamentoFalhaFault", Name="DetalhamentoFalha", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common")]
        void Deletar(PecaDica.App.ModeloServ.Modelo item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModeloService/Alterar", ReplyAction="http://tempuri.org/IModeloService/AlterarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PecaDica.App.ModeloServ.DetalhamentoFalha), Action="http://tempuri.org/IModeloService/AlterarDetalhamentoFalhaFault", Name="DetalhamentoFalha", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common")]
        void Alterar(PecaDica.App.ModeloServ.Modelo item);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IModeloServiceChannel : PecaDica.App.ModeloServ.IModeloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ModeloServiceClient : System.ServiceModel.ClientBase<PecaDica.App.ModeloServ.IModeloService>, PecaDica.App.ModeloServ.IModeloService {
        
        public ModeloServiceClient() {
        }
        
        public ModeloServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ModeloServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ModeloServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ModeloServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Inserir(PecaDica.App.ModeloServ.Modelo item) {
            base.Channel.Inserir(item);
        }
        
        public void Deletar(PecaDica.App.ModeloServ.Modelo item) {
            base.Channel.Deletar(item);
        }
        
        public void Alterar(PecaDica.App.ModeloServ.Modelo item) {
            base.Channel.Alterar(item);
        }
    }
}
