using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MovieApi.Application.Features.MediatorDesignPattern.Commands.TagCommands;
using MovieApi.Application.Features.MediatorDesignPattern.Queries.TagQueries;
using System.Threading.Tasks;

namespace MovieApi.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        public readonly IMediator _mediator;

        public TagsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> TagList()
        {
            var value = await _mediator.Send(new GetTagQuery());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(CreateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Added Successfully.");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _mediator.Send(new RemoveTagCommand(id));
            return Ok("Deleted Successfully.");
        }

        [HttpGet("GetTagById")]
        public async Task<IActionResult> Get(int id)
        {
            var value = await _mediator.Send(new GetTagByIdQuery(id));
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateTagCommand command)
        {
            await _mediator.Send(command);
            return Ok("Updated Succesfully.");
        }
    }
}
