﻿using System;
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
            public static readonly string registerWithVerify = "device/v2/customer/registerwithverify";
            public static readonly string verifyEmailAddress = "device/v2/customer/verifyemailaddress";
            public static readonly string resendVerificationEmail = "device/v2/customer/resendverificationemail";
            
            public static readonly string authenticateForCheckout = "device/v2/customer/authenticatecheckout";
            public static readonly string checkRegistration = "device/v2/customer/checkregistration";
            public static readonly string mailingListAdd = "device/v2/customer/MailingListAdd";
            public static readonly string authenticateForSummary = "device/v2/customer/authenticateForSummary";
            public static readonly string getEntitlement = "device/v2/customer/getUserEntitlements";
            public static readonly string authenticate = "device/v2/customer/authenticate";
            public static readonly string getPaymentInfo = "device/v2/customer/getpaymentinfo";
            public static readonly string subscribe = "device/v2/customer/subscribe";
            public static readonly string validateVoucher = "device/v2/customer/validatevoucher";
            public static readonly string recordView = "device/v2/customer/ViewHistoryAdd";
            public static readonly string recordInitialView = "device/v2/customer/ViewHistoryAddInitial";
            public static readonly string viewHistoryFetch = "device/v2/customer/viewHistoryFetch";
            public static readonly string followListFetch = "device/v2/customer/FollowListFetch";
            public static readonly string follow = "device/v2/customer/FollowListAdd";
            public static readonly string unfollow = "device/v2/customer/FollowListRemove";
            public static readonly string deleteHistoryItem = "device/v2/customer/ViewHistoryDelete";
            public static readonly string clearAllHistory = "device/v2/customer/ViewHistoryClear";
            public static readonly string updateProfile = "device/v2/customer/updateprofile";
            public static readonly string forgotPassword = "device/v2/customer/ForgotPassword";
            public static readonly string resetPassword = "device/v2/customer/ResetPassword";
            public static readonly string cancelRenewal = "device/v2/customer/cancelautorenew";
            public static readonly string offerAuthenticate = "device/v2/customer/authvouchertoken";
            public static readonly string offerapply= "device/v2/customer/authvouchertokenapply";
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
        public static Request RegisterWithVerify(RMGKit.Models.Account.UserAuthenticationRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.registerWithVerify, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>
        /// Builds a subscribe request.
        /// </summary>
        /// <returns></returns>
        public static Request Subscribe(RMGKit.Models.Account.SubscribeRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.subscribe, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>
        /// Builds a subscribe request.
        /// </summary>
        /// <returns></returns>
        public static Request AddToMailingList(RMGKit.Models.Account.MailingListRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.mailingListAdd, $"", parameters, System.Net.Http.HttpMethod.Post);
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
        /// Queues a new email verification send request
        /// </summary>
        /// <returns></returns>
        public static Request ResendVerificationEmail(RMGKit.Models.Account.UserAuthenticationRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.resendVerificationEmail, $"", parameters, System.Net.Http.HttpMethod.Post);
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
        /// checks if email is already registered.
        /// </summary>
        /// <returns></returns>
        public static Request CheckRegistration(RMGKit.Models.Account.UserAuthenticationRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.checkRegistration, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        


        /// <summary>
        /// Builds a user login request and returns purchase options.
        /// </summary>
        /// <returns></returns>
        public static Request ResetPassword(RMGKit.Models.Account.UserAuthenticationRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.resetPassword, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>
        /// Builds a user login request and returns purchase options.
        /// </summary>
        /// <returns></returns>
        public static Request LostPassword(RMGKit.Models.Account.IdentityRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.forgotPassword, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>
        /// Builds a user login request and returns purchase options.
        /// </summary>
        /// <returns></returns>
        public static Request AuthenticateForSummary(RMGKit.Models.Account.UserAuthenticationRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.authenticateForSummary, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        public static Request AuthenticateOffer(string param)
        {
            return new Request(Endpoints.offerAuthenticate, "?token=" + param, null, System.Net.Http.HttpMethod.Get);
        }
        public static Request ApplyPromoOffer(string param)
        {
            return new Request(Endpoints.offerapply, "?token=" + param, null, System.Net.Http.HttpMethod.Get);
        }
        /// <summary>
        /// Validates a voucher code, pass through call.
        /// </summary>
        /// <returns></returns>
        public static Request VerifyEmailAddress(RMGKit.Models.Account.EmailVerificationRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.verifyEmailAddress, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>
        /// Validates a voucher code, pass through call.
        /// </summary>
        /// <returns></returns>
        public static Request ValidateVoucher(RMGKit.Models.Account.VoucherRequest param)
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
        /// <summary>EW
        /// Builds a get media categories request.
        /// </summary>
        /// <returns></returns>
        public static Request RecordInitialView(RMGKit.Models.Account.RecordViewRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.recordInitialView, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>EW
        /// Builds a get media categories request.
        /// </summary>
        /// <returns></returns>
        public static Request CancelRenewal(RMGKit.Models.Account.CancelRenewRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.cancelRenewal, $"", parameters, System.Net.Http.HttpMethod.Post);
        }

        /// <summary>EW
        /// Builds a get media categories request.
        /// </summary>
        /// <returns></returns>
        public static Request RecordView(RMGKit.Models.Account.RecordViewRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.recordView, $"", parameters, System.Net.Http.HttpMethod.Post);
        }

        /// <summary>EW
        /// Builds a request to pull back the users viewing history.
        /// </summary>
        /// <returns></returns>
        public static Request GetViewHistory(RMGKit.Models.Account.FollowListRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.viewHistoryFetch, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>EW
        /// Builds a request to pull back list of items user is following.
        /// </summary>
        /// <returns></returns>
        public static Request GetFollowList(RMGKit.Models.Account.FollowListRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.followListFetch, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        public static Request Follow(RMGKit.Models.Account.FollowListRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.follow, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        public static Request Unfollow(RMGKit.Models.Account.FollowListRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.unfollow , $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        public static Request DeleteHistoryItem(RMGKit.Models.Account.FollowListRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.deleteHistoryItem, $"", parameters, System.Net.Http.HttpMethod.Post);
        }

        public static Request ClearAllHistory(RMGKit.Models.Account.IdentityRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.clearAllHistory, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        public static Request GetEntitlements(RMGKit.Models.Account.IdentityRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.getEntitlement, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
        /// <summary>
        /// Builds a user profile update request and returns a new token (in case password was changed).
        /// </summary>
        /// <returns></returns>
        public static Request UpdateProfile(RMGKit.Models.Account.UserAuthenticationRequest param)
        {
            var parameters = new Dictionary<string, Object>();
            if (param != null)
            {
                parameters.Add("jsonbody", param);
            }
            return new Request(Endpoints.updateProfile, $"", parameters, System.Net.Http.HttpMethod.Post);
        }
    }
}
