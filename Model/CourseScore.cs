using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Model
{
    /// <summary>
    /// 课程成绩
    /// </summary>
    public class CourseScore
    {
        [DisplayName("学期")]
        public string Semester { get; set; }
        [DisplayName("课程性质")]
        public string Nature { get; set; }
        [DisplayName("课程名称")]
        public string CourseName { get; set; }
        [DisplayName("学生姓名")]
        public string StudentName { get; set; }
        [DisplayName("学号")]
        public string StudentNum { get; set; }
        [DisplayName("院系")]
        public string Department { get; set; }
        [DisplayName("专业")]
        public string Specialty { get; set; }
        [DisplayName("班级")]
        public string StudentClass { get; set; }
        [DisplayName("综合成绩")]
        public int Score { get; set; }

    }
}
