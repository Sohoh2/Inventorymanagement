namespace InventoryManagement
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnMI = new System.Windows.Forms.Button();
            this.btnPO = new System.Windows.Forms.Button();
            this.btnSO = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnX = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMI
            // 
            this.btnMI.BackColor = System.Drawing.Color.RosyBrown;
            this.btnMI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMI.Font = new System.Drawing.Font("GoudyOlSt BT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMI.ForeColor = System.Drawing.Color.White;
            this.btnMI.Location = new System.Drawing.Point(108, 303);
            this.btnMI.Name = "btnMI";
            this.btnMI.Size = new System.Drawing.Size(260, 85);
            this.btnMI.TabIndex = 0;
            this.btnMI.Text = "My Inventory";
            this.btnMI.UseVisualStyleBackColor = false;
            this.btnMI.UseWaitCursor = true;
            this.btnMI.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPO
            // 
            this.btnPO.BackColor = System.Drawing.Color.RosyBrown;
            this.btnPO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPO.Font = new System.Drawing.Font("GoudyOlSt BT", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPO.ForeColor = System.Drawing.Color.White;
            this.btnPO.Location = new System.Drawing.Point(108, 423);
            this.btnPO.Name = "btnPO";
            this.btnPO.Size = new System.Drawing.Size(260, 85);
            this.btnPO.TabIndex = 1;
            this.btnPO.Text = "Purchase Orders";
            this.btnPO.UseVisualStyleBackColor = false;
            this.btnPO.UseWaitCursor = true;
            this.btnPO.Click += new System.EventHandler(this.btnPO_Click);
            // 
            // btnSO
            // 
            this.btnSO.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSO.FlatAppearance.BorderSize = 0;
            this.btnSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSO.Location = new System.Drawing.Point(168, 592);
            this.btnSO.Name = "btnSO";
            this.btnSO.Size = new System.Drawing.Size(119, 32);
            this.btnSO.TabIndex = 2;
            this.btnSO.Text = "Sign Out";
            this.btnSO.UseVisualStyleBackColor = false;
            this.btnSO.UseWaitCursor = true;
            this.btnSO.Click += new System.EventHandler(this.btnSO_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.btnX);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 270);
            this.panel1.TabIndex = 6;
            this.panel1.UseWaitCursor = true;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // btnX
            // 
            this.btnX.FlatAppearance.BorderSize = 0;
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("돋움", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnX.Location = new System.Drawing.Point(445, 2);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(29, 23);
            this.btnX.TabIndex = 2;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.UseWaitCursor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.RosyBrown;
            this.label6.Font = new System.Drawing.Font("Freehand591 BT", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(127, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 46);
            this.label6.TabIndex = 7;
            this.label6.Text = "Select Menu...";
            this.label6.UseWaitCursor = true;
            // 
            // btnBack
            // 
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("돋움", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBack.Location = new System.Drawing.Point(411, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(29, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(448, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.UseWaitCursor = true;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(486, 672);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSO);
            this.Controls.Add(this.btnPO);
            this.Controls.Add(this.btnMI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Menu Form";
            this.UseWaitCursor = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMI;
        private System.Windows.Forms.Button btnPO;
        private System.Windows.Forms.Button btnSO;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnX;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}