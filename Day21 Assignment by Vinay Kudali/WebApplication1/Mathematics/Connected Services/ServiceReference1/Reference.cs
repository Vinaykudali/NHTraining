﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mathematics.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int m, int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int m, int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        int Mul(int m, int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        System.Threading.Tasks.Task<int> MulAsync(int m, int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Div", ReplyAction="*")]
        int Div(int m, int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Div", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DivAsync(int m, int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Factorial", ReplyAction="*")]
        int Factorial(int n);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Factorial", ReplyAction="*")]
        System.Threading.Tasks.Task<int> FactorialAsync(int n);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Mathematics.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Mathematics.ServiceReference1.WebService1Soap>, Mathematics.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int m, int n) {
            return base.Channel.Add(m, n);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int m, int n) {
            return base.Channel.AddAsync(m, n);
        }
        
        public int Mul(int m, int n) {
            return base.Channel.Mul(m, n);
        }
        
        public System.Threading.Tasks.Task<int> MulAsync(int m, int n) {
            return base.Channel.MulAsync(m, n);
        }
        
        public int Div(int m, int n) {
            return base.Channel.Div(m, n);
        }
        
        public System.Threading.Tasks.Task<int> DivAsync(int m, int n) {
            return base.Channel.DivAsync(m, n);
        }
        
        public int Factorial(int n) {
            return base.Channel.Factorial(n);
        }
        
        public System.Threading.Tasks.Task<int> FactorialAsync(int n) {
            return base.Channel.FactorialAsync(n);
        }
    }
}
