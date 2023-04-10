using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryClinica_LP3
{
    public partial class frm2 : Form
    {
        Medicos med;
        public frm2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Declarar de forma mas eficiente la creacion del objeto
            med = new Medicos();
            listBox1.DisplayMember = "nombre";
            listBox1.ValueMember = "matricula";
            listBox1.DataSource = med.getAll();       
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(listBox1.SelectedValue));
            MessageBox.Show(listBox1.Text);
            //MessageBox.Show(Convert.ToString(listBox1.SelectedIndex));
        }
        
    }
}
