namespace Library
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Customers_btn = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_guest = new System.Windows.Forms.LinkLabel();
            this.Edit_btn = new System.Windows.Forms.PictureBox();
            this.Add_btn = new System.Windows.Forms.PictureBox();
            this.Remove_btn = new System.Windows.Forms.PictureBox();
            this.Exit_btn = new System.Windows.Forms.PictureBox();
            this.lbl_clock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BookList_DG = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customers_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remove_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookList_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.BookList_DG);
            this.panel1.Controls.Add(this.Customers_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_guest);
            this.panel1.Controls.Add(this.Edit_btn);
            this.panel1.Controls.Add(this.Add_btn);
            this.panel1.Controls.Add(this.Remove_btn);
            this.panel1.Controls.Add(this.Exit_btn);
            this.panel1.Controls.Add(this.lbl_clock);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(558, 493);
            this.panel1.TabIndex = 0;
            // 
            // Customers_btn
            // 
            this.Customers_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customers_btn.Image = global::Library.Properties.Resources.Search_Client;
            this.Customers_btn.Location = new System.Drawing.Point(507, 41);
            this.Customers_btn.Name = "Customers_btn";
            this.Customers_btn.Size = new System.Drawing.Size(48, 48);
            this.Customers_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Customers_btn.TabIndex = 21;
            this.Customers_btn.TabStop = false;
            this.Customers_btn.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RosyBrown;
            this.label1.Location = new System.Drawing.Point(132, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 87);
            this.label1.TabIndex = 19;
            this.label1.Text = "Admin Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_guest
            // 
            this.lbl_guest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_guest.Location = new System.Drawing.Point(2, 2);
            this.lbl_guest.Name = "lbl_guest";
            this.lbl_guest.Size = new System.Drawing.Size(195, 28);
            this.lbl_guest.TabIndex = 12;
            this.lbl_guest.TabStop = true;
            this.lbl_guest.Text = "Test guest mode";
            this.lbl_guest.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_guest_LinkClicked);
            // 
            // Edit_btn
            // 
            this.Edit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit_btn.Image = global::Library.Properties.Resources.Edit1;
            this.Edit_btn.Location = new System.Drawing.Point(435, 395);
            this.Edit_btn.Name = "Edit_btn";
            this.Edit_btn.Size = new System.Drawing.Size(45, 46);
            this.Edit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Edit_btn.TabIndex = 11;
            this.Edit_btn.TabStop = false;
            this.Edit_btn.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add_btn.Image = global::Library.Properties.Resources.Add;
            this.Add_btn.Location = new System.Drawing.Point(363, 395);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(49, 46);
            this.Add_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Add_btn.TabIndex = 10;
            this.Add_btn.TabStop = false;
            this.Add_btn.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Remove_btn.Image = global::Library.Properties.Resources.Trash_Can;
            this.Remove_btn.Location = new System.Drawing.Point(501, 395);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(45, 46);
            this.Remove_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Remove_btn.TabIndex = 9;
            this.Remove_btn.TabStop = false;
            this.Remove_btn.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Exit_btn
            // 
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.Image = global::Library.Properties.Resources.Close;
            this.Exit_btn.Location = new System.Drawing.Point(533, 0);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(24, 25);
            this.Exit_btn.TabIndex = 7;
            this.Exit_btn.TabStop = false;
            this.Exit_btn.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbl_clock
            // 
            this.lbl_clock.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_clock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_clock.Location = new System.Drawing.Point(3, 395);
            this.lbl_clock.Name = "lbl_clock";
            this.lbl_clock.Size = new System.Drawing.Size(354, 46);
            this.lbl_clock.TabIndex = 6;
            this.lbl_clock.Text = "label1";
            this.lbl_clock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BookList_DG
            // 
            this.BookList_DG.AllowUserToAddRows = false;
            this.BookList_DG.AllowUserToDeleteRows = false;
            this.BookList_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BookList_DG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.BookList_DG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BookList_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.BookList_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookList_DG.Location = new System.Drawing.Point(0, 108);
            this.BookList_DG.Name = "BookList_DG";
            this.BookList_DG.ReadOnly = true;
            this.BookList_DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BookList_DG.Size = new System.Drawing.Size(557, 279);
            this.BookList_DG.TabIndex = 22;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 493);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Customers_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Edit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Add_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Remove_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BookList_DG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_clock;
        private System.Windows.Forms.PictureBox Exit_btn;
        private System.Windows.Forms.PictureBox Edit_btn;
        private System.Windows.Forms.PictureBox Add_btn;
        private System.Windows.Forms.PictureBox Remove_btn;
        private System.Windows.Forms.LinkLabel lbl_guest;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox Customers_btn;
        private System.Windows.Forms.DataGridView BookList_DG;
    }
}