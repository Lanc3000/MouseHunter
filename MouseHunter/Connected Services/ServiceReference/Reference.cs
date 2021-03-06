//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MouseHunter.ServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Authorization", ReplyAction="http://tempuri.org/IService1/AuthorizationResponse")]
        bool Authorization(string log, string pas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Authorization", ReplyAction="http://tempuri.org/IService1/AuthorizationResponse")]
        System.Threading.Tasks.Task<bool> AuthorizationAsync(string log, string pas);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        void Insert(WcfMouceService.MouseEv mouse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Insert", ReplyAction="http://tempuri.org/IService1/InsertResponse")]
        System.Threading.Tasks.Task InsertAsync(WcfMouceService.MouseEv mouse);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadFromDB", ReplyAction="http://tempuri.org/IService1/LoadFromDBResponse")]
        System.Data.DataTable LoadFromDB();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/LoadFromDB", ReplyAction="http://tempuri.org/IService1/LoadFromDBResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> LoadFromDBAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetInfo", ReplyAction="http://tempuri.org/IService1/GetInfoResponse")]
        WcfMouceService.GetEventData GetInfo();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetInfo", ReplyAction="http://tempuri.org/IService1/GetInfoResponse")]
        System.Threading.Tasks.Task<WcfMouceService.GetEventData> GetInfoAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : MouseHunter.ServiceReference.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<MouseHunter.ServiceReference.IService1>, MouseHunter.ServiceReference.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Authorization(string log, string pas) {
            return base.Channel.Authorization(log, pas);
        }
        
        public System.Threading.Tasks.Task<bool> AuthorizationAsync(string log, string pas) {
            return base.Channel.AuthorizationAsync(log, pas);
        }
        
        public void Insert(WcfMouceService.MouseEv mouse) {
            base.Channel.Insert(mouse);
        }
        
        public System.Threading.Tasks.Task InsertAsync(WcfMouceService.MouseEv mouse) {
            return base.Channel.InsertAsync(mouse);
        }
        
        public System.Data.DataTable LoadFromDB() {
            return base.Channel.LoadFromDB();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> LoadFromDBAsync() {
            return base.Channel.LoadFromDBAsync();
        }
        
        public WcfMouceService.GetEventData GetInfo() {
            return base.Channel.GetInfo();
        }
        
        public System.Threading.Tasks.Task<WcfMouceService.GetEventData> GetInfoAsync() {
            return base.Channel.GetInfoAsync();
        }
    }
}
