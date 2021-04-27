﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace inkMap.NewAccountService {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="NewAccountSoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(object[]))]
    public partial class NewAccount : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback AddAccountOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddArtistOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddCustomerOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetArtistByZipOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddTestimonialOperationCompleted;
        
        private System.Threading.SendOrPostCallback ScheduleAppointmentOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public NewAccount() {
            this.Url = global::inkMap.Properties.Settings.Default.inkMap_NewAccountService_NewAccount;
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
        public event AddAccountCompletedEventHandler AddAccountCompleted;
        
        /// <remarks/>
        public event AddArtistCompletedEventHandler AddArtistCompleted;
        
        /// <remarks/>
        public event AddCustomerCompletedEventHandler AddCustomerCompleted;
        
        /// <remarks/>
        public event GetArtistByZipCompletedEventHandler GetArtistByZipCompleted;
        
        /// <remarks/>
        public event AddTestimonialCompletedEventHandler AddTestimonialCompleted;
        
        /// <remarks/>
        public event ScheduleAppointmentCompletedEventHandler ScheduleAppointmentCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddAccount", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddAccount(Account newAccount) {
            object[] results = this.Invoke("AddAccount", new object[] {
                        newAccount});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddAccountAsync(Account newAccount) {
            this.AddAccountAsync(newAccount, null);
        }
        
        /// <remarks/>
        public void AddAccountAsync(Account newAccount, object userState) {
            if ((this.AddAccountOperationCompleted == null)) {
                this.AddAccountOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddAccountOperationCompleted);
            }
            this.InvokeAsync("AddAccount", new object[] {
                        newAccount}, this.AddAccountOperationCompleted, userState);
        }
        
        private void OnAddAccountOperationCompleted(object arg) {
            if ((this.AddAccountCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddAccountCompleted(this, new AddAccountCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddArtist", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddArtist(Artist art) {
            object[] results = this.Invoke("AddArtist", new object[] {
                        art});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddArtistAsync(Artist art) {
            this.AddArtistAsync(art, null);
        }
        
        /// <remarks/>
        public void AddArtistAsync(Artist art, object userState) {
            if ((this.AddArtistOperationCompleted == null)) {
                this.AddArtistOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddArtistOperationCompleted);
            }
            this.InvokeAsync("AddArtist", new object[] {
                        art}, this.AddArtistOperationCompleted, userState);
        }
        
        private void OnAddArtistOperationCompleted(object arg) {
            if ((this.AddArtistCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddArtistCompleted(this, new AddArtistCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddCustomer", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddCustomer(Account customer) {
            object[] results = this.Invoke("AddCustomer", new object[] {
                        customer});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddCustomerAsync(Account customer) {
            this.AddCustomerAsync(customer, null);
        }
        
        /// <remarks/>
        public void AddCustomerAsync(Account customer, object userState) {
            if ((this.AddCustomerOperationCompleted == null)) {
                this.AddCustomerOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddCustomerOperationCompleted);
            }
            this.InvokeAsync("AddCustomer", new object[] {
                        customer}, this.AddCustomerOperationCompleted, userState);
        }
        
        private void OnAddCustomerOperationCompleted(object arg) {
            if ((this.AddCustomerCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddCustomerCompleted(this, new AddCustomerCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetArtistByZip", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public object[] GetArtistByZip(string zip) {
            object[] results = this.Invoke("GetArtistByZip", new object[] {
                        zip});
            return ((object[])(results[0]));
        }
        
        /// <remarks/>
        public void GetArtistByZipAsync(string zip) {
            this.GetArtistByZipAsync(zip, null);
        }
        
        /// <remarks/>
        public void GetArtistByZipAsync(string zip, object userState) {
            if ((this.GetArtistByZipOperationCompleted == null)) {
                this.GetArtistByZipOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetArtistByZipOperationCompleted);
            }
            this.InvokeAsync("GetArtistByZip", new object[] {
                        zip}, this.GetArtistByZipOperationCompleted, userState);
        }
        
        private void OnGetArtistByZipOperationCompleted(object arg) {
            if ((this.GetArtistByZipCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetArtistByZipCompleted(this, new GetArtistByZipCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/AddTestimonial", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool AddTestimonial(Testimonial comment) {
            object[] results = this.Invoke("AddTestimonial", new object[] {
                        comment});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void AddTestimonialAsync(Testimonial comment) {
            this.AddTestimonialAsync(comment, null);
        }
        
        /// <remarks/>
        public void AddTestimonialAsync(Testimonial comment, object userState) {
            if ((this.AddTestimonialOperationCompleted == null)) {
                this.AddTestimonialOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddTestimonialOperationCompleted);
            }
            this.InvokeAsync("AddTestimonial", new object[] {
                        comment}, this.AddTestimonialOperationCompleted, userState);
        }
        
        private void OnAddTestimonialOperationCompleted(object arg) {
            if ((this.AddTestimonialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddTestimonialCompleted(this, new AddTestimonialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ScheduleAppointment", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool ScheduleAppointment(Appointment appt) {
            object[] results = this.Invoke("ScheduleAppointment", new object[] {
                        appt});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public void ScheduleAppointmentAsync(Appointment appt) {
            this.ScheduleAppointmentAsync(appt, null);
        }
        
        /// <remarks/>
        public void ScheduleAppointmentAsync(Appointment appt, object userState) {
            if ((this.ScheduleAppointmentOperationCompleted == null)) {
                this.ScheduleAppointmentOperationCompleted = new System.Threading.SendOrPostCallback(this.OnScheduleAppointmentOperationCompleted);
            }
            this.InvokeAsync("ScheduleAppointment", new object[] {
                        appt}, this.ScheduleAppointmentOperationCompleted, userState);
        }
        
        private void OnScheduleAppointmentOperationCompleted(object arg) {
            if ((this.ScheduleAppointmentCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ScheduleAppointmentCompleted(this, new ScheduleAppointmentCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Account {
        
        private string passwordField;
        
        private string accountTypeField;
        
        private string firstNameField;
        
        private string lastNameField;
        
        private string emailField;
        
        private string phoneNumberField;
        
        private string passwordField1;
        
        private string accountTypeField1;
        
        private string firstNameField1;
        
        private string lastNameField1;
        
        private string emailField1;
        
        private string phoneNumberField1;
        
        /// <remarks/>
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
            }
        }
        
        /// <remarks/>
        public string accountType {
            get {
                return this.accountTypeField;
            }
            set {
                this.accountTypeField = value;
            }
        }
        
        /// <remarks/>
        public string firstName {
            get {
                return this.firstNameField;
            }
            set {
                this.firstNameField = value;
            }
        }
        
        /// <remarks/>
        public string lastName {
            get {
                return this.lastNameField;
            }
            set {
                this.lastNameField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string phoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string Password {
            get {
                return this.passwordField1;
            }
            set {
                this.passwordField1 = value;
            }
        }
        
        /// <remarks/>
        public string AccountType {
            get {
                return this.accountTypeField1;
            }
            set {
                this.accountTypeField1 = value;
            }
        }
        
        /// <remarks/>
        public string FirstName {
            get {
                return this.firstNameField1;
            }
            set {
                this.firstNameField1 = value;
            }
        }
        
        /// <remarks/>
        public string LastName {
            get {
                return this.lastNameField1;
            }
            set {
                this.lastNameField1 = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField1;
            }
            set {
                this.emailField1 = value;
            }
        }
        
        /// <remarks/>
        public string PhoneNumber {
            get {
                return this.phoneNumberField1;
            }
            set {
                this.phoneNumberField1 = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Testimonial {
        
        private int testimonial_IDField;
        
        private int artist_IDField;
        
        private int cust_IDField;
        
        private string titleField;
        
        private string bodyField;
        
        private string artist_FNameField;
        
        private string artist_LNameField;
        
        private int testimonial_IDField1;
        
        private int artist_IDField1;
        
        private int cust_IDField1;
        
        private string titleField1;
        
        private string bodyField1;
        
        private string artist_FNameField1;
        
        private string artist_LNameField1;
        
        /// <remarks/>
        public int testimonial_ID {
            get {
                return this.testimonial_IDField;
            }
            set {
                this.testimonial_IDField = value;
            }
        }
        
        /// <remarks/>
        public int artist_ID {
            get {
                return this.artist_IDField;
            }
            set {
                this.artist_IDField = value;
            }
        }
        
        /// <remarks/>
        public int cust_ID {
            get {
                return this.cust_IDField;
            }
            set {
                this.cust_IDField = value;
            }
        }
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string body {
            get {
                return this.bodyField;
            }
            set {
                this.bodyField = value;
            }
        }
        
        /// <remarks/>
        public string artist_FName {
            get {
                return this.artist_FNameField;
            }
            set {
                this.artist_FNameField = value;
            }
        }
        
        /// <remarks/>
        public string artist_LName {
            get {
                return this.artist_LNameField;
            }
            set {
                this.artist_LNameField = value;
            }
        }
        
        /// <remarks/>
        public int Testimonial_ID {
            get {
                return this.testimonial_IDField1;
            }
            set {
                this.testimonial_IDField1 = value;
            }
        }
        
        /// <remarks/>
        public int Artist_ID {
            get {
                return this.artist_IDField1;
            }
            set {
                this.artist_IDField1 = value;
            }
        }
        
        /// <remarks/>
        public int Cust_ID {
            get {
                return this.cust_IDField1;
            }
            set {
                this.cust_IDField1 = value;
            }
        }
        
        /// <remarks/>
        public string Title {
            get {
                return this.titleField1;
            }
            set {
                this.titleField1 = value;
            }
        }
        
        /// <remarks/>
        public string Body {
            get {
                return this.bodyField1;
            }
            set {
                this.bodyField1 = value;
            }
        }
        
        /// <remarks/>
        public string Artist_FName {
            get {
                return this.artist_FNameField1;
            }
            set {
                this.artist_FNameField1 = value;
            }
        }
        
        /// <remarks/>
        public string Artist_LName {
            get {
                return this.artist_LNameField1;
            }
            set {
                this.artist_LNameField1 = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Appointment {
        
        private int artist_IDField;
        
        private int cust_IDField;
        
        private string dateField;
        
        private string timeField;
        
        private int artist_IDField1;
        
        private int cust_IDField1;
        
        private string dateField1;
        
        private string timeField1;
        
        /// <remarks/>
        public int artist_ID {
            get {
                return this.artist_IDField;
            }
            set {
                this.artist_IDField = value;
            }
        }
        
        /// <remarks/>
        public int cust_ID {
            get {
                return this.cust_IDField;
            }
            set {
                this.cust_IDField = value;
            }
        }
        
        /// <remarks/>
        public string date {
            get {
                return this.dateField;
            }
            set {
                this.dateField = value;
            }
        }
        
        /// <remarks/>
        public string time {
            get {
                return this.timeField;
            }
            set {
                this.timeField = value;
            }
        }
        
        /// <remarks/>
        public int Artist_ID {
            get {
                return this.artist_IDField1;
            }
            set {
                this.artist_IDField1 = value;
            }
        }
        
        /// <remarks/>
        public int Cust_ID {
            get {
                return this.cust_IDField1;
            }
            set {
                this.cust_IDField1 = value;
            }
        }
        
        /// <remarks/>
        public string Date {
            get {
                return this.dateField1;
            }
            set {
                this.dateField1 = value;
            }
        }
        
        /// <remarks/>
        public string Time {
            get {
                return this.timeField1;
            }
            set {
                this.timeField1 = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Artist {
        
        private string artist_FNameField;
        
        private string artist_LNameField;
        
        private string emailField;
        
        private string phoneNumberField;
        
        private string companyField;
        
        private decimal ratingField;
        
        private string certificationField;
        
        private string cityField;
        
        private string stateField;
        
        private string zipcodeField;
        
        private string streetAddressField;
        
        private string address2Field;
        
        private int artist_IDField;
        
        private string artist_FNameField1;
        
        private string artist_LNameField1;
        
        private string emailField1;
        
        private string phoneNumberField1;
        
        private string companyField1;
        
        private decimal ratingField1;
        
        private string certificationField1;
        
        private string cityField1;
        
        private string stateField1;
        
        private string zipcodeField1;
        
        private string streetAddressField1;
        
        private string address2Field1;
        
        private int artist_IDField1;
        
        /// <remarks/>
        public string artist_FName {
            get {
                return this.artist_FNameField;
            }
            set {
                this.artist_FNameField = value;
            }
        }
        
        /// <remarks/>
        public string artist_LName {
            get {
                return this.artist_LNameField;
            }
            set {
                this.artist_LNameField = value;
            }
        }
        
        /// <remarks/>
        public string email {
            get {
                return this.emailField;
            }
            set {
                this.emailField = value;
            }
        }
        
        /// <remarks/>
        public string phoneNumber {
            get {
                return this.phoneNumberField;
            }
            set {
                this.phoneNumberField = value;
            }
        }
        
        /// <remarks/>
        public string company {
            get {
                return this.companyField;
            }
            set {
                this.companyField = value;
            }
        }
        
        /// <remarks/>
        public decimal rating {
            get {
                return this.ratingField;
            }
            set {
                this.ratingField = value;
            }
        }
        
        /// <remarks/>
        public string certification {
            get {
                return this.certificationField;
            }
            set {
                this.certificationField = value;
            }
        }
        
        /// <remarks/>
        public string city {
            get {
                return this.cityField;
            }
            set {
                this.cityField = value;
            }
        }
        
        /// <remarks/>
        public string state {
            get {
                return this.stateField;
            }
            set {
                this.stateField = value;
            }
        }
        
        /// <remarks/>
        public string zipcode {
            get {
                return this.zipcodeField;
            }
            set {
                this.zipcodeField = value;
            }
        }
        
        /// <remarks/>
        public string streetAddress {
            get {
                return this.streetAddressField;
            }
            set {
                this.streetAddressField = value;
            }
        }
        
        /// <remarks/>
        public string address2 {
            get {
                return this.address2Field;
            }
            set {
                this.address2Field = value;
            }
        }
        
        /// <remarks/>
        public int artist_ID {
            get {
                return this.artist_IDField;
            }
            set {
                this.artist_IDField = value;
            }
        }
        
        /// <remarks/>
        public string Artist_FName {
            get {
                return this.artist_FNameField1;
            }
            set {
                this.artist_FNameField1 = value;
            }
        }
        
        /// <remarks/>
        public string Artist_LName {
            get {
                return this.artist_LNameField1;
            }
            set {
                this.artist_LNameField1 = value;
            }
        }
        
        /// <remarks/>
        public string Email {
            get {
                return this.emailField1;
            }
            set {
                this.emailField1 = value;
            }
        }
        
        /// <remarks/>
        public string PhoneNumber {
            get {
                return this.phoneNumberField1;
            }
            set {
                this.phoneNumberField1 = value;
            }
        }
        
        /// <remarks/>
        public string Company {
            get {
                return this.companyField1;
            }
            set {
                this.companyField1 = value;
            }
        }
        
        /// <remarks/>
        public decimal Rating {
            get {
                return this.ratingField1;
            }
            set {
                this.ratingField1 = value;
            }
        }
        
        /// <remarks/>
        public string Certification {
            get {
                return this.certificationField1;
            }
            set {
                this.certificationField1 = value;
            }
        }
        
        /// <remarks/>
        public string City {
            get {
                return this.cityField1;
            }
            set {
                this.cityField1 = value;
            }
        }
        
        /// <remarks/>
        public string State {
            get {
                return this.stateField1;
            }
            set {
                this.stateField1 = value;
            }
        }
        
        /// <remarks/>
        public string Zipcode {
            get {
                return this.zipcodeField1;
            }
            set {
                this.zipcodeField1 = value;
            }
        }
        
        /// <remarks/>
        public string StreetAddress {
            get {
                return this.streetAddressField1;
            }
            set {
                this.streetAddressField1 = value;
            }
        }
        
        /// <remarks/>
        public string Address2 {
            get {
                return this.address2Field1;
            }
            set {
                this.address2Field1 = value;
            }
        }
        
        /// <remarks/>
        public int Artist_ID {
            get {
                return this.artist_IDField1;
            }
            set {
                this.artist_IDField1 = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AddAccountCompletedEventHandler(object sender, AddAccountCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AddArtistCompletedEventHandler(object sender, AddArtistCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddArtistCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddArtistCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AddCustomerCompletedEventHandler(object sender, AddCustomerCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void GetArtistByZipCompletedEventHandler(object sender, GetArtistByZipCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetArtistByZipCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetArtistByZipCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public object[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((object[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void AddTestimonialCompletedEventHandler(object sender, AddTestimonialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddTestimonialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddTestimonialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ScheduleAppointmentCompletedEventHandler(object sender, ScheduleAppointmentCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScheduleAppointmentCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ScheduleAppointmentCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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