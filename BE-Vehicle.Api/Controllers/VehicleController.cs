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
    [Route("v1/vehicle")]
    public class VehicleController : ControllerBase
    {
        private readonly IVehicleRepository repository;

        public VehicleController(VehicleRepository _repository)
        {
            repository = _repository;
        }

        [HttpGet]
        public ActionResult<List<Vehicle>> Get()
        {
            return repository.GetAll();
        }

         [HttpGet]
         [Route("{Id:int}")]
        public ActionResult<List<Vehicle>> Get(int Id)
        {
            return repository.GetAll();
        }

        [HttpPost]
        public GenericCommandResult Create(
            [FromBody] CreateVehicleCommand command,
            [FromServices] VehicleHandler handler
        )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [HttpPut]
        public ActionResult Update([FromBody] Vehicle Vehicle)
        {
            repository.Update(Vehicle);
            return Ok("Updated");
        }

        [HttpDelete]
        public ActionResult Remove(Vehicle Vehicle)
        {
            repository.Remove(Vehicle);
            return Ok("Deleted");
        }
    }
}