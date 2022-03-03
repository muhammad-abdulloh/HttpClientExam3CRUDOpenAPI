using HttpClientExam3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientExam3.Service
{
    internal interface IMovieService
    {
        /// <summary>
        /// Get all
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Movie>> GetAllAsync();

        /// <summary>
        /// Get
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Movie> GetAsync(long id);

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="movie"></param>
        /// <returns></returns>
        Task<Movie> CreateAsync(Movie movie);

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="id"></param>
        /// <param name="movie"></param>
        /// <returns></returns>
        Task<Movie> UpdateAsync(long id, Movie movie);

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<bool> DeleteAsync(long id);

    }
}
