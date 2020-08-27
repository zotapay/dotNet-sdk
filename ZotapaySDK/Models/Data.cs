﻿namespace ZotapaySDK.Models
{
    using System.Runtime.Serialization;

    /// <summary>
    /// Zotapay data response parameter class
    /// </summary>
    public class Data
    {
        /// <summary>
        /// The URL of the payment form, merchant should redirect the (waiting) end-user to this URL (HTTP 302).
        /// </summary>
        [DataMember(Name = "depositUrl", EmitDefaultValue = false)]
        public string DepositUrl { get; internal set; }

        /// <summary>
        /// Merchants' order unique identifier, provided in the original Deposit Request.
        /// </summary>
        [DataMember(Name = "merchantOrderID", EmitDefaultValue = false)]
        public string MerchantOrderID { get; internal set; }

        /// <summary>
        /// Order unique identifier generated by Zotapay, should be then used for Order Status Requests.
        /// </summary>
        [DataMember(Name = "orderID", EmitDefaultValue = false)]
        public string OrderID { get; internal set; }
    }
}
