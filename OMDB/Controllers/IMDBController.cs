using Microsoft.AspNetCore.Mvc;
using IMDB.Models;

namespace IMDB.Controllers
{
    public class IMDBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> MovieSearch()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MovieSearch(SearchMovie movie)
        {
            IMDBResponse response = await SearchMovie(movie.SearchTerm);
            return RedirectToAction("SearchMovieSingle", response);
        }

        public async Task<IActionResult> SearchMovieSingle(IMDBResponse movieResponse)
        {
            return View(movieResponse);
        }

        public async Task<IActionResult> MovieNight()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> MovieNight(TripleSearch movie1, TripleSearch movie2, TripleSearch movie3)
        {
            IMDBResponse response1 = await SearchMovie(movie1.SearchTerm1);
            IMDBResponse response2 = await SearchMovie(movie2.SearchTerm2);
            IMDBResponse response3 = await SearchMovie(movie3.SearchTerm3);
            List<IMDBResponse> responseList = new List<IMDBResponse>();
            responseList.Add(response1);
            responseList.Add(response2);
            responseList.Add(response3);
            
            return RedirectToAction("SearchMovieTriple", responseList);
        }

        public async Task<IActionResult> SearchMovieTriple(IMDBResponseList movieResponseList)
        {
            return View(movieResponseList);
        }

        public async Task<IMDBResponse> SearchMovie(string searchTerm) // call this 3 times for 3 movies
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("http://www.omdbapi.com");

            // client.DefaultRequestHeaders.Add("ApiKey", "5785a2a5");

            var response = await client.GetFromJsonAsync<IMDBResponse>("?t=" + searchTerm + "&apiKey=5785a2a5");

            return response;
        }
    }
}
