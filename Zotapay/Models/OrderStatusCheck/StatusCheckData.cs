﻿namespace Zotapay.Models.OrderStatusCheck
{
    using System.Runtime.Serialization;
    using Zotapay.Contracts;

    public class StatusCheckData : IData
    {
        /// <summary>
        /// Transaction type, e.g.: SALE.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Transaction status, see https://doc.zotapay.com/deposit/1.0/#order-statuses for a full list of statuses.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string status { get; set; }

        /// <summary>
        /// Contains the error description if the transaction is declined or yields an error.
        /// </summary>
        [DataMember(Name = "errorMessage", EmitDefaultValue = false)]
        public string errorMessage { get; set; }

        /// <summary>
        /// The transaction identifier that was generated by the payment processor.
        /// </summary>
        [DataMember(Name = "processorTransactionID", EmitDefaultValue = false)]
        public string processorTransactionID { get; set; }

        /// <summary>
        /// Order unique identifier generated by Zotapay.
        /// </summary>
        [DataMember(Name = "orderID", EmitDefaultValue = false)]
        public string orderID { get; set; }

        /// <summary>
        /// Merchant-defined unique order identifier.
        /// </summary>
        [DataMember(Name = "merchantOrderID", EmitDefaultValue = false)]
        public string merchantOrderID { get; set; }

        /// <summary>
        /// The amount of the transaction.
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string amount { get; set; }

        /// <summary>
        /// The URL of the payment form, merchant should redirect the (waiting) end-user to this URL (HTTP 302).
        /// </summary>
        [DataMember(Name = "depositUrl", EmitDefaultValue = false)]
        public string DepositUrl { get; set; }

        /// <summary>
        /// The currency of the transaction.
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string currency { get; set; }

        /// <summary>
        /// End-user email address.
        /// </summary>
        [DataMember(Name = "customerEmail", EmitDefaultValue = false)]
        public string customerEmail { get; set; }

        /// <summary>
        /// Merchant-defined optional custom parameter.
        /// </summary>
        [DataMember(Name = "customParam", EmitDefaultValue = false)]
        public string customParam { get; set; }

        /// <summary>
        /// A Json object with a copy of the original Order Status Request sent by merchant server to Zotapay.
        /// </summary>
        [DataMember(Name = "request", EmitDefaultValue = false)]
        public object request { get; set; }

        /// <summary>
        /// Object with extra data regarding the order such as, payment method, dynamic currency conversion and others.
        /// </summary>
        [DataMember(Name = "extraData", EmitDefaultValue = false)]
        public object extraData { get; set; }
    }
}
