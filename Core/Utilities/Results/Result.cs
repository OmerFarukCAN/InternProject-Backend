using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        public Result(bool success, string message) : this(success) // this class'in kendisi demektir. Buradaki amaç alttaki ctor'u otomatik olarak calistirmaktir.
        {
            // get' ler readonly dir fakat constructorda set edilebilir !!!! 
            Message = message;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
}
}
