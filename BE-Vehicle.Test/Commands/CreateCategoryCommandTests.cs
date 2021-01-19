using BE_Vehicle.Domain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BE_Vehicle.Test.Commands
{
    [TestClass]
    public class CreateCategoryCommandTests
    {
        [TestMethod]
        public void  WhenTryIncludeNewCategoryInvalid()
        {
            var command = new CreateCategoryCommand("");
            command.Validate();

            Assert.AreEqual(command.Valid, false);
        }

        [TestMethod]
        public void  WhenTryIncludeNewCategoryValid()
        {
            var command = new CreateCategoryCommand("ZZZ");
            command.Validate();

            Assert.AreEqual(command.Valid, true);
        }
    }
}