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
    public partial class frmVerUsuarios : Form
    {
        public frmVerUsuarios()
        {
            InitializeComponent();
            dtvVistaUsuarios.DataSource = GU.ViewUsers();
        }
        clsGestionUsuario GU = new clsGestionUsuario();
        private void  VistaUsuarios()
        {
          
        }

        private void frmVerUsuarios_Load(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
