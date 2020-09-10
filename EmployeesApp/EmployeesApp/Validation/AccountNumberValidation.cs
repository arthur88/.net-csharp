using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeesApp.Validation
{
    public class AccountNumberValidation
    {
        private const int startingPartLength = 3;
        private const int middlePartLength = 10;
        private const int lastPartLength = 2;

        public bool IsValid(string accountNumber)
        {
            var firstDelimeter = accountNumber.IndexOf('-');
            var secondDelimter = accountNumber.LastIndexOf('-');

            if (firstDelimeter == -1 || (firstDelimeter == secondDelimter))
                throw new ArgumentException();

            var firstPart = accountNumber.Substring(0, firstDelimeter);
            if (firstPart.Length != startingPartLength)
                return false;

            var tempPart = accountNumber.Remove(0, startingPartLength + 1);
            var middlePart = tempPart.Substring(0, tempPart.IndexOf('-'));
            if (middlePart.Length != middlePartLength)
                return false;

            var lastPart = accountNumber.Substring(secondDelimter + 1);
            if (lastPart.Length != lastPartLength)
                return false;

            return true;
        }


    }
}
