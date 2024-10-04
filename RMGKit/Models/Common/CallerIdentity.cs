using System;
using System.Collections.Generic;
using System.Text;

namespace RMGKit.Models.Common
{
    public class CallerIdentity
    {
        public CallerIdentity()
        {
        }
        #region Properties

        public string UserName { get; set; } = "";

        public string UserToken { get; set; } = "";

        public string DeviceToken { get; set; } = "";
        public string IPAddress { get; set; } = "";
        public string Country { get; set; } = "";
        public string TagDate { get; set; } = "";

        #endregion

    }
}
