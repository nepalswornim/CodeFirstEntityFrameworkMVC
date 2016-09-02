using BusinessLogicLayer.Entity;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
   public class BLLUser
    {
       IIMSDBContext _db = new IIMSDBContext();

        public void CreateUser(UserDetails ud)
        {

            tbl_User te = new tbl_User();
            te.Name = ud.Name;
            te.Gender = ud.Gender;
            te.Username = ud.Username;
            te.Password = ud.Password;

            _db.tbl_Users.Add(te);
            _db.SaveChanges();



        }
        public void EditUSer(UserDetails ud)
        {
            tbl_User te = (_db.tbl_Users.Single(u => u.UserId == ud.UserId));
            te.Name = ud.Name;
            te.Gender = ud.Gender;
            te.Username = ud.Username;
            te.Password = ud.Password;

            _db.SaveChanges();


        }
        public void DeletUser(int UserId)
        {

            tbl_User te = _db.tbl_Users.Single(u => u.UserId == UserId);
            _db.tbl_Users.Remove(te);
            _db.SaveChanges();



        }
        public List<UserDetails> GetallUser()
        {
            List<UserDetails> lstUser = new List<UserDetails>();
            var users = from u in _db.tbl_Users select u;

            foreach (tbl_User user in users)
            {
                UserDetails ud = new UserDetails();
                ud.UserId = user.UserId;
                ud.Name = user.Name;
                ud.Gender = user.Gender;
                ud.Username = user.Username;
                ud.Password = user.Password;

                lstUser.Add(ud);
            }
            return lstUser;




        }
    }
}
