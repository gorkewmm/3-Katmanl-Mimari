using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {   //getter readonly'dir. Readonly'ler ctor'da set edilebilir.

        public Result(bool success, string message) : this(success) //bu ctor çalışmadan önce aşağıdaki ctor çalışıyor.
        {
            //Success = success;
            Message = message;
        }
        public Result(bool success) //Constructor overloading yaptık. 
        {
            Success = success;
        }

        public bool Success { get; }
        public string Message { get; }
    }
}
