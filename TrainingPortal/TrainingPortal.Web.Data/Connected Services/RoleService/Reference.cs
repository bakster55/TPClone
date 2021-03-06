﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrainingPortal.Web.Data.RoleService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="RoleDto", Namespace="http://schemas.datacontract.org/2004/07/TrainingPortal.Service.Dto")]
    [System.SerializableAttribute()]
    public partial class RoleDto : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
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
        public string Id {
            get {
                return this.IdField;
            }
            set {
                if ((object.ReferenceEquals(this.IdField, value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RoleService.IRoleService")]
    public interface IRoleService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoleService/GetList", ReplyAction="http://tempuri.org/IRoleService/GetListResponse")]
        TrainingPortal.Web.Data.RoleService.RoleDto[] GetList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoleService/Get", ReplyAction="http://tempuri.org/IRoleService/GetResponse")]
        TrainingPortal.Web.Data.RoleService.RoleDto Get(string id, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoleService/Update", ReplyAction="http://tempuri.org/IRoleService/UpdateResponse")]
        void Update(TrainingPortal.Web.Data.RoleService.RoleDto role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoleService/Create", ReplyAction="http://tempuri.org/IRoleService/CreateResponse")]
        string Create(TrainingPortal.Web.Data.RoleService.RoleDto role);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRoleService/Delete", ReplyAction="http://tempuri.org/IRoleService/DeleteResponse")]
        void Delete(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRoleServiceChannel : TrainingPortal.Web.Data.RoleService.IRoleService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RoleServiceClient : System.ServiceModel.ClientBase<TrainingPortal.Web.Data.RoleService.IRoleService>, TrainingPortal.Web.Data.RoleService.IRoleService {
        
        public RoleServiceClient() {
        }
        
        public RoleServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RoleServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoleServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RoleServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public TrainingPortal.Web.Data.RoleService.RoleDto[] GetList() {
            return base.Channel.GetList();
        }
        
        public TrainingPortal.Web.Data.RoleService.RoleDto Get(string id, string name) {
            return base.Channel.Get(id, name);
        }
        
        public void Update(TrainingPortal.Web.Data.RoleService.RoleDto role) {
            base.Channel.Update(role);
        }
        
        public string Create(TrainingPortal.Web.Data.RoleService.RoleDto role) {
            return base.Channel.Create(role);
        }
        
        public void Delete(string id) {
            base.Channel.Delete(id);
        }
    }
}
