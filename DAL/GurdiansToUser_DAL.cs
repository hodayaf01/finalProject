using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GurdiansToUser_DAL
    {
        MediDBEntitie _DB = new MediDBEntitie();

        public guardiansToUser Get()
        {
            var res = _DB.guardiansToUsers.ToList().FirstOrDefault();
            res = res == null ? new guardiansToUser() : res;
            return res;
        }

        public void Add(guardiansToUser details)
        {
            _DB.guardiansToUsers.Add(details);
            _DB.SaveChanges();
        }

        public void Edit(guardiansToUser details)
        {
            _DB.Entry(details);
            _DB.SaveChanges();
        }
        //public void Delete()
        //{
        //    _DB.guardiansToUsers.First().DeleteRow = false;
        //}
    }
}
