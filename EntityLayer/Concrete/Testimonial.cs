using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Testimonial : BaseEntity
    {

        public string Client { get; set; }
        public string Coment { get; set; }
        public string ClientImage { get; set; }

    }
}
