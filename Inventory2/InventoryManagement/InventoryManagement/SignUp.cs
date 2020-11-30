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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }



        private void btnSSU_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\Documents\UserINFO.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();


            try
            {
                if (txtSPWD.Text ==txtSPWD2.Text)
                {
                    string query = "INSERT INTO UserInfo (UserID, UserPassword, UserPasswordC, Email) VALUES ('" + txtSID.Text + "', '" + txtSPWD.Text + "', '" + txtSPWD2.Text + "', '" + txtSEmail.Text + "')";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);
                    sda.SelectCommand.ExecuteNonQuery();
                    if (txtSID.Text != "" && txtSEmail.Text != "" && txtSPWD.Text != "")
                    {
                        MessageBox.Show("Signed up!");
                        this.Hide();
                        con.Close();
                        Form1 LG = new Form1();
                        LG.Show();
                    }
                    else
                    {
                        label5.Text = "Data Must be entered to all fields.";
                    }

                }
                else
                {
                    label5.Text = "password does not match. Try again";
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"error");
            }


        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 F1 = new Form1();
            F1.Show();
        }

        bool TagMove;
        int MValX, MValY;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
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
