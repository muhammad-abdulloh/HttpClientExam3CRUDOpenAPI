using HttpClientExam3.Models;
using HttpClientExam3.Service;
using System;
using System.Net.Http;
using System.Threading.Tasks;

#pragma warning disable
namespace HttpClientExam3
{
    internal class Program
    {
        private static IMovieService _movieService = new MovieService();
        static async Task Main(string[] args)
        {


            /** Get All Done
            var movies = await _movieService.GetAllAsync();
            foreach (var item in movies)
            {
                Console.WriteLine(item.Title + " - " + item.Author.FirstName);
            }
            */
            
            /** Get Done
            var response = _movieService.GetAsync(60).Result;
            Console.WriteLine(response.Title);
            */

            /** Delete Done
            var result = await _movieService.DeleteAsync(1);
            Console.WriteLine(result);
            */

            /** Create done
            Console.WriteLine("Posting ... ");

            var movie = await _movieService.CreateAsync(
                new Movie
                {
                    Title = "Update Update update",
                    Description = "Binarafsefsefslar ",
                    Image = "BUyefsfsfrda images",
                    Author = new Author
                    {
                        FirstName = "Muhammad Abdulloh",
                        LastName = "Komilov"
                    }
                });
            Console.WriteLine("Downloading ... ");
            */

            /** Update Done
            Movie movie = new Movie
            {
                Title = "Exam update",
                Description = "Binaraslar ",
                Image = "BUyerda images",
                Author = new Author
                {
                    FirstName = "Muhammad Abdulloh",
                    LastName = "Komilov"
                }
            };

            var update = await _movieService.UpdateAsync(31, movie);
            Console.WriteLine(update.Author.FirstName);
            */


        }
    }
}

#pragma warning restore
