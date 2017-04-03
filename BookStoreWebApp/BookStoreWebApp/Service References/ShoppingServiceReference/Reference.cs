﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStoreWebApp.ShoppingServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShoppingServiceReference.IRepositoryOf_ShoppingCart")]
    public interface IRepositoryOf_ShoppingCart {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepositoryOf_ShoppingCart/GetAll", ReplyAction="http://tempuri.org/IRepositoryOf_ShoppingCart/GetAllResponse")]
        ModelPoco.ShoppingCart[] GetAll();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepositoryOf_ShoppingCart/GetAll", ReplyAction="http://tempuri.org/IRepositoryOf_ShoppingCart/GetAllResponse")]
        System.Threading.Tasks.Task<ModelPoco.ShoppingCart[]> GetAllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepositoryOf_ShoppingCart/Find", ReplyAction="http://tempuri.org/IRepositoryOf_ShoppingCart/FindResponse")]
        ModelPoco.ShoppingCart Find(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepositoryOf_ShoppingCart/Find", ReplyAction="http://tempuri.org/IRepositoryOf_ShoppingCart/FindResponse")]
        System.Threading.Tasks.Task<ModelPoco.ShoppingCart> FindAsync(int ID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepositoryOf_ShoppingCart/Add", ReplyAction="http://tempuri.org/IRepositoryOf_ShoppingCart/AddResponse")]
        int Add(ModelPoco.ShoppingCart entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepositoryOf_ShoppingCart/Add", ReplyAction="http://tempuri.org/IRepositoryOf_ShoppingCart/AddResponse")]
        System.Threading.Tasks.Task<int> AddAsync(ModelPoco.ShoppingCart entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepositoryOf_ShoppingCart/Update", ReplyAction="http://tempuri.org/IRepositoryOf_ShoppingCart/UpdateResponse")]
        void Update(ModelPoco.ShoppingCart entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepositoryOf_ShoppingCart/Update", ReplyAction="http://tempuri.org/IRepositoryOf_ShoppingCart/UpdateResponse")]
        System.Threading.Tasks.Task UpdateAsync(ModelPoco.ShoppingCart entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepositoryOf_ShoppingCart/Delete", ReplyAction="http://tempuri.org/IRepositoryOf_ShoppingCart/DeleteResponse")]
        void Delete(ModelPoco.ShoppingCart entity);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRepositoryOf_ShoppingCart/Delete", ReplyAction="http://tempuri.org/IRepositoryOf_ShoppingCart/DeleteResponse")]
        System.Threading.Tasks.Task DeleteAsync(ModelPoco.ShoppingCart entity);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRepositoryOf_ShoppingCartChannel : BookStoreWebApp.ShoppingServiceReference.IRepositoryOf_ShoppingCart, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RepositoryOf_ShoppingCartClient : System.ServiceModel.ClientBase<BookStoreWebApp.ShoppingServiceReference.IRepositoryOf_ShoppingCart>, BookStoreWebApp.ShoppingServiceReference.IRepositoryOf_ShoppingCart {
        
        public RepositoryOf_ShoppingCartClient() {
        }
        
        public RepositoryOf_ShoppingCartClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RepositoryOf_ShoppingCartClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RepositoryOf_ShoppingCartClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RepositoryOf_ShoppingCartClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ModelPoco.ShoppingCart[] GetAll() {
            return base.Channel.GetAll();
        }
        
        public System.Threading.Tasks.Task<ModelPoco.ShoppingCart[]> GetAllAsync() {
            return base.Channel.GetAllAsync();
        }
        
        public ModelPoco.ShoppingCart Find(int ID) {
            return base.Channel.Find(ID);
        }
        
        public System.Threading.Tasks.Task<ModelPoco.ShoppingCart> FindAsync(int ID) {
            return base.Channel.FindAsync(ID);
        }
        
        public int Add(ModelPoco.ShoppingCart entity) {
            return base.Channel.Add(entity);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(ModelPoco.ShoppingCart entity) {
            return base.Channel.AddAsync(entity);
        }
        
        public void Update(ModelPoco.ShoppingCart entity) {
            base.Channel.Update(entity);
        }
        
        public System.Threading.Tasks.Task UpdateAsync(ModelPoco.ShoppingCart entity) {
            return base.Channel.UpdateAsync(entity);
        }
        
        public void Delete(ModelPoco.ShoppingCart entity) {
            base.Channel.Delete(entity);
        }
        
        public System.Threading.Tasks.Task DeleteAsync(ModelPoco.ShoppingCart entity) {
            return base.Channel.DeleteAsync(entity);
        }
    }
}