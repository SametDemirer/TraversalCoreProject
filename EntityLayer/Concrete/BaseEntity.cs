using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool Status { get; set; } = true;
    }
}
