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
    public class EfProductDal : GenericRepositories<Product>, IProductDal
    {
        public EfProductDal(ApiContext context) : base(context)
        {
        }
    }
}