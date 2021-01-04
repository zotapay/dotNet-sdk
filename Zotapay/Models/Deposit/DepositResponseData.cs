﻿namespace Zotapay.Models
{
    using System.Runtime.Serialization;
    using Zotapay.Contracts;

    /// <summary>
    /// Zotapay data response parameter class
    /// </summary>
    public class DepositResponseData : IData
    {
        /// <summary>
        /// The URL of the payment form, merchant should redirect the (waiting) end-user to this URL (HTTP 302).
        /// </summary>
        [DataMember(Name = "depositUrl", EmitDefaultValue = false)]
        public string DepositUrl { get; set; }

        /// <summary>
        /// Merchants' order unique identifier, provided in the original Deposit Request.
        /// </summary>
        [DataMember(Name = "merchantOrderID", EmitDefaultValue = false)]
        public string MerchantOrderID { get; set; }

        /// <summary>
        /// Order unique identifier generated by Zotapay, should be then used for Order Status Requests.
        /// </summary>
        [DataMember(Name = "orderID", EmitDefaultValue = false)]
        public string OrderID { get; set; }
    }
}