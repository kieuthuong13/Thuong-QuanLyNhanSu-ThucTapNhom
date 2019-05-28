using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public static class FillTo
    {
        private static SqlConnection connnect = GUI.SQLServer.GetMySQL();
        private static SqlDataAdapter adapter;
        public static bool DataGridViews(string _NameTable, ref DataGridView _NameDataGridView)
        {
            try
            {
                adapter = new SqlDataAdapter(@"select * from " + _NameTable,connnect);
                DataSet ds = new DataSet();
                adapter.Fill(ds, _NameTable);

                _NameDataGridView.DataSource = ds;
                _NameDataGridView.DataMember = _NameTable;
                return true;
            }
            catch
            {
                MessageBox.Show("Can not fill to data grid view");
                return false;
            }
        }
    }
}
