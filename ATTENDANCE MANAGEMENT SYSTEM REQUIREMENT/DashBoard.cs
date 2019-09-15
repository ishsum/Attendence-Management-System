using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace ATTENDANCE_MANAGEMENT_SYSTEM_REQUIREMENT
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView4_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView3_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.ShowDialog();
            
        }

        private void DashBoard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mASDDataSet1.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter1.Fill(this.mASDDataSet1.Admin);
            // TODO: This line of code loads data into the 'mASDDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.mASDDataSet.Admin);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void adminpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
