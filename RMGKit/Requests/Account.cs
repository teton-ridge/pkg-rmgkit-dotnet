using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// Defines Account requests.
/// </summary>
namespace RMGKit.Requests
{
    /// <summary>
    /// Available media endpoints.
    /// </summary>
    /// public sealed class Media : Request
    public sealed class Account : Request
    {
        public static class Endpoints
        {
            public static readonly string registerForCheckout = "device/v2/customer/registercheckout";
            public static readonly string authenticateForCheckout = "device/v2/customer/authenticatecheckout";
            public static readonly string authenticate = "device/v2/customer/authenticate";
            public static readonly string getPaymentInfo = "device/v2/customer/getpaymentinfo";
            public static readonly string subscribe = "device/v2/customer/subscribe";
            public static readonly string validateVoucher = "device/v2/customer/validatevoucher";
        }
		public Account() { }


		/// <summary>
		/// Builds a user registration request and returns purchase options.
		/// </summary>
		/// <returns></returns>
		public static Request RegisterForCheckout(RMGKit.Models.Account.UserAuthenticationRequest param)
		{
            var parameters=new Dictionary<string, Object>();
            if (param != null)      
            {
                parameters.Add("jsonbody", param);
            }
			return new Request(Endpoints.registerForCheckout, $"", parameters, System.Net.Http.HttpMethod.Post);
		}
        /// <summary>
        /// Builds a user login request and does not return purchase options.
        /// </summary>
        /// <returns></returns>
        public static Request Authenticate(RMGKit.Models.Account.UserAuthenticationRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.authenticate, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>
        /// Builds a user login request and returns purchase options.
        /// </summary>
        /// <returns></returns>
        public static Request AuthenticateForCheckout(RMGKit.Models.Account.UserAuthenticationRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.authenticateForCheckout, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>
        /// Validates a voucher code, pass through call.
        /// </summary>
        /// <returns></returns>
        public static Request ValidateVoucher (RMGKit.Models.Account.VoucherRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.validateVoucher, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>
        /// Gets summary cc info attached to user account
        /// </summary>
        /// <returns></returns>
        public static Request GetPaymentInfo(RMGKit.Models.Account.VoucherRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.getPaymentInfo, $"", parameters, System.Net.Http.HttpMethod.Post);
        }

        
    }
}
