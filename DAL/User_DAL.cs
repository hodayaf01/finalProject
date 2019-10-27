using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class User_DAL
    {
        MediDBEntitie _DB = new MediDBEntitie();

        public User Get()
        {
            var res = _DB.Users.ToList().FirstOrDefault();
            res = res == null ? new User() : res;
            return res;
        }

        public void Add(User details)
        {
            _DB.Users.Add(details);
            _DB.SaveChanges();
        }

        public void Edit(User details)
        {
            _DB.Entry(details);
            _DB.SaveChanges();
        }
    }
}
