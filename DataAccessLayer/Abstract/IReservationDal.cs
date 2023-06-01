using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationsByWaitApproval(int id);
        List<Reservation> GetListWithReservationsByApproved(int id);
        List<Reservation> GetListOldReservations(int id);
    }
}
