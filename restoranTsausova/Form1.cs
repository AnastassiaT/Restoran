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
        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\opilane\source\repos\restoranTsausova\DB\Restoran.mdf;Integrated Security=True;Connect Timeout=30"); // можно связать с сайтом     
        int NumberID = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioVid_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
                pictureBox1.Image = Image.FromFile("C:/Users/opilane/source/repos/restoranTsausova/restoranTsausova/Resources/img/peperoni.jpg");
        }

        private void RadioVid2_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
                pictureBox1.Image = Image.FromFile("C:/Users/opilane/source/repos/restoranTsausova/restoranTsausova/Resources/img/mjaso.jpg");
        }

        private void RadioVid3_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
                pictureBox1.Image = Image.FromFile("C:/Users/opilane/source/repos/restoranTsausova/restoranTsausova/Resources/img/vegan.jpg");
        }

        private void RadioVid4_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
                pictureBox1.Image = Image.FromFile("C:/Users/opilane/source/repos/restoranTsausova/restoranTsausova/Resources/img/margarita.jpg");
        }

        private void RadioVid5_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
                pictureBox1.Image = Image.FromFile("C:/Users/opilane/source/repos/restoranTsausova/restoranTsausova/Resources/img/sqr.jpg");
        }

        private void RadioVid6_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
                txtVid.Text = (sender as RadioButton).Text;
                pictureBox1.Image = Image.FromFile("C:/Users/opilane/source/repos/restoranTsausova/restoranTsausova/Resources/img/moreprodukt.jpg");
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                    if (sqlCon.State == ConnectionState.Closed)
                        sqlCon.Open();
                    if (btnSave.Text == "Сохранить")
                    {

                        SqlCommand sqlCmd = new SqlCommand("TableAddOrEddit", sqlCon);
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@mode", "Add");
                        sqlCmd.Parameters.AddWithValue("@NumberID", 0);
                        sqlCmd.Parameters.AddWithValue("@TableNumber", txtNumber.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Vid", txtVid.Text.Trim());
                        sqlCmd.Parameters.AddWithValue("@Hind", txtSuurus.Text.Trim());
                        sqlCmd.ExecuteNonQuery(); // вывод
                        MessageBox.Show("Данные сохранены");
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
                        MessageBox.Show("Обновление сохранено");
                    }
                    Reset();
                    FillDataGridView();
            }
            catch (Exception ex) // если ошибка
            {
                MessageBox.Show(ex.Message, "Сообщение об ошибке");
            }
            finally
            {
                sqlCon.Close();
            }
        }

        void FillDataGridView()
        {
            {
                if (sqlCon.State == ConnectionState.Closed)
                    sqlCon.Open();

                SqlDataAdapter sqlDa = new SqlDataAdapter("NumberViewOrsearch", sqlCon);
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@TableNumber", txtSearch.Text.Trim());
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                DataGrid.DataSource = dtbl;
                DataGrid.Columns[0].Visible = false;
                sqlCon.Close();
            }            
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {          
                try
                {
                    FillDataGridView();
                }
                catch (Exception ex) // если ошибка
                {
                    MessageBox.Show(ex.Message, "Сообщение об ошибке");
                }
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(DataGrid.CurrentRow.Index != -1)
            {
                NumberID = Convert.ToInt32(DataGrid.CurrentRow.Cells[0].Value.ToString());
                txtNumber.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
                txtVid.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
                txtSuurus.Text = DataGrid.CurrentRow.Cells[3].Value.ToString();
                btnSave.Text = "Обновить";
                btnDelete.Enabled = true;
            }
            DataGrid.Rows[0].Cells[4].Value = Image.FromFile("C:/Users/opilane/source/repos/restoranTsausova/restoranTsausova/Resources/img/moreprodukt.jpg");
        }
        void Reset()
        {
            {
                txtNumber.Text = txtVid.Text = txtSuurus.Text = "";
                btnSave.Text = "Сохранить";
                NumberID = 0;
                btnDelete.Enabled = false;
            }
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
                MessageBox.Show("Удаление сохранено");
                Reset();
                FillDataGridView();
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message, "Сообщение об ошибке");
            }                        
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            txtSuurus.Text = (sender as CheckBox).Text;

        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
            }
            txtSuurus.Text = (sender as CheckBox).Text;
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox4.Checked = false;
            }
            txtSuurus.Text = (sender as CheckBox).Text;
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
            }
            txtSuurus.Text = (sender as CheckBox).Text;
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
