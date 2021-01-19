using System;
using BE_Vehicle.Domain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BE_Vehicle.Test.Commands
{
    [TestClass]
    public class UpdateVehicleCommandTests
    {
        [TestMethod]
        public void  WhenTryUpdateExistingCategoryInvalid()
        {
            var command = new UpdateVehicleCommand("", 1900, 1900, Guid.NewGuid());
            command.Validate();

            Assert.AreEqual(command.Valid, false);
        }

        [TestMethod]
        public void  WhenTryUpdateExistingCategoryValid()
        {
            var command = new UpdateVehicleCommand("ZZZZ", DateTime.Now.Year, DateTime.Now.Year+1, Guid.NewGuid());
            command.Validate();

            Assert.AreEqual(command.Valid, true);
        }
    }
}