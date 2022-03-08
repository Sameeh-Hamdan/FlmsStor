using FlmsStor.Data.Base;
using FlmsStor.Models;

namespace FlmsStor.Data.Services
{
    public class ProducersService:EntityBaseRepository<Producer>,IProducersService
    {
        public ProducersService(AppDbContext context):base(context)
        {

        }
    }
}
