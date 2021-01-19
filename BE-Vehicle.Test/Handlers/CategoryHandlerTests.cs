using System;
using BE_Vehicle.Domain.Commands;
using BE_Vehicle.Domain.Handlers;
using BE_Vehicle.Test.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BE_Vehicle.Test.Handlers
{
    [TestClass]
    public class CategoryHandlerTests
    {
        private GenericCommandResult _result = new GenericCommandResult();
        private readonly CreateCategoryCommand _invalidCommnad = new CreateCategoryCommand("");
        private readonly CreateCategoryCommand _validCommnad = new CreateCategoryCommand("ZZZ");
        private readonly CategoryHandler _handler = new CategoryHandler(new FakeCategoryRepository());

        [TestMethod]
        public void ShouldReturnErrorWhenTryInsertInvalidResgister()
        {
            _result = (GenericCommandResult)_handler.Handle(_invalidCommnad);
            Assert.AreEqual(_result.Success, false);
        }

         [TestMethod]
        public void ShouldReturnErrorWhenTryInsertValidResgister()
        {
            _result = (GenericCommandResult)_handler.Handle(_validCommnad);
            Assert.AreEqual(_result.Success, true);
        }
        
    }
}