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
        Task<IEnumerable<Movie>> GetAllAsync();

        Task<Movie> GetAsync(long id);

        Task<Movie> CreateAsync(Movie movie);

        Task<Movie> UpdateAsync(long id, Movie movie);

        Task<Movie> UpdatePatchAsync(long movieId, long authorId);

        Task<bool> DeleteAsync(long id);
    }
}
