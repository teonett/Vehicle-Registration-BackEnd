using BE_Vehicle.Domain.ValueObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BE_Vehicle.Test.Entities
{
    [TestClass]
    public class CategoryTests
    {
        private readonly Description _description;

        public CategoryTests()
        {
            _description = new Description("ZZZ");
        }
        
    }
}