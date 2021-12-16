using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KyleDelacruzc969.classes;
using Xunit;

namespace App.Tests
{
    
    public class UnitTest
    {
        string phone = "253-732-7805D";

        [Fact]
        public void check_PhoneNumber()
        {
            bool expected = true;

            bool actual = Check.isNumber(phone);

            Assert.Equal(expected, actual);
        }
    }
}
