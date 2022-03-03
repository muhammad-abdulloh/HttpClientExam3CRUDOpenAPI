using HttpClientExam3.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientExam3.Service
{
    internal class MovieService : IMovieService
    {

        HttpClient _httpClient;

        /// <summary>
        /// Constructor Include
        /// </summary>
        public MovieService()
        {
            _httpClient = new HttpClient();
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        public async Task<Movie> CreateAsync(Movie movie)
        {
            HttpResponseMessage response = await _httpClient.PostAsJsonAsync<Movie>(Constants.MOVIE_POST, movie);

            string message = await response.Content.ReadAsStringAsync();

            return JsonConvert.DeserializeObject<Movie>(message);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<bool> DeleteAsync(long id)
        {
            var response = await _httpClient.DeleteAsync(Constants.MOVIE_DELETE + $"?id={id}");

            return response.IsSuccessStatusCode;
        }


        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Movie> GetAsync(long id)
        {
            
            HttpResponseMessage response = await _httpClient.GetAsync(Constants.MOVIE_GET + $"?id={id}");

            string content = await response.Content.ReadAsStringAsync();  

            return JsonConvert.DeserializeObject<Movie>(content);

        }

        /// <summary>
        /// Get All
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Movie>> GetAllAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync(Constants.MOVIE_GET_ALL);

            string content = await response.Content.ReadAsStringAsync();  

            return JsonConvert.DeserializeObject<IEnumerable<Movie>>(content);
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param id="id"></param>
        /// <param name="movie"></param>
        /// <returns></returns>
        public async Task<Movie> UpdateAsync(long id, Movie movie)
        {
            string url = Constants.MOVIE_UPDATE + $"?id={id}";

            string json = JsonConvert.SerializeObject(movie);

            HttpContent content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<Movie>(result);
            }

            return null;
        }


    }
}
