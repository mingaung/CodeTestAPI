using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Paylocity_API.Utility
{
    public class GenericActionResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public dynamic Data { get; set; }
        private GenericActionResult(bool isSuccess, string message, dynamic data)
        {
            IsSuccess = isSuccess;
            Message = message;
            Data = data;
        }

        public static GenericActionResult Success(string message, dynamic data) 
        {
            return new GenericActionResult(true, message, data);
        }

        public static GenericActionResult Failure(string message, dynamic data)
        {
            return new GenericActionResult(false, message, data);
        }
    }
}
