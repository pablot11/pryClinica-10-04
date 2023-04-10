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
    public partial class frmPrincipal : Form
    {
        //Declaramos los objetos comunes que usamos en el formulario
        Especialidades esp;
        Medicos Med;
        DataTable tabla;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)

        {
            //Primer valor del parentesis es como nos vamos a referir por codigo a la columna,
            //la segunda es como se muestra en la grilla

            dgvListaMedicos.Columns.Add("Matricula", "Matricula");
            dgvListaMedicos.Columns.Add("Nombre", "Nombre");
            dgvListaMedicos.Columns.Add("Celular", "Celular");

            try
            {
                //Constructores se crean primero en el load para evitar problemas
                esp = new Especialidades();
                //Que en el combobox me muestre solo el nombre
                cmbEspecialidades.DisplayMember = "nombre";
                cmbEspecialidades.ValueMember = "especialidad";
                cmbEspecialidades.DataSource = esp.getAll();
                //Optimizamos el codigo
                Med = new Medicos();
                tabla = Med.getAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Problemas con la base de datos", "Error");
                this.Close();
            }


            //Otra forma
            //DataTable tabla = new DataTable();
            //tabla = esp.getAll();
            //cmbEspecialidades.DataSource = tabla;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            //Borra las filas
            dgvListaMedicos.Rows.Clear();
            //No usar selected.Index indica la posicion del elemento
            //Selected value 
            //.Text para el texto del cmb
            int varEspecialidad = Convert.ToInt32(cmbEspecialidades.SelectedValue);
            // MessageBox.Show(cmbEspecialidades.Text);
 
            //Cada registro se almacena en la variable fila
            foreach (DataRow fila in tabla.Rows)
            {

                if (Convert.ToInt32(fila["especialidad"]) == varEspecialidad)
                {
                    dgvListaMedicos.Rows.Add(fila["matricula"], fila["nombre"], fila["celular"]);
                }


            }

        }

        private void btnFrm2_Click(object sender, EventArgs e)
        {
            frm2 f2 = new frm2();
            f2.ShowDialog();
        }
    }
}
