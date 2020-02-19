using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace restoranTsausova
{
    public partial class Form1 : Form
    {
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\restoranTsausova\Restoran.mdf;Integrated Security=True;Connect Timeout=30"); // можно связать с сайтом     
        int NumberID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Reset();
            FillDataGridView();
        }
      

        private void RadioVid_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
        }

        private void RadioVid2_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
        }

        private void RadioVid3_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
        }

        private void RadioVid4_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
        }

        private void RadioVid5_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
        }

        private void RadioVid6_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSuurus.Text = checkedListBox1.SelectedItem.ToString();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    if (btnSave.Text == "Save")
                    {

                        SqlCommand sqlCmd = new SqlCommand("TableAddOrEddit", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@NumberID", 0);
                        sqlCmd.Parameters.AddWithValue("@TableNumber", txtNumber.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Vid", txtVid.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Hind", txtSuurus.Text.Trim());
                        sqlCmd.ExecuteNonQuery(); // вывод
                        MessageBox.Show("Saved successfull");
                    }
                else
                {
                        SqlCommand sqlCmd = new SqlCommand("TableAddOrEddit", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                        sqlCmd.Parameters.AddWithValue("@NumberID", NumberID);
                        sqlCmd.Parameters.AddWithValue("@TableNumber", txtNumber.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Vid", txtVid.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Hind", txtSuurus.Text.Trim());
                        sqlCmd.ExecuteNonQuery(); // вывод
                        FillDataGridView();
                }
                    MessageBox.Show("Updated successfull");
            }
            catch (Exception ex) // если ошибка
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        private void FillDataGridView()
        {
            if (sqlCon.State == ConnectionState.Closed)
                sqlCon.Open();

            SqlDataAdapter sqlDa = new SqlDataAdapter("NumberViewOrsearch", sqlCon);
            sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
            sqlDa.SelectCommand.Parameters.AddWithValue("@TableNumber", btnSearch.Text.Trim());
            DataTable dtbl = new DataTable();
            sqlDa.Fill(dtbl);
            DataGrid.DataSource = dtbl;
            DataGrid.Columns[0].Visible = false;

            sqlCon.Close();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            
                try
                {
                    FillDataGridView();
                }
                catch (Exception ex) // если ошибка
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }
                finally
                {
                    sqlCon.Close();
                }
            
            
        }

        private void DataGrid_DoubleClick(object sender, EventArgs e)
        {
            if(DataGrid.CurrentRow.Index != -1)
            {
                NumberID = Convert.ToInt32(DataGrid.CurrentRow.Cells[0].Value.ToString());
                txtNumber.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
                txtVid.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
                txtSuurus.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
                btnSave.Text = "Update";
                btnDelete.Enabled = true;
            }
        }
        void Reset()
        {
            txtNumber.Text = txtVid.Text = txtSuurus.Text = "";
            btnSave.Text = "Save";
            NumberID = 0;
            btnDelete.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("MenuuDeletion", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@NumberID", NumberID);
                    sqlCmd.ExecuteNonQuery(); // вывод
                    MessageBox.Show("Deleted successfull");
                    Reset();
                    FillDataGridView();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Message");
                }                         
            
        }
    }
}
