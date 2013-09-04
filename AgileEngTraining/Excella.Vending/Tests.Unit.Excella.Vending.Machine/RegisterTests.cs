using Excella.Vending.Machine;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Unit.Excella.Vending.Machine
{
    public class RegisterTests
    {
        [Test]
        public void ReleaseChange_WhenDemoing_ExpectAlwaysPassingTest()
        {
            // Arrange
            var register = new Register();

            // Act
            var actual = register.ReleaseChange();

            // Assert

            // Assert.Fail("The test failed at {0}", DateTime.Now.ToString());
            Assert.Pass("The test passed at {0}", DateTime.Now.ToString());
        }

        // ReleaseChange returns 0 when no money is inserted
        [Test]
        public void ReleaseChange_WhenNoMoneyIsInserted_Expect0()
        {
            // Arrange
            var register = new Register();

            // Act
            var actual = register.ReleaseChange();

            // Assert
            Assert.IsTrue(actual == 0);
        }
    }
}
