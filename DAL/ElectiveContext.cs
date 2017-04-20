using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Model;

namespace DAL
{
    public class ElectiveContext : DbContext
    {
        public List<SysAdmin> SysAdmins { get; set; }
        public List<CourseScore> CourseScores { get; set; }
    }
}
