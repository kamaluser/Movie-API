using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.CastCommands;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.CastQueries;
using System.Threading.Tasks;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CastsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CastsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> CastList()
        {
            var value = await _mediator.Send(new GetCastQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Added Successfully.");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _mediator.Send(new RemoveCastCommand(id));
            return Ok("Deleted Successfully.");
        }

        [HttpGet("GetCastById")]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _mediator.Send(new GetCastByIdQuery(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateCastCommand command)
        {
            await _mediator.Send(command);
            return Ok("Updated Succesfully.");
        }
    }
}
