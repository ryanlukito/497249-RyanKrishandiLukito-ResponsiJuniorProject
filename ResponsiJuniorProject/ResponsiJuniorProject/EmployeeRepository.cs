using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiJuniorProject
{
    // Inheritance
    internal class EmployeeRepository : Employee
    {
        private string conn = "Host=localhost;Port=5432;Username=postgres;Password=informatika;Database=responsiRyan";
        private static NpgsqlConnection connection;
        private static NpgsqlCommand cmd;
        private static DataTable dt;

        private DataGridView dgvData;
        private DataGridViewRow row;
        public DataGridViewRow Row { set { row = value; } }

        public EmployeeRepository(DataGridView _dgvData) 
        {
            dgvData = _dgvData;
            connection = new NpgsqlConnection(conn);
        }

        public void Load()
        {
            try
            {
                connection.Open();
                dgvData.DataSource = null;
                dt = new DataTable();
                string sql = "select * from emp_select()";
                cmd = new NpgsqlCommand(sql, connection);
                NpgsqlDataReader rd = cmd.ExecuteReader();
                dt.Load(rd);
                dgvData.DataSource = dt;
                connection.Close();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            finally { connection.Close(); }
        }

        public void Insert(TextBox tbNama, ComboBox cbDept, ComboBox cbJabatan, Button btnLoad)
        {
            try
            {
                connection.Open();
                dgvData.DataSource = null;
                dt = new DataTable();
                string sql = "select * from emp_insert(:_nama, :_id_dept, :_id_jabatan)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dept", int.Parse(cbDept.Text));
                cmd.Parameters.AddWithValue("_id_jabatan", int.Parse(cbJabatan.Text));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil ditambahkan");
                    connection.Close();
                    tbNama.Text = null;
                    cbDept.Text = null;
                    btnLoad.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            finally { connection.Close(); }
        }

        public void Edit(TextBox tbNama, ComboBox cbDept, ComboBox cbJabatan, Button btnLoad)
        {
            if (row == null)
            {
                MessageBox.Show("Mohon pilih baris data yang ingin diubah");
            }
            try
            {
                connection.Open();
                string sql = "select * from emp_update(:_id, :_nama, :_id_dept, :_id_jabatan)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_id", row.Cells["_id_karyawan"].Value.ToString());
                cmd.Parameters.AddWithValue("_nama", tbNama.Text);
                cmd.Parameters.AddWithValue("_id_dept", int.Parse(cbDept.Text));
                cmd.Parameters.AddWithValue("_id_jabatan", int.Parse(cbJabatan.Text));

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil diubah");
                    connection.Close();
                    tbNama.Text = null;
                    cbDept.Text = null;
                    row = null;
                    btnLoad.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            finally { connection.Close(); }
        }

        public void Delete(TextBox tbNama, ComboBox cbDept, ComboBox cbJabatan, Button btnLoad)
        {
            if (row == null)
            {
                MessageBox.Show("Mohon pilih baris data yang ingin dihapus");
            }
            try
            {
                connection.Open();
                string sql = "select * from emp_delete(:_id)";
                cmd = new NpgsqlCommand(sql, connection);
                cmd.Parameters.AddWithValue("_id", row.Cells["_id_karyawan"].Value.ToString());

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    MessageBox.Show("Data berhasil dihapus");
                    connection.Close();
                    tbNama.Text = null;
                    cbDept.Text = null;
                    row = null;
                    btnLoad.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
            finally { connection.Close(); }
        }
    }
}
