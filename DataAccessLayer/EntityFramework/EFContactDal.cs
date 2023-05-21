﻿using DataAccessLayer.Abstract;
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
    public class ContactDal : GenericRepository<Contact>, IContactDal
    {
        private readonly Context _context;

        public ContactDal(Context context) : base(context)
        {
            _context = context;
        }
    }
}
