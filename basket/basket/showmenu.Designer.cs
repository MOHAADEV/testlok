
namespace basket
{
    partial class showmenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NAMES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LAB = new System.Windows.Forms.Label();
            this.topla = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dell = new System.Windows.Forms.Button();
            this.para = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NAMES,
            this.number,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(751, 409);
            this.dataGridView1.TabIndex = 0;
            // 
            // NAMES
            // 
            this.NAMES.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.NAMES.DefaultCellStyle = dataGridViewCellStyle4;
            this.NAMES.HeaderText = "NAME";
            this.NAMES.MinimumWidth = 6;
            this.NAMES.Name = "NAMES";
            this.NAMES.ReadOnly = true;
            this.NAMES.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // number
            // 
            this.number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.number.DefaultCellStyle = dataGridViewCellStyle5;
            this.number.HeaderText = "number";
            this.number.MinimumWidth = 6;
            this.number.Name = "number";
            this.number.ReadOnly = true;
            this.number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.number.Width = 85;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Price.DefaultCellStyle = dataGridViewCellStyle6;
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.Width = 66;
            // 
            // LAB
            // 
            this.LAB.AutoSize = true;
            this.LAB.Font = new System.Drawing.Font("Elephant", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAB.Location = new System.Drawing.Point(532, 468);
            this.LAB.Name = "LAB";
            this.LAB.Size = new System.Drawing.Size(134, 26);
            this.LAB.TabIndex = 1;
            this.LAB.Text = "TOPLAM :";
            // 
            // topla
            // 
            this.topla.AutoSize = true;
            this.topla.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topla.Location = new System.Drawing.Point(12, 8);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(23, 23);
            this.topla.TabIndex = 2;
            this.topla.Text = "0";
            this.topla.Click += new System.EventHandler(this.topla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(738, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "₺";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn
            // 
            this.btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn.ForeColor = System.Drawing.Color.White;
            this.btn.Location = new System.Drawing.Point(572, 524);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(180, 45);
            this.btn.TabIndex = 4;
            this.btn.Text = "BITIR VE ODEM YAP";
            this.btn.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.topla);
            this.panel1.Location = new System.Drawing.Point(670, 461);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 38);
            this.panel1.TabIndex = 5;
            // 
            // dell
            // 
            this.dell.Location = new System.Drawing.Point(758, 201);
            this.dell.Name = "dell";
            this.dell.Size = new System.Drawing.Size(75, 23);
            this.dell.TabIndex = 6;
            this.dell.Text = "SILL";
            this.dell.UseVisualStyleBackColor = true;
            this.dell.Click += new System.EventHandler(this.dell_Click);
            // 
            // para
            // 
            this.para.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.para.DefaultText = "";
            this.para.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.para.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.para.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.para.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.para.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.para.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.para.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.para.Location = new System.Drawing.Point(424, 533);
            this.para.Name = "para";
            this.para.PasswordChar = '\0';
            this.para.PlaceholderText = "";
            this.para.SelectedText = "";
            this.para.Size = new System.Drawing.Size(95, 36);
            this.para.TabIndex = 7;
            // 
            // showmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 581);
            this.Controls.Add(this.para);
            this.Controls.Add(this.dell);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.LAB);
            this.Controls.Add(this.dataGridView1);
            this.Name = "showmenu";
            this.Text = "showmenu";
            this.Load += new System.EventHandler(this.showmenu_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LAB;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label topla;
        private Guna.UI2.WinForms.Guna2Button btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button dell;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMES;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private Guna.UI2.WinForms.Guna2TextBox para;
    }
}