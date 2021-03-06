﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace Socioboard.Api.FbPageLiker {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="FbPageLikerSoap", Namespace="http://tempuri.org/")]
    public partial class FbPageLiker : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetLikeByPostIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback IsLikeExistOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddLikeDetailsOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FbPageLiker() {
            this.Url = global::Socioboard.Properties.Settings.Default.Socioboard_Api_FbPageLiker_FbPageLiker;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetLikeByPostIdCompletedEventHandler GetLikeByPostIdCompleted;
        
        /// <remarks/>
        public event IsLikeExistCompletedEventHandler IsLikeExistCompleted;
        
        /// <remarks/>
        public event AddLikeDetailsCompletedEventHandler AddLikeDetailsCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetLikeByPostId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string GetLikeByPostId(string postId, string Userid) {
            object[] results = this.Invoke("GetLikeByPostId", new object[] {
                        postId,
                        Userid});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetLikeByPostIdAsync(string postId, string Userid) {
            this.GetLikeByPostIdAsync(postId, Userid, null);
        }
        
        /// <remarks/>
        public void GetLikeByPostIdAsync(string postId, string Userid, object userState) {
            if ((this.GetLikeByPostIdOperationCompleted == null)) {
                this.GetLikeByPostIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetLikeByPostIdOperationCompleted);
            }
            this.InvokeAsync("GetLikeByPostId", new object[] {
                        postId,
                        Userid}, this.GetLikeByPostIdOperationCompleted, userState);
        }
        
        private void OnGetLikeByPostIdOperationCompleted(object arg) {
            if ((this.GetLikeByPostIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetLikeByPostIdCompleted(this, new GetLikeByPostIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/IsLikeExist", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool IsLikeExist(string Jdata) {
            object[] results = this.Invoke("IsLikeExist", new object[] {
                        Jdata});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void IsLikeExistAsync(string Jdata) {
            this.IsLikeExistAsync(Jdata, null);
        }
        
        /// <remarks/>
        public void IsLikeExistAsync(string Jdata, object userState) {
            if ((this.IsLikeExistOperationCompleted == null)) {
                this.IsLikeExistOperationCompleted = new System.Threading.SendOrPostCallback(this.OnIsLikeExistOperationCompleted);
            }
            this.InvokeAsync("IsLikeExist", new object[] {
                        Jdata}, this.IsLikeExistOperationCompleted, userState);
        }
        
        private void OnIsLikeExistOperationCompleted(object arg) {
            if ((this.IsLikeExistCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.IsLikeExistCompleted(this, new IsLikeExistCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddLikeDetails", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddLikeDetails(string Jdata) {
            object[] results = this.Invoke("AddLikeDetails", new object[] {
                        Jdata});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddLikeDetailsAsync(string Jdata) {
            this.AddLikeDetailsAsync(Jdata, null);
        }
        
        /// <remarks/>
        public void AddLikeDetailsAsync(string Jdata, object userState) {
            if ((this.AddLikeDetailsOperationCompleted == null)) {
                this.AddLikeDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddLikeDetailsOperationCompleted);
            }
            this.InvokeAsync("AddLikeDetails", new object[] {
                        Jdata}, this.AddLikeDetailsOperationCompleted, userState);
        }
        
        private void OnAddLikeDetailsOperationCompleted(object arg) {
            if ((this.AddLikeDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddLikeDetailsCompleted(this, new AddLikeDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void GetLikeByPostIdCompletedEventHandler(object sender, GetLikeByPostIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetLikeByPostIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetLikeByPostIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void IsLikeExistCompletedEventHandler(object sender, IsLikeExistCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class IsLikeExistCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal IsLikeExistCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void AddLikeDetailsCompletedEventHandler(object sender, AddLikeDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddLikeDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddLikeDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591