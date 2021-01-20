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
        [HttpGet]
        [Route("")]
        public IEnumerable<Vehicle> GetAll([FromServices] IVehicleRepository repository)
        {
            return repository.GetAll();
        }

        [HttpGet]
        [Route("{Id:int}")]
        public Vehicle GetById(int Id, [FromServices] IVehicleRepository repository)
        {
            return repository.GetById(Id);
        }

        [Route("")]
        [HttpPost]
        public GenericCommandResult Create(
            [FromBody]CreateVehicleCommand command,
            [FromServices]VehicleHandler handler
        )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("")]
        [HttpPut]
        public GenericCommandResult Update(
           [FromBody]UpdateVehicleCommand command,
           [FromServices]VehicleHandler handler
       )
        {
            return (GenericCommandResult)handler.Handle(command);
        }

        [Route("")]
        [HttpDelete]
        public GenericCommandResult Remove(
           [FromBody]UpdateVehicleCommand command,
           [FromServices]VehicleHandler handler
       )
        {
            return (GenericCommandResult)handler.Handle(command);
        }   
    }
}