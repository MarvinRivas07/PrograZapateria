using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zapateria.Negocio;

namespace Zapateria.Presentación
{
    public partial class RegistrarUsuario : Form
    {
        public RegistrarUsuario()
        {
            InitializeComponent();
           
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        clsGestionUsuario GU = new clsGestionUsuario();

        private void RegistrarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (rbAdmin.Text.Equals("Administrador"))
            {
                GU.RegistrarUasuario(txtNombre.Text,txtApellido.Text,txtTelefono.Text,txtNombreusuario.Text,rbAdmin.Text,txtEmail.Text,txtPass.Text,cmbEstado.Text);
            }
            else
            {
                GU.RegistrarUasuario(txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtNombreusuario.Text, rbCajero.Text, txtEmail.Text, txtPass.Text, cmbEstado.Text);
            }
        }
    }
}
