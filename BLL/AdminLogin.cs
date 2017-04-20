using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class AdminLogin
    {
        private ElectiveContext db = new ElectiveContext();
        /// <summary>
        /// 查找管理员登录的账号
        /// </summary>
        /// <param name="adminName">管理员账号</param>
        /// <param name="password">密码</param>
        /// <returns>返回管理员对象</returns>
        public SysAdmin CheckAdminLogin(string adminName, string password)
        {
            SysAdmin admin = db.SysAdmins.Where(u => u.AdminName == adminName && u.Password == password).FirstOrDefault();
           
            return admin;
        }
        /// <summary>
        /// 更新管理员登录时间
        /// </summary>
        /// <param name="admin">管理员对象</param>
        public void UpdateLoginTime(SysAdmin admin)
        {
            if (admin != null)
            {
                admin.LastLoginTime = DateTime.Now;
                db.Entry(admin).State = EntityState.Modified;
                db.SaveChanges();
            }           
        }
    }
}
