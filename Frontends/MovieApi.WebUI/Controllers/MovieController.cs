﻿using Microsoft.AspNetCore.Mvc;
using MovieApi.Dto.Dtos.MovieDtos;
using Newtonsoft.Json;

namespace MovieApi.WebUI.Controllers
{
    public class MovieController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public MovieController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> MovieList()
        {
            ViewBag.v1 = "Movie Listing - List";
            ViewBag.v2 = "Home";
            ViewBag.v3 = "Movie Listing";

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5207/api/Movies");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultMovieDto>>(jsonData);
                return View(values);
            }

            return View();
        }

        public async Task<IActionResult> MovieDetail(int id)
        {
            ViewBag.v1 = "Movie Listing - List";
            ViewBag.v2 = "Home";
            ViewBag.v3 = "Movie Listing";

            id = 0;
            return View();
        }
    }
}
