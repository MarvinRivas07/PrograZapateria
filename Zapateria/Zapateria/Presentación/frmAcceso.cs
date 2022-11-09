using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using Zapateria.Negocio;

namespace Zapateria.Presentación
{
    public partial class frmlogin : Form //MaterialSkin.Controls.MaterialForm
    {
        clsLogin log = new clsLogin();
        public frmlogin()
        {
            InitializeComponent();
            // Criando um material theme manager e adicionando o formulário
            /*MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            // Definindo um esquema de Cor para formulário com tom Azul
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE);*/

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }
        

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (radioButton1.Text=="Admin")
            {
                log.Login(txtUser.Text, txtPassword.Text, radioButton1.Text);
                this.Close();
                frmPrincipal fr = new frmPrincipal();
                //fr.HabilitarMenus();
                fr.panelMenuUsuarios.Enabled = true;


            }
            else
            {
                log.Login(txtUser.Text, txtPassword.Text, radioButton2.Text);
            }
            
        }
    }
}
