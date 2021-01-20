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
        [HttpGet]
        [Route("")]
        public IEnumerable<Category> GetAll([FromServices] ICategoryRepository repository)
        {
            return repository.GetAll();
        }

        [HttpGet]
        [Route("{Id:int}")]
        public Category GetById(int Id, [FromServices] ICategoryRepository repository)
        {
            return repository.GetById(Id);
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody]CreateCategoryCommand command,
            [FromServices]CategoryHandler handler
        )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("")]
        [HttpPut]
        public GenericCommandResult Update(
           [FromBody]UpdateCategoryCommand command,
           [FromServices]CategoryHandler handler
       )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("")]
        [HttpDelete]
        public GenericCommandResult Remove(
           [FromBody]UpdateCategoryCommand command,
           [FromServices]CategoryHandler handler
       )
        {
            return (GenericCommandResult)handler.Handle(command);
        }
        
    }
}