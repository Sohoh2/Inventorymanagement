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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            try
            { 
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\KOSTA\Documents\UserINFO.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From UserInfo where UserID= '" + txtID.Text + "' and UserPassword = '" + txtPWD.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                MessageBox.Show("Hello!'"+txtID.Text+"'");
                    this.Hide();
                    MenuForm MenuForm1 = new MenuForm();
                    MenuForm1.Show();                
                }
                else            
                    MessageBox.Show("입력된 아이디가 존재하지 않습니다. 회원가입을 해주세요.");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp SG = new SignUp();
            SG.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        bool TagMove;
        int MValX, MValY;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TagMove == true)
            {
                this.SetDesktopLocation(MousePosition.X - MValX, MousePosition.Y - MValY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }
    }
}
