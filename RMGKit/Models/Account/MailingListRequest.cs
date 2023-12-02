using System;
using System.Collections.Generic;
using System.Text;

namespace RMGKit.Models.Account
{
    public class MailingListRequest
    {
        public MailingListRequest()
        {
            this.Email = String.Empty;
            this.Campaign = 0;
        }
        #region Properties
        public string Email { get; set; }
        public Int32 Campaign { get; set; }
        #endregion
    }
}
