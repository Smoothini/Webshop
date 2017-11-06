﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShopFormsClient.CategoryReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CategoryReference.ICategory")]
    public interface ICategory {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/CreateCategory", ReplyAction="http://tempuri.org/ICategory/CreateCategoryResponse")]
        bool CreateCategory(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/CreateCategory", ReplyAction="http://tempuri.org/ICategory/CreateCategoryResponse")]
        System.Threading.Tasks.Task<bool> CreateCategoryAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/ReadCategory", ReplyAction="http://tempuri.org/ICategory/ReadCategoryResponse")]
        void ReadCategory(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/ReadCategory", ReplyAction="http://tempuri.org/ICategory/ReadCategoryResponse")]
        System.Threading.Tasks.Task ReadCategoryAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/UpdateCategory", ReplyAction="http://tempuri.org/ICategory/UpdateCategoryResponse")]
        bool UpdateCategory(string oldName, string newName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/UpdateCategory", ReplyAction="http://tempuri.org/ICategory/UpdateCategoryResponse")]
        System.Threading.Tasks.Task<bool> UpdateCategoryAsync(string oldName, string newName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/DeleteCategory", ReplyAction="http://tempuri.org/ICategory/DeleteCategoryResponse")]
        bool DeleteCategory(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/DeleteCategory", ReplyAction="http://tempuri.org/ICategory/DeleteCategoryResponse")]
        System.Threading.Tasks.Task<bool> DeleteCategoryAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/GetCategoriesAsList", ReplyAction="http://tempuri.org/ICategory/GetCategoriesAsListResponse")]
        string[] GetCategoriesAsList();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/GetCategoriesAsList", ReplyAction="http://tempuri.org/ICategory/GetCategoriesAsListResponse")]
        System.Threading.Tasks.Task<string[]> GetCategoriesAsListAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/IdToName", ReplyAction="http://tempuri.org/ICategory/IdToNameResponse")]
        string IdToName(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/IdToName", ReplyAction="http://tempuri.org/ICategory/IdToNameResponse")]
        System.Threading.Tasks.Task<string> IdToNameAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/NameToId", ReplyAction="http://tempuri.org/ICategory/NameToIdResponse")]
        int NameToId(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICategory/NameToId", ReplyAction="http://tempuri.org/ICategory/NameToIdResponse")]
        System.Threading.Tasks.Task<int> NameToIdAsync(string name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICategoryChannel : ShopFormsClient.CategoryReference.ICategory, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CategoryClient : System.ServiceModel.ClientBase<ShopFormsClient.CategoryReference.ICategory>, ShopFormsClient.CategoryReference.ICategory {
        
        public CategoryClient() {
        }
        
        public CategoryClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CategoryClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CategoryClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CreateCategory(string name) {
            return base.Channel.CreateCategory(name);
        }
        
        public System.Threading.Tasks.Task<bool> CreateCategoryAsync(string name) {
            return base.Channel.CreateCategoryAsync(name);
        }
        
        public void ReadCategory(int id) {
            base.Channel.ReadCategory(id);
        }
        
        public System.Threading.Tasks.Task ReadCategoryAsync(int id) {
            return base.Channel.ReadCategoryAsync(id);
        }
        
        public bool UpdateCategory(string oldName, string newName) {
            return base.Channel.UpdateCategory(oldName, newName);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateCategoryAsync(string oldName, string newName) {
            return base.Channel.UpdateCategoryAsync(oldName, newName);
        }
        
        public bool DeleteCategory(string name) {
            return base.Channel.DeleteCategory(name);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteCategoryAsync(string name) {
            return base.Channel.DeleteCategoryAsync(name);
        }
        
        public string[] GetCategoriesAsList() {
            return base.Channel.GetCategoriesAsList();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCategoriesAsListAsync() {
            return base.Channel.GetCategoriesAsListAsync();
        }
        
        public string IdToName(int id) {
            return base.Channel.IdToName(id);
        }
        
        public System.Threading.Tasks.Task<string> IdToNameAsync(int id) {
            return base.Channel.IdToNameAsync(id);
        }
        
        public int NameToId(string name) {
            return base.Channel.NameToId(name);
        }
        
        public System.Threading.Tasks.Task<int> NameToIdAsync(string name) {
            return base.Channel.NameToIdAsync(name);
        }
    }
}