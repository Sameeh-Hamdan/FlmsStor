using FlmsStor.Data.Base;
using FlmsStor.Data.ViewModels;
using FlmsStor.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlmsStor.Data.Services
{
    public interface IMoviesService:IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownsValues();
        Task AddNewMovieAsync(NewMovieVM data);
        Task UpdateMovieAsync(NewMovieVM data);
    }
}
