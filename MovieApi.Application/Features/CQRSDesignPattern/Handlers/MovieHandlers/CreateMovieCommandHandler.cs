using MovieApi.Application.Features.CQRSDesignPattern.Command.MovieCommands;
using MovieApi.Domain.Entities;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class CreateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public CreateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(CreateMovieCommand command)
        {
            _context.Movies.Add(new Movie
            {
                Title = command.Title,
                CoverImageUrl = command.CoverImageUrl,
                ReleaseDate = command.ReleaseDate,
                CreatedYear = command.CreatedYear,
                Rating = command.Rating,
                Description = command.Description,
                Duration = command.Duration,
                Status = command.Status
            });
            await _context.SaveChangesAsync();
        }
    }
}
