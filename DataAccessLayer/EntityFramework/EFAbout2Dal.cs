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
    public class EFAbout2Dal : GenericRepository<About2>, IAbout2Dal
    {
        private readonly Context _context;

        public EFAbout2Dal(Context context) : base(context)
        {
            _context = context;
        }
    }
}
