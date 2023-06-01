using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        private readonly Context _context;
        public EFReservationDal(Context context) : base(context)
        {
            _context = context;
        }
        public List<Reservation> GetListOldReservations(int id)
        {
            return _context.Reservations.Include(x => x.Destination).Where(x => x.AppUserId.Equals(id) && x.Status == "Geçmiş Rezervasyon").ToList();

        }

        public List<Reservation> GetListWithReservationsByApproved(int id)
        {
            return _context.Reservations.Include(x => x.Destination).Where(x => x.AppUserId.Equals(id) && x.Status == "Onaylandı").ToList();
        }

        public List<Reservation> GetListWithReservationsByWaitApproval(int id)
        {
            return _context.Reservations.Include(x => x.Destination).Where(x => x.AppUserId.Equals(id) && x.Status == "Onay Bekliyor").ToList();
        }
    }
}
