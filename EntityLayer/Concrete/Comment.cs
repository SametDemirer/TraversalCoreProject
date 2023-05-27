using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment :BaseEntity
    {
        public string CommentUser { get; set; }
        public DateTime CommentDate { get; set; }
        public string CommentContent { get; set; }

        #region Relations
        public int DestinationId { get; set; }
        public Destination Destination { get; set; }
        #endregion
    }
}
