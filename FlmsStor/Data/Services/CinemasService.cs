using FlmsStor.Data.Base;
using FlmsStor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlmsStor.Data.Services
{
    public class CinemasService :EntityBaseRepository<Cinema>, ICinemasService
    {
        public CinemasService(AppDbContext context):base(context){}
    }
}
