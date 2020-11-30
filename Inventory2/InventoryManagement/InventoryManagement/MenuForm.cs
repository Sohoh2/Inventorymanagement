using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyInventory MI = new MyInventory();
            MI.Show();
        }

        private void btnPO_Click(object sender, EventArgs e)
        {
            this.Hide();
            PurchaseOrders PO = new PurchaseOrders();
            PO.Show();

            
        }

        private void btnX_Click(object sender, EventArgs e)
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

        private void btnSO_Click(object sender, EventArgs e)
        {
            this.Close();
            Form LG = new Form();
            LG.Show();
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TagMove = false;
        }
    }
}
