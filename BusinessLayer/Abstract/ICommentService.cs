using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        public List<Comment> TGetDestinationByID(int id);
        public List<Comment> TGetListCommentWithDestination();
    }
}
