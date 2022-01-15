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

namespace ManageDataBase2
{
    public partial class saveTable : Form
    {
        public string DbName { get; set; }
        public string SqlStr { get; set; }
        public saveTable()
        {
            InitializeComponent();
        }
        public string ConnectionString = "Integrated Security=SSPI;Initial Catalog=MyDatabase;Data Source=DESKTOP-UM903E3;";
        public SqlDataReader reader = null;
        public SqlConnection conn = null;
        public SqlCommand cmd = null;
        public string sql = null;
        private void btnCreateTable_Click(object sender, EventArgs e) 
        {
            string tblName = txtDbName.Text;
            ConnectionString = "Integrated Security=SSPI;" +
            "Initial Catalog=" + DbName + ";" +
            "Data Source=DESKTOP-UM903E3;";
            var conn = new System.Data.SqlClient.SqlConnection("Server=DESKTOP-UM903E3;Initial Catalog=" + DbName + ";Integrated security=SSPI;");
            conn.ConnectionString = ConnectionString;
            conn.Open();
            sql = "If not exists (select name from sysobjects where name = @tblName) CREATE TABLE @tblName" +
            "(" + SqlStr + ")";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@tblName", tblName);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Success");
               this.Close();
            }
            catch (SqlException ae)
            {
                MessageBox.Show(ae.Message.ToString());
            }
        }
      
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
