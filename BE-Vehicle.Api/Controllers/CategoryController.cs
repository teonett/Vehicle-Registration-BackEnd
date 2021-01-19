using System.Collections.Generic;
using BE_Vehicle.Domain.Commands;
using BE_Vehicle.Domain.Entities;
using BE_Vehicle.Domain.Handlers;
using BE_Vehicle.Domain.Repositories;
using BE_Vehicle.Infra.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BE_Vehicle.Api.Controllers
{
    [ApiController]
    [Route("v1/categoty")]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository repository;

        public CategoryController(CategoryRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public ActionResult<List<Category>> Get()
        {
            return repository.GetAll();
        }

         [HttpGet]
         [Route("{Id:int}")]
        public ActionResult<List<Category>> Get(int Id)
        {
            return repository.GetAll();
        }

        [HttpPost]
        public GenericCommandResult Create(
            [FromBody] CreateCategoryCommand command,
            [FromServices] CategoryHandler handler
        )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [HttpPut]
        public ActionResult Update([FromBody] Category category)
        {
            repository.Update(category);
            return Ok("Updated");
        }

        [HttpDelete]
        public ActionResult Remove(Category category)
        {
            repository.Remove(category);
            return Ok("Deleted");
        }
    }
}