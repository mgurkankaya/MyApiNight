using MyApiNight.DataAccess.Abstract;
using MyApiNight.DataAccess.Context;
using MyApiNight.DataAccess.Repositories;
using MyApiNight.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNight.DataAccess.EntityFramework
{
    public class EfCategoryDal : GenericRepositories<Category>, ICategoryDal
    {
        public EfCategoryDal(ApiContext context) : base(context)
        {
        }
    }
}
