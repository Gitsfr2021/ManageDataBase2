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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BindCompo();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region CreateDB
        private void btnCreateDB_Click(object sender, EventArgs e)
        {
            SqlConnection myConn = new SqlConnection("Server=DESKTOP-UM903E3;Integrated security=SSPI;database=master");
            string dbName = txtDbName.Text.Trim();

            #region Check title DataBase
            string checkDb = Function.IsTextAllowed(txtDbName.Text);
            if (Function.IsTextAllowed(txtDbName.Text) != "")
            {
                MessageBox.Show(checkDb);
                return;
            }
            #endregion
       
            #region Check Exist
            using (var command = new SqlCommand($"SELECT db_id('{dbName}')", myConn))
            {
                myConn.Open();
                if (command.ExecuteScalar() != DBNull.Value)
                {
                    MessageBox.Show("There is a database with this name ");
                    return;
                }
            }
            #endregion

            #region Create Database
            String str = "CREATE DATABASE " + dbName + " ON PRIMARY " +
             "(NAME = MyDatabase1_Data, " +
             "FILENAME = 'C:\\Program Files\\Microsoft SQL Server\\MSSQL14.MSSQLSERVER\\MSSQL\\DATA\\" + dbName + ".mdf', " +
             "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%)" +
             "LOG ON (NAME = MyDatabase1_Log, " +
             "FILENAME = 'C:\\Program Files\\Microsoft SQL Server\\MSSQL14.MSSQLSERVER\\MSSQL\\DATA\\" + dbName + ".ldf', " +
             "SIZE = 1MB, " +
             "MAXSIZE = 5MB, " +
             "FILEGROWTH = 10%)";

            SqlCommand myCommand = new SqlCommand(str, myConn);
            try
            {
                myConn.Open();
                myCommand.ExecuteNonQuery();
                //چک کن اگر دیتابیس وجود داره خطا بده
                MessageBox.Show("DataBase is Created Successfully", "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
            #endregion
        }
        #endregion

        #region CreateTable
        public string ConnectionString = "Integrated Security=SSPI;Initial Catalog=MyDatabase;Data Source=DESKTOP-UM903E3;";
        public SqlDataReader reader = null;
        public SqlConnection conn = null;
        public SqlCommand cmd = null;
        public string sql = null;
        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            string sql = "";
            for (int i = 0; i < grdTable.RowCount-1; i++)
            {
                string allow = (Convert.ToBoolean(grdTable.Rows[i].Cells[2].Value) ? " Not NULL" : "  NULL");
                sql += grdTable.Rows[i].Cells[0].Value.ToString()+" "+ grdTable.Rows[i].Cells[1].Value.ToString()+" "+ allow+",";
            }
            if (sql == "")
            {
                MessageBox.Show("Please enter table fields ");
                return;
            }
            var saveTable = new saveTable();
            saveTable.DbName = cmbDB.Text;
            saveTable.SqlStr = sql.Substring(0,sql.Length-1);
            saveTable.Show();

        }
        #endregion

        #region BindListDB
        public void BindCompo()
        {
            using (var connection = new System.Data.SqlClient.SqlConnection("Server=DESKTOP-UM903E3;Integrated security=SSPI;"))
            {
                connection.Open();
                var command = new System.Data.SqlClient.SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;
                command.CommandText = "SELECT name FROM master.sys.databases";

                var adapter = new System.Data.SqlClient.SqlDataAdapter(command);
                var dataset = new DataSet();
                adapter.Fill(dataset);
                DataTable dtDatabases = dataset.Tables[0];

                cmbDB.DataSource = dtDatabases;
                cmbDB.DisplayMember = "name";
                cmbDB.SelectedText = "name";
            }
        }
        #endregion

    }
}
