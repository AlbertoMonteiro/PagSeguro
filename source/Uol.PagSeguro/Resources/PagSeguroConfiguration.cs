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
//   limitations under the License.

using System;
using Uol.PagSeguro.Domain;
using Uol.PagSeguro.XmlParse;

namespace Uol.PagSeguro.Resources
{
    /// <summary>
    /// 
    /// </summary>
    public static class PagSeguroConfiguration
    {
        /// <summary>
        /// 
        /// 
        /// </summary>
        /// 
        public static AccountCredentials Credentials() => PagSeguroConfigurationManager.GetAccountCredentials();

        /// <summary>
        /// 
        /// </summary>
        public static string ModuleVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string CmsVersion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public static string LanguageEngineDescription => Environment.Version.ToString();

        /// <summary>
        /// 
        /// </summary>
        public static Uri NotificationUri => new Uri(GetUrlValue(PagSeguroConfigurationManager.Notification));

        /// <summary>
        /// 
        /// </summary>
        public static Uri PaymentUri => new Uri(GetUrlValue(PagSeguroConfigurationManager.Payment));

        /// <summary>
        /// 
        /// </summary>
        public static Uri PaymentRedirectUri => new Uri(GetUrlValue(PagSeguroConfigurationManager.PaymentRedirect));

        /// <summary>
        /// 
        /// </summary>
        public static Uri SearchUri => new Uri(GetUrlValue(PagSeguroConfigurationManager.Search));

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalUri => new Uri(GetUrlValue(PagSeguroConfigurationManager.PreApproval));

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalRedirectUri => new Uri(GetUrlValue(PagSeguroConfigurationManager.PreApprovalRedirect));

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalNotificationUri => new Uri(GetUrlValue(PagSeguroConfigurationManager.PreApprovalNotification));

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalSearchUri => new Uri(GetUrlValue(PagSeguroConfigurationManager.PreApprovalSearch));

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalCancelUri => new Uri(GetUrlValue(PagSeguroConfigurationManager.PreApprovalCancel));

        /// <summary>
        /// 
        /// </summary>
        public static Uri PreApprovalPaymentUri => new Uri(GetUrlValue(PagSeguroConfigurationManager.PreApprovalPayment));

        /// <summary>
        /// 
        /// </summary>
        public static int RequestTimeout => Convert.ToInt32(GetDataConfiguration(PagSeguroConfigurationManager.RequestTimeout));

        /// <summary>
        /// 
        /// </summary>
        public static string FormUrlEncoded => GetDataConfiguration(PagSeguroConfigurationManager.FormUrlEncoded);

        /// <summary>
        /// 
        /// </summary>
        public static string Encoding => GetDataConfiguration(PagSeguroConfigurationManager.Encoding);

        /// <summary>
        /// 
        /// </summary>
        public static string LibVersion => GetDataConfiguration(PagSeguroConfigurationManager.LibVersion);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static string GetUrlValue(string url) => PagSeguroConfigurationManager.GetWebserviceUrl(url);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        private static string GetDataConfiguration(string data) => PagSeguroConfigurationManager.GetDataConfiguration(data);
    }
}
