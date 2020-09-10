using System;
using System.Collections.Generic;
using System.Text;

using Xunit;
using EmployeesApp.Validation;

namespace EmployeesApp.Tests.Validation
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

        [Fact]
        public void IsValid_AccountNumberFirstPartWrong_ReturnsFalse()
        {
            Assert.False(_validation.IsValid("1234-3454565676-23"));
        }

        [Theory]
        [InlineData("1234-3454565676-23")]
        [InlineData("12-3454565676-23")]
        [InlineData("123-456-0")]
        public void IsValid_AccountNumberFirstPartWrong_ReturnsFalseTheory(string accontNumber)
        {
            Assert.False(_validation.IsValid(accontNumber));
        }

        [Theory]
        [InlineData("123-345456567-23")]
        [InlineData("123-345456567633-23")]
        public void IsValid_AccountNumberMiddlePartWrong_ReturnsFalsE(string accNumber)
        {
            Assert.False(_validation.IsValid(accNumber));
        }

        [Theory]
        [InlineData("123-4545-2")]
        [InlineData("123-555-988")]
        public void IsValid_AccountNumberLastPartWrong_ReturnsFalse(string accNumber)
        {
            Assert.False(_validation.IsValid(accNumber));
        }

        [Theory]
        [InlineData("123-454665=23")]
        [InlineData("123+555-23")]
        [InlineData("129+355464566=23")]
        public void IsValid_InvalidDelimeters_ThrowsArgumentException(string accNumber)
        {
            Assert.Throws<ArgumentException>(() => _validation.IsValid(accNumber));
        }
    }
}

