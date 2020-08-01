using System;

namespace dotNetWrittingCorrectly
{
    class Program 
    {
        static void Main(string[] args)
        {
            //// -------------------------------------- exception handling
            Console.WriteLine("Hello World!");

            var customer = (bool?)null;
            var num = (int?)null;
            var myStopWatch = (TimeSpan?)null;
            var myMeeting = (DateTime?)null;
            var Elapsed = (TimeSpan?)null;
            var myDuoble = (Decimal?)null;
            var myOtherDouble = (Decimal?)null;

            DateTime myMeeting;

           // throw new ArgumentNullException(nameof(customer), "Customer cannot be null");

            try {
                customer = null;
            } catch(InvalidOperationException ex)
            {
                if(ex.Message.StartsWith("customer cannot be null"))
                {
                    //some specific logic goes here
                } 
                else
                {
                    //another handler or rethrow
                    throw;
                }
            }

            //// -------------------------------------- working with immutable types
            /* Some types, like DateTime are said to be immutable, in that you can create one, but you cannot change it after creation */
            myMeeting.Date = myMeeting.Date.Adddays(1);

            TimeSpan result = myStopWatch.Elapsed;
            Console.WriteLine("The operation took " + result.TotalMilliseconds + " ms");

            //// -------------------------------------- double comparison
            bool areQual = Math.Abs(myDuoble - myOtherDouble) < Double.Epsilon;




        }
    }
}
