﻿using MovieApi.Application.Features.CQRSDesignPattern.Command.CategoryCommands;
using MovieApi.Application.Features.CQRSDesignPattern.Command.MovieCommands;
using MovieApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieApi.Application.Features.CQRSDesignPattern.Handlers.MovieHandlers
{
    public class UpdateMovieCommandHandler
    {
        private readonly MovieContext _context;

        public UpdateMovieCommandHandler(MovieContext context)
        {
            _context = context;
        }

        public async Task Handle(UpdateMovieCommand command)
        {
            var value = await _context.Movies.FindAsync(command.MovieId);
            value.Rating = command.Rating;
            value.Duration = command.Duration;
            value.Description = command.Description;
            value.ReleaseDate = command.ReleaseDate;
            value.Title = command.Title;
            value.Status = command.Status;
            value.CreatedYear = command.CreatedYear;
            value.CoverImageUrl = command.CoverImageUrl;
            await _context.SaveChangesAsync();
        }
    }
}
