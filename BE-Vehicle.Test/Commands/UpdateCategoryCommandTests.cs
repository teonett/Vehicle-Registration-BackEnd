using BE_Vehicle.Domain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BE_Vehicle.Test.Commands
{
    [TestClass]
    public class UpdateCategoryCommandTests
    {
        [TestMethod]
        public void  WhenTryUpdateExistingCategoryInvalid()
        {
            var command = new UpdateCategoryCommand();
            command.Description = "";
            command.Validate();

            Assert.AreEqual(command.Valid, false);
        }

        [TestMethod]
        public void  WhenTryUpdateExistingCategoryValid()
        {
            var command = new UpdateCategoryCommand();
            command.Description = "ZZZZ";
            command.Validate();

            Assert.AreEqual(command.Valid, true);
        }
    }
}