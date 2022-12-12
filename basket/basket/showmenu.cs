using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basket
{
    public partial class showmenu : Form
    {
        string z,v;
        int c,b;
        public showmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void showmenu_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            z = "ODE";
            btn.Text = z;
            para.Visible = true;
        }

        private void showmenu_Load_1(object sender, EventArgs e)
        {
            para.Visible = false;
        }

        private void topla_Click(object sender, EventArgs e)
        {

        }

        private void dell_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows != null)
            {
                    z = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    c = Int32.Parse(topla.Text);
                    c -= Int32.Parse(z);
                        topla.Text = Convert.ToString(c);
                     v = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                     b = Int32.Parse(Program.form1.toplam.Text);
                     b -= Int32.Parse(v);
                        Program.form1.toplam.Text = Convert.ToString(b);
                        dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }
    }
}
