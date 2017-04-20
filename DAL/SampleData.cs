using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace DAL
{
    public class SampleData : DropCreateDatabaseAlways<ElectiveContext>
    {
        protected override void Seed(ElectiveContext context)
        {
            context.SysAdmins.Add(new SysAdmin { AdminName="admin", Password=MyTools.MD5Encrypt32("admin"), LastLoginTime=DateTime.Now });
            base.Seed(context);
        }
    }
}
