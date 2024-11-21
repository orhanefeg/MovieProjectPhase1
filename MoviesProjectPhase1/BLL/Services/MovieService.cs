using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    using BLL.DAL;
    using Microsoft.EntityFrameworkCore;
    using YourNamespace;

    public interface IMovieService
    {
        Task<List<DAL.Movie>> GetAllMoviesAsync();
        Task<DAL.Movie?> GetMovieByIdAsync(int id);
        Task<DAL.Movie> AddMovieAsync(MovieDto movieDto);
        Task<bool> DeleteMovieAsync(int id);
    }

 

}
