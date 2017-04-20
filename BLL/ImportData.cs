using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using Model;
using System.Data.Entity;
using DAL;

namespace BLL
{
    public class ImportData
    {
        /// <summary>
        /// 读取Excel文件中的数据
        /// </summary>
        /// <param name="fileallName">Excel文件全路径</param>
        /// <returns></returns>
        public static List<CourseScore> getScoreList(string fileallName)
        {
            var excelfile = new ExcelQueryFactory(fileallName);
            var tsheet = excelfile.Worksheet<CourseScore>(0).ToList(); 
            return tsheet;
        }

        public static int saveScoreListToDb(List<CourseScore> score)
        {
            ElectiveContext db = new ElectiveContext();
            foreach (var item in score)
            {
                if (!db.CourseScores.Exists(c => c.Equals(item)))
                {
                    db.CourseScores.Add(item);
                }                      
            }


            return 5;
        }
    }
}
