namespace Library.Resources
{
    partial class GuestForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SearchBox_txt = new System.Windows.Forms.TextBox();
            this.btn_LoanAndBuy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Book_DG = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_DG)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchBox_txt
            // 
            this.SearchBox_txt.Location = new System.Drawing.Point(66, 57);
            this.SearchBox_txt.Name = "SearchBox_txt";
            this.SearchBox_txt.Size = new System.Drawing.Size(214, 20);
            this.SearchBox_txt.TabIndex = 3;
            this.SearchBox_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btn_LoanAndBuy
            // 
            this.btn_LoanAndBuy.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_LoanAndBuy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_LoanAndBuy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LoanAndBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoanAndBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LoanAndBuy.ForeColor = System.Drawing.Color.Black;
            this.btn_LoanAndBuy.Location = new System.Drawing.Point(454, 57);
            this.btn_LoanAndBuy.Name = "btn_LoanAndBuy";
            this.btn_LoanAndBuy.Size = new System.Drawing.Size(227, 33);
            this.btn_LoanAndBuy.TabIndex = 6;
            this.btn_LoanAndBuy.Text = "Loan/Buy a book";
            this.btn_LoanAndBuy.UseVisualStyleBackColor = false;
            this.btn_LoanAndBuy.Click += new System.EventHandler(this.btn_Loan_Click);
            this.btn_LoanAndBuy.MouseEnter += new System.EventHandler(this.btn_Loan_MouseEnter);
            this.btn_LoanAndBuy.MouseLeave += new System.EventHandler(this.btn_Loan_MouseLeave);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 14.25F, System.Drawing.FontStyle.Italic);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(196, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(358, 54);
            this.label1.TabIndex = 20;
            this.label1.Text = "Guest Mode";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Library.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(34, 57);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Library.Properties.Resources.Close;
            this.pictureBox1.Location = new System.Drawing.Point(735, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Book_DG
            // 
            this.Book_DG.AllowUserToAddRows = false;
            this.Book_DG.AllowUserToDeleteRows = false;
            this.Book_DG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Book_DG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.Book_DG.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Book_DG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Book_DG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Book_DG.Location = new System.Drawing.Point(-1, 96);
            this.Book_DG.Name = "Book_DG";
            this.Book_DG.ReadOnly = true;
            this.Book_DG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Book_DG.Size = new System.Drawing.Size(764, 367);
            this.Book_DG.TabIndex = 23;
            // 
            // GuestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(763, 462);
            this.Controls.Add(this.Book_DG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_LoanAndBuy);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.SearchBox_txt);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GuestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GuestForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Book_DG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SearchBox_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btn_LoanAndBuy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Book_DG;
    }
}