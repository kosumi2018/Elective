using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 管理员
    /// </summary>
    public class SysAdmin
    {
        public int SysAdminId { get; set; }

        [DisplayName("管理员账户")]
        public string AdminName { get; set; }

        [DisplayName("密码")]
        public string Password { get; set; }

        [DisplayName("最新登录时间")]
        public DateTime LastLoginTime { get; set; }
    }
}
