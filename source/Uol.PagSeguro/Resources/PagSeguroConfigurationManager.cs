// Copyright [2011] [PagSeguro Internet Ltda.]
//
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at
//
//       http://www.apache.org/licenses/LICENSE-2.0
//
//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitation

using System;
using System.Configuration;
using Uol.PagSeguro.Domain;

namespace Uol.PagSeguro.Resources
{
    /// <summary>
    /// 
    /// </summary>
    internal static class PagSeguroConfigurationManager
    {

        internal static string Email => EnvironmentConfiguration.IsSandBox() ? "Sandbox.Email" : "Email";
        internal static string Token => EnvironmentConfiguration.IsSandBox() ? "Sandbox.Token" : "Token";

        internal const string AttributeNamespace = "PagSeguro";
        internal const string Payment = "Payment";
        internal const string PaymentRedirect = "PaymentRedirect";
        internal const string Notification = "Notification";
        internal const string Search = "Search";
        internal const string PreApproval = "PreApproval";
        internal const string PreApprovalRedirect = "PreApprovalRedirect";
        internal const string PreApprovalNotification = "PreApprovalNotification";
        internal const string PreApprovalSearch = "PreApprovalSearch";
        internal const string PreApprovalCancel = "PreApprovalCancel";
        internal const string PreApprovalPayment = "PreApprovalPayment";
        internal const string LibVersion = "LibVersion";
        internal const string FormUrlEncoded = "FormUrlEncoded";
        internal const string Encoding = "Encoding";
        internal const string RequestTimeout = "RequestTimeout";

        /// <summary>
        /// 
        /// </summary>
        /// <param name="urlToSearch"></param>
        /// <returns></returns>
        internal static string GetWebserviceUrl(string urlToSearch)
        {
            var url = GetDataConfiguration(urlToSearch);
            if (string.IsNullOrEmpty(url))
                throw new ArgumentException(" WebService URL not set for " + urlToSearch + " environment.");

            return EnvironmentConfiguration.IsSandBox() ? url.Replace("pagseguro.", "sandbox.pagseguro.") : url;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        internal static string GetDataConfiguration(string data)
        {
            var result = ConfigurationManager.AppSettings[$"{AttributeNamespace}.{data}"];
            if (string.IsNullOrEmpty(result))
                throw new ArgumentException(" Resources key " + data + " not found.");
            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        internal static AccountCredentials GetAccountCredentials()
        {
            var email = GetDataConfiguration(Email);
            var token = GetDataConfiguration(Token);
            return new AccountCredentials(email, token);
        }
    }
}