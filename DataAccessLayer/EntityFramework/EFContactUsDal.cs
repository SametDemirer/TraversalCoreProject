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
    public class EFContactUsDal : GenericRepository<ContactUs>, IContactUsDal
    {
        private readonly Context _context;
        public EFContactUsDal(Context context) : base(context)
        {
            _context = context;
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            ContactUs value = _context.ContactUses.Find(id);
            value.Status = false;
            _context.SaveChanges();
        }

        public List<ContactUs> GetListByFalse()
        {
            var values = _context.ContactUses.Where(x => x.Status == false).ToList();

            return values;
        }

        public List<ContactUs> GetListByTrue()
        {
            var values = _context.ContactUses.Where(x => x.Status == true).ToList();

            return values;
        }
    }
}
