using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationsByWaitApproval(int id);
        List<Reservation> GetListWithReservationsByApproved(int id);
        List<Reservation> GetListOldReservations(int id);
    }
}
