using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{
    public class EFCommentDal : GenericRepository<Comment>, ICommentDal
    {
        private readonly Context _context;
        public EFCommentDal(Context context) : base(context)
        {
            _context = context;
        }

        public List<Comment> GetListCommentWithDestination()
        {
            return _context.Comments.Include(x => x.Destination).ToList();
        }
    }
}
