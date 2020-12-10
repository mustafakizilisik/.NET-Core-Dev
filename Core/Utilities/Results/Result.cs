using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        //this(success) bu kod ile tek parametreli successi set eder
        //Scope içerisindeki şekilde de kullanılabilir, kod tekrarı olmaz. 
        public Result(bool success, string message):this(success)
        {
            Message = message;
            //Success = success
        }
        public Result (bool success)
        {
            Success = success;
        }
        public bool Success { get; }
        public string Message { get; }
    }
}
