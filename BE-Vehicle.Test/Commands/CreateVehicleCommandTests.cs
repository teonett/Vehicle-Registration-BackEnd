using System;
using BE_Vehicle.Domain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BE_Vehicle.Test.Commands
{
    [TestClass]
    public class CreateVehicleCommandTests
    {
        [TestMethod]
        public void  WhenTryIncludeNewCategoryInvalid()
        {
            var command = new CreateVehicleCommand();
            command.Description = "";
            command.Validate();

            Assert.AreEqual(command.Valid, false);
        }

        [TestMethod]
        public void  WhenTryIncludeNewCategoryValid()
        {
            var command = new CreateVehicleCommand();
            command.Description = "ZZZZ";
            command.Validate();

            Assert.AreEqual(command.Valid, true);
        }
    }
}