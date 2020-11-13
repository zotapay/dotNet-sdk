﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using ZotapaySDK.Contracts;

namespace ZotapaySDK.Models.OrderStatusCheck
{
    public class MGQueryTxnResult : IMGResult
    {
        /// <summary>
        /// A status code representing the acceptance of the request by Zotapay server.
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// When code is other than 200, this parameter may hold information about the reason / error.
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// When code is 200, this parameter will include the response data. Please see the class summary for a full list of parameters.
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public StatusCheckData Data { get; set; }

        /// <summary>
        /// Indicates wether the request object was valid and an actual http request was send
        /// </summary>
        public bool IsSuccess { get; set; }
        IData IMGResult.Data { get { return Data; } set { } }
    }
}
