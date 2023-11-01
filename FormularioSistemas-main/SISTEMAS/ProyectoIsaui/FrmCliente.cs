using ProyectoIsaui.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProyectoIsaui
{
    public partial class FrmCliente : FrmBase
    {

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            string sql = "select * from cliente";
            DataTable tbcliente = Db.Select(sql);
        }

        private void CargarBarrio()
        {
            Barrio b = new Barrio();
            DataTable tb = b.GetBarrio();
            cbxBarrio.DataSource = tb;
            cbxBarrio.ValueMember = "codBarrio";
            cbxBarrio.DisplayMember = "nombre";
            cbxBarrio.SelectedIndex = -1;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("Ingresar un nombre");
                return;
            }
            if (txtApellido.Text == "")
            {
                MessageBox.Show("Ingresar apellido");
                return;
            }
            if (txtDireccion.Text == "")
            {
                MessageBox.Show("Ingresar dirección");
                return;
            }
            if (txtTelefono.Text == "")
            {
                MessageBox.Show("Ingresar telefono");
                return;
            }
            if(txtDocumento.Text == "")
            {
                MessageBox.Show("Ingresar Documento");
                return;
            }
            string nombre = "";
            string apellido = "";
            string telefono = "";
            string documento = "";
            string direccion = "";
            nombre = txtNombre.Text;
            apellido = txtApellido.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            documento = txtDocumento.Text;
            string mensaje = "";
            Cliente cli = new Cliente();
            cli.Insertar(nombre, apellido, telefono, documento);
            MessageBox.Show("Datos grabados correctamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDocumento.Text = "";
            txtTelefono.Text = "";
        }


        private void cbxBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxCliente_Enter(object sender, EventArgs e)
        {

        }
    }
}
