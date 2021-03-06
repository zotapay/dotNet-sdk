﻿namespace Zotapay.Contracts
{
    public interface IMGResult
    {
        public string Code { get; set; }
        public string Message { get; set; }
        public IData Data { get; set; }
        public bool IsSuccess { get; set; }
    }

    public interface IData { }
}
