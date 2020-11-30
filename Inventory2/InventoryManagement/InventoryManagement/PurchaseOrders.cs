using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class PurchaseOrders : Form
    {
        public PurchaseOrders()
        {
            InitializeComponent();
        }

        private void PurchaseOrders_Load(object sender, EventArgs e)
        {

        }
        public string LI;








        private void btnX_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuForm MF = new MenuForm();
            MF.Show();

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            ListViewItem LI = new ListViewItem();

            LI.Text = txtPIN.Text;

            LI.SubItems.Add(txtPQY.Text);
            LI.SubItems.Add(txtPDC.Text);
            LI.SubItems.Add(txtPPE.Text);
            LI.SubItems.Add(txtPNT.Text);

            listView1.Items.Add(LI);
        }

        private void btnDT_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < listView1.SelectedItems.Count; i++)
            {
                listView1.Items.Remove(listView1.SelectedItems[i]);
            }
        }

        private void btnOD_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to order these items?");
            MessageBox.Show("Ordered!");
            this.Hide();

            PurchaseOrder PO = new PurchaseOrder();
            PO.lv = listView1;
            PO.Show();
        }

        bool TagMove;
        int MValX, MValY;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TagMove = true;
            MValX = e.X;
            MValY = e.Y;
        }

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


    }
}
