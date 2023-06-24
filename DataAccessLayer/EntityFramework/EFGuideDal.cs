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
    public class EFGuideDal : GenericRepository<Guide>, IGuideDal
    {
        private readonly Context _context;

        public EFGuideDal(Context context) : base(context)
        {
            _context = context;
        }

        public void ChangeToFalseByGuideId(int id)
        {
            Guide guide = _context.Guides.Find(id);

            guide.Status = false;
            _context.SaveChanges();
        }

        public void ChangeToTrueByGuideId(int id)
        {
            Guide guide = _context.Guides.Find(id);
            guide.Status = true;
            _context.SaveChanges();
        }
    }
}
