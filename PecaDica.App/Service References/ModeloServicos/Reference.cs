﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1008
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PecaDica.App.ModeloServicos {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Modelo", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Modelo : System.Data.Objects.DataClasses.EntityObject, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AnoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.ModeloServicos.Marca MarcaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Marca> MarcaReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.ModeloServicos.Produto ProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Produto> ProdutoReferenceField;
        
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
        public PecaDica.App.ModeloServicos.Marca Marca {
            get {
                return this.MarcaField;
            }
            set {
                if ((object.ReferenceEquals(this.MarcaField, value) != true)) {
                    this.MarcaField = value;
                    this.RaisePropertyChanged("Marca");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Marca> MarcaReference {
            get {
                return this.MarcaReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.MarcaReferenceField, value) != true)) {
                    this.MarcaReferenceField = value;
                    this.RaisePropertyChanged("MarcaReference");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PecaDica.App.ModeloServicos.Produto Produto {
            get {
                return this.ProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutoField, value) != true)) {
                    this.ProdutoField = value;
                    this.RaisePropertyChanged("Produto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Produto> ProdutoReference {
            get {
                return this.ProdutoReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutoReferenceField, value) != true)) {
                    this.ProdutoReferenceField = value;
                    this.RaisePropertyChanged("ProdutoReference");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Marca", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Marca : System.Data.Objects.DataClasses.EntityObject, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.ModeloServicos.Modelo ModeloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Modelo> ModeloReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public PecaDica.App.ModeloServicos.Modelo Modelo {
            get {
                return this.ModeloField;
            }
            set {
                if ((object.ReferenceEquals(this.ModeloField, value) != true)) {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Modelo> ModeloReference {
            get {
                return this.ModeloReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ModeloReferenceField, value) != true)) {
                    this.ModeloReferenceField = value;
                    this.RaisePropertyChanged("ModeloReference");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Produto", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Produto : System.Data.Objects.DataClasses.EntityObject, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.ModeloServicos.Categoria CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Categoria> CategoriaReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.ModeloServicos.Loja LojaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Loja> LojaReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.ModeloServicos.Modelo ModeloField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Modelo> ModeloReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
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
        public PecaDica.App.ModeloServicos.Categoria Categoria {
            get {
                return this.CategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriaField, value) != true)) {
                    this.CategoriaField = value;
                    this.RaisePropertyChanged("Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Categoria> CategoriaReference {
            get {
                return this.CategoriaReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriaReferenceField, value) != true)) {
                    this.CategoriaReferenceField = value;
                    this.RaisePropertyChanged("CategoriaReference");
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
        public PecaDica.App.ModeloServicos.Loja Loja {
            get {
                return this.LojaField;
            }
            set {
                if ((object.ReferenceEquals(this.LojaField, value) != true)) {
                    this.LojaField = value;
                    this.RaisePropertyChanged("Loja");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Loja> LojaReference {
            get {
                return this.LojaReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.LojaReferenceField, value) != true)) {
                    this.LojaReferenceField = value;
                    this.RaisePropertyChanged("LojaReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PecaDica.App.ModeloServicos.Modelo Modelo {
            get {
                return this.ModeloField;
            }
            set {
                if ((object.ReferenceEquals(this.ModeloField, value) != true)) {
                    this.ModeloField = value;
                    this.RaisePropertyChanged("Modelo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Modelo> ModeloReference {
            get {
                return this.ModeloReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ModeloReferenceField, value) != true)) {
                    this.ModeloReferenceField = value;
                    this.RaisePropertyChanged("ModeloReference");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Categoria", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Categoria : System.Data.Objects.DataClasses.EntityObject, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescricaoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.ModeloServicos.Produto ProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Produto> ProdutoReferenceField;
        
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
        public string Descricao {
            get {
                return this.DescricaoField;
            }
            set {
                if ((object.ReferenceEquals(this.DescricaoField, value) != true)) {
                    this.DescricaoField = value;
                    this.RaisePropertyChanged("Descricao");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PecaDica.App.ModeloServicos.Produto Produto {
            get {
                return this.ProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutoField, value) != true)) {
                    this.ProdutoField = value;
                    this.RaisePropertyChanged("Produto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Produto> ProdutoReference {
            get {
                return this.ProdutoReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutoReferenceField, value) != true)) {
                    this.ProdutoReferenceField = value;
                    this.RaisePropertyChanged("ProdutoReference");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Loja", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common", IsReference=true)]
    [System.SerializableAttribute()]
    public partial class Loja : System.Data.Objects.DataClasses.EntityObject, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EnderecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Guid IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private PecaDica.App.ModeloServicos.Produto ProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Produto> ProdutoReferenceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SenhaField;
        
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
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Endereco {
            get {
                return this.EnderecoField;
            }
            set {
                if ((object.ReferenceEquals(this.EnderecoField, value) != true)) {
                    this.EnderecoField = value;
                    this.RaisePropertyChanged("Endereco");
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeUsuario {
            get {
                return this.NomeUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeUsuarioField, value) != true)) {
                    this.NomeUsuarioField = value;
                    this.RaisePropertyChanged("NomeUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public PecaDica.App.ModeloServicos.Produto Produto {
            get {
                return this.ProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutoField, value) != true)) {
                    this.ProdutoField = value;
                    this.RaisePropertyChanged("Produto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Data.Objects.DataClasses.EntityReference<PecaDica.App.ModeloServicos.Produto> ProdutoReference {
            get {
                return this.ProdutoReferenceField;
            }
            set {
                if ((object.ReferenceEquals(this.ProdutoReferenceField, value) != true)) {
                    this.ProdutoReferenceField = value;
                    this.RaisePropertyChanged("ProdutoReference");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Senha {
            get {
                return this.SenhaField;
            }
            set {
                if ((object.ReferenceEquals(this.SenhaField, value) != true)) {
                    this.SenhaField = value;
                    this.RaisePropertyChanged("Senha");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ModeloServicos.IModeloService")]
    public interface IModeloService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModeloService/Inserir", ReplyAction="http://tempuri.org/IModeloService/InserirResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PecaDica.App.ModeloServicos.DetalhamentoFalha), Action="http://tempuri.org/IModeloService/InserirDetalhamentoFalhaFault", Name="DetalhamentoFalha", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common")]
        void Inserir(PecaDica.App.ModeloServicos.Modelo item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModeloService/Deletar", ReplyAction="http://tempuri.org/IModeloService/DeletarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PecaDica.App.ModeloServicos.DetalhamentoFalha), Action="http://tempuri.org/IModeloService/DeletarDetalhamentoFalhaFault", Name="DetalhamentoFalha", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common")]
        void Deletar(PecaDica.App.ModeloServicos.Modelo item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IModeloService/Alterar", ReplyAction="http://tempuri.org/IModeloService/AlterarResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(PecaDica.App.ModeloServicos.DetalhamentoFalha), Action="http://tempuri.org/IModeloService/AlterarDetalhamentoFalhaFault", Name="DetalhamentoFalha", Namespace="http://schemas.datacontract.org/2004/07/PecaDicas.Contratos.Common")]
        void Alterar(PecaDica.App.ModeloServicos.Modelo item);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IModeloServiceChannel : PecaDica.App.ModeloServicos.IModeloService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ModeloServiceClient : System.ServiceModel.ClientBase<PecaDica.App.ModeloServicos.IModeloService>, PecaDica.App.ModeloServicos.IModeloService {
        
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
        
        public void Inserir(PecaDica.App.ModeloServicos.Modelo item) {
            base.Channel.Inserir(item);
        }
        
        public void Deletar(PecaDica.App.ModeloServicos.Modelo item) {
            base.Channel.Deletar(item);
        }
        
        public void Alterar(PecaDica.App.ModeloServicos.Modelo item) {
            base.Channel.Alterar(item);
        }
    }
}
