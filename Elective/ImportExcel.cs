using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Elective
{
    public partial class ImportExcel : Form
    {
        public ImportExcel()
        {
            InitializeComponent();
        }
        public ImportExcel(SysAdmin admin)
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "导入Excel表格";
            ofd.Filter = "2007Excel(*.xlsx)|*.xlsx|2003Excel(*.xls)|*.xls";
            
            if(ofd.ShowDialog()== DialogResult.OK)
            {
                lblFilePath.Text = ofd.FileName;
                try
                {
                    this.dgvScore.DataSource = ImportData.getScoreList(ofd.FileName);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message,"发生错误，错误提示：");
                }
                
            }
            
            //
        }
    }
}
