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

namespace InventoryManagement
{
    public partial class MyInventory : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\Documents\UserINFO.mdf;Integrated Security=True;Connect Timeout=30");
        
        public MyInventory()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "INSERT INTO InventoryDetails (Categories, Description, Location, Value, Purchased) VALUES('" + txtCG.Text + "','" + txtDC.Text + "','" + txtLK.Text + "','" + txtVL.Text + "', '" + txtPC.Text + "')";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("successfully saved");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int x = dataGridView1.ColumnCount;
            int y = dataGridView1.RowCount;
            int i, j, k;


                    con.Open();
                    string query = "UPDATE InventoryDetails SET Categories='" + txtCG.Text + "', Description='" + txtDC.Text + "',Location='" + txtLK.Text + "', Value='" + txtVL.Text + "', Purchased='" + txtPC.Text + "' WHERE Id='" + txtID.Text + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    con.Close();            
                    MessageBox.Show("Updated");
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM InventoryDetails";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            txtID.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtCG.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtDC.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtLK.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtVL.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtPC.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();       

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM InventoryDetails where Id='" + txtID.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            sda.SelectCommand.ExecuteNonQuery();   
            con.Close();
            MessageBox.Show("Deleted");
        }

        private void MyInventory_Load(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm MF = new MenuForm();
            MF.Show();
        }

        private void btnSRH_Click(object sender, EventArgs e)
        {

       
            try
            {
                con.Open();
                string query = "SELECT * FROM InventoryDetails WHERE Categories LIKE '" + txtSRH.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                sda.SelectCommand.ExecuteNonQuery();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        bool TagMove;
        int MValX, MValY;

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }

        }
    }
}
