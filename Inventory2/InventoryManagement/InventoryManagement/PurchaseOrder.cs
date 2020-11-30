using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class PurchaseOrder : Form
    {
        public PurchaseOrder()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        public ListView lv;
        private void PurchaseOrder_Load(object sender, EventArgs e)
        {
 //           PurchaseOrders PO = new PurchaseOrders();
    
            //try
            //{
            //    for (int i = 1; i <= lv.Items.Count; i++)
            //    {
            //        string a1 = lv.Items[i].SubItems[i].Text;
            //        textBox1.Text = a1;

            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message, "error!");

            //}
        }

        private void PurchaseOrder_Activated(object sender, EventArgs e)
        {
            int i, j, l;
            string[] array3;
            
            try
            {
                for ( i = 0; i < lv.Items.Count; i++)
                {                  
                  for (j = 0; j < 5; j++)
                    {                      
                        string a1 = lv.Items[i].SubItems[j].Text;
                        array3 = new string[] {a1};
                        textBox1.Text += string.Format("{0,6}", array3);
                        //if ((i % 5) == 0) textBox1.Text += "\r\n";
                  
                    }
                    textBox1.Text += "\r\n";
                   // if ((i % 5) == 0) textBox1.Text += "\r\n";
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error!");

            }

        }


        private void btnX_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseOrders POS = new PurchaseOrders();
            POS.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }
    }
}
