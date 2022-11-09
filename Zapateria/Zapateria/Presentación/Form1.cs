using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zapateria.Datos;
using Zapateria.Presentación;

namespace Zapateria
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            CustomizeDesing();
            
        }
       
        private void frmPrincipal_Load(object sender, EventArgs e)
        {


        }
        //public Panel panelmenuUsuarios { get;set;}
        private void CustomizeDesing()
        {
            panelMenuInicio.Visible = false;
            panelMenuUsuarios.Visible = false;
            panelMenuProductos.Visible = false;
            panelMenuMarcas.Visible = false;
            panelMenuCategorias.Visible = false;
            panelMenuVentas.Visible = false;
        }
        private void HideMenus()
        {
            if (panelMenuInicio.Visible == true)
                panelMenuInicio.Visible = false;
            if (panelMenuUsuarios.Visible == true)
                panelMenuUsuarios.Visible = false;
            if (panelMenuProductos.Visible == true)
                panelMenuProductos.Visible = false;
            if (panelMenuMarcas.Visible == true)
                panelMenuMarcas.Visible = false;
            if (panelMenuCategorias.Visible == true)
                panelMenuCategorias.Visible = false;
            if (panelMenuVentas.Visible == true)
                panelMenuVentas.Visible = false;
        }
        public void ShowMenus(Panel menu)
        {
            if (menu.Visible == false)
            {
                HideMenus();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }

        }
        public void HabilitarMenus()
        {
            panelMenuUsuarios.Enabled = true;
        }

        private Form formActivo = null;
        //private Form formInactivo = null;
        private void AbrirFormularios(Form formHijo)
        {
            if (formActivo != null)
            {
                formActivo.Close();
            }
            formActivo = formHijo;
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(formHijo);
            
            panelContenedor.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }


        private void btnInicio_Click(object sender, EventArgs e)
        {
            ShowMenus(panelMenuInicio);
        }

        private void btnIniciarSesión_Click(object sender, EventArgs e)
        {
            
            AbrirFormularios(new frmlogin());
            /*
             * Your codes
             */
            HideMenus();
        }

        private void btnCerrarSesión_Click(object sender, EventArgs e)
        {
            /*
             * Your codes
             */
            HideMenus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            /*
             * Your codes
             */
            HideMenus();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            ShowMenus(panelMenuUsuarios);
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ShowMenus(panelMenuProductos);
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            ShowMenus(panelMenuMarcas);
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            ShowMenus(panelMenuCategorias);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            ShowMenus(panelMenuVentas);
        }

        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new RegistrarUsuario());
            HideMenus();
        }

        private void timerHoraFecha_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void panelMenuUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frmVerUsuarios());
            HideMenus();
        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
