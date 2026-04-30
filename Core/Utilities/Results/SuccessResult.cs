using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessResult : Result
    {//Base class'ta parametresiz constructor yoksa, alt sınıfta constructor yazmak ve üst sınıfı beslemek mecburidir.
        public SuccessResult(string message) : base(true,message) //Alt sınıfın constructor'ı çalıştığı anda ilk iş olarak base class'ın constructor'ını tetikler.
        {
            
        }

        public SuccessResult() : base(true)
        {
            
        }
    }
}
