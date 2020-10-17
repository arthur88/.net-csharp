using System;
using System.Collections.Generic;
using System.Text;

using EmployeesApp.Validation;
using Xunit;

namespace EmployeesApp.Tests
{
    public class AccountNumberValidationTests
    {
        private readonly AccountNumberValidation _validation;

        public AccountNumberValidationTests()
        {
            _validation = new AccountNumberValidation();
        }

        [Fact]
        public void IsValid_ValidAccountNumber_ReturnsTrue()
        {
            Assert.True(_validation.IsValid("123-4543234576-23"));
        }

        [Theory]
        [InlineData("123-345456567-23")]
        [InlineData("123-345456567633-23")]
        public void IsValid_AccountNumberFirstPartWrong_ReturnsFalse(string accNumber)
        {
            Assert.False(_validation.IsValid(accNumber));
        }

        [Theory]
        [InlineData("1234-3454565676-23")]
        [InlineData("12-3454565676-23")]
        public void IsValid_AccountNumberFirstPartWrong_ReturnsFalseshould(string accountNumber)
        {
            Assert.False(_validation.IsValid(accountNumber));
        }

        [Theory]
        [InlineData("123-345456567633=23")]
        [InlineData("123+345456567633-23")]
        [InlineData("123+345456567633=23")]
        public void IsValid_InvalidDelimeters_ThrowsArgumentException(string accNumber)
        {
            Assert.Throws<ArgumentException>(() => _validation.IsValid(accNumber));
        }



    }
}
