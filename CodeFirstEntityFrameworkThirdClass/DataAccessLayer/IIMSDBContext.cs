using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
   public class IIMSDBContext:DbContext
    {
        public DbSet<tbl_User> tbl_Users { get; set; }

    }
}
