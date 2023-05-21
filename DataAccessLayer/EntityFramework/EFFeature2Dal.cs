using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFFeature2Dal : GenericRepository<Feature2>, IFeature2Dal
    {
        private readonly Context _context;

        public EFFeature2Dal(Context context) : base(context)
        {
            _context = context;
        }
    }
}
