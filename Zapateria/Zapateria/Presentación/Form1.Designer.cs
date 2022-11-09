
namespace Zapateria
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenuPrincipal = new System.Windows.Forms.Panel();
            this.panelMenuVentas = new System.Windows.Forms.Panel();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelMenuCategorias = new System.Windows.Forms.Panel();
            this.btnCategorias = new System.Windows.Forms.Button();
            this.panelMenuMarcas = new System.Windows.Forms.Panel();
            this.btnMarcas = new System.Windows.Forms.Button();
            this.panelMenuProductos = new System.Windows.Forms.Panel();
            this.btnProductos = new System.Windows.Forms.Button();
            this.panelMenuUsuarios = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMostrarUsuarios = new System.Windows.Forms.Button();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.panelMenuInicio = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarSesión = new System.Windows.Forms.Button();
            this.btnIniciarSesión = new System.Windows.Forms.Button();
            this.btnInicio = new System.Windows.Forms.Button();
            this.panelFechaHora = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timerHoraFecha = new System.Windows.Forms.Timer(this.components);
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelMenuPrincipal.SuspendLayout();
            this.panelMenuUsuarios.SuspendLayout();
            this.panelMenuInicio.SuspendLayout();
            this.panelFechaHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenuPrincipal
            // 
            this.panelMenuPrincipal.AutoScroll = true;
            this.panelMenuPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelMenuPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuPrincipal.Controls.Add(this.panelMenuVentas);
            this.panelMenuPrincipal.Controls.Add(this.btnVentas);
            this.panelMenuPrincipal.Controls.Add(this.panelMenuCategorias);
            this.panelMenuPrincipal.Controls.Add(this.btnCategorias);
            this.panelMenuPrincipal.Controls.Add(this.panelMenuMarcas);
            this.panelMenuPrincipal.Controls.Add(this.btnMarcas);
            this.panelMenuPrincipal.Controls.Add(this.panelMenuProductos);
            this.panelMenuPrincipal.Controls.Add(this.btnProductos);
            this.panelMenuPrincipal.Controls.Add(this.panelMenuUsuarios);
            this.panelMenuPrincipal.Controls.Add(this.btnUsuarios);
            this.panelMenuPrincipal.Controls.Add(this.panelMenuInicio);
            this.panelMenuPrincipal.Controls.Add(this.btnInicio);
            this.panelMenuPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuPrincipal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenuPrincipal.ForeColor = System.Drawing.Color.Black;
            this.panelMenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelMenuPrincipal.Name = "panelMenuPrincipal";
            this.panelMenuPrincipal.Size = new System.Drawing.Size(270, 521);
            this.panelMenuPrincipal.TabIndex = 0;
            // 
            // panelMenuVentas
            // 
            this.panelMenuVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelMenuVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuVentas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenuVentas.Location = new System.Drawing.Point(0, 773);
            this.panelMenuVentas.Name = "panelMenuVentas";
            this.panelMenuVentas.Size = new System.Drawing.Size(251, 100);
            this.panelMenuVentas.TabIndex = 14;
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVentas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(0, 738);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(251, 35);
            this.btnVentas.TabIndex = 13;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelMenuCategorias
            // 
            this.panelMenuCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelMenuCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuCategorias.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenuCategorias.Location = new System.Drawing.Point(0, 638);
            this.panelMenuCategorias.Name = "panelMenuCategorias";
            this.panelMenuCategorias.Size = new System.Drawing.Size(251, 100);
            this.panelMenuCategorias.TabIndex = 12;
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategorias.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnCategorias.FlatAppearance.BorderSize = 0;
            this.btnCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategorias.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.Location = new System.Drawing.Point(0, 603);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCategorias.Size = new System.Drawing.Size(251, 35);
            this.btnCategorias.TabIndex = 11;
            this.btnCategorias.Text = "Categoria";
            this.btnCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategorias.UseVisualStyleBackColor = false;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // panelMenuMarcas
            // 
            this.panelMenuMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelMenuMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuMarcas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenuMarcas.Location = new System.Drawing.Point(0, 503);
            this.panelMenuMarcas.Name = "panelMenuMarcas";
            this.panelMenuMarcas.Size = new System.Drawing.Size(251, 100);
            this.panelMenuMarcas.TabIndex = 10;
            // 
            // btnMarcas
            // 
            this.btnMarcas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMarcas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMarcas.FlatAppearance.BorderSize = 0;
            this.btnMarcas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarcas.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcas.ForeColor = System.Drawing.Color.White;
            this.btnMarcas.Location = new System.Drawing.Point(0, 468);
            this.btnMarcas.Name = "btnMarcas";
            this.btnMarcas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMarcas.Size = new System.Drawing.Size(251, 35);
            this.btnMarcas.TabIndex = 9;
            this.btnMarcas.Text = "Marca";
            this.btnMarcas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMarcas.UseVisualStyleBackColor = false;
            this.btnMarcas.Click += new System.EventHandler(this.btnMarcas_Click);
            // 
            // panelMenuProductos
            // 
            this.panelMenuProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelMenuProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuProductos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMenuProductos.Location = new System.Drawing.Point(0, 368);
            this.panelMenuProductos.Name = "panelMenuProductos";
            this.panelMenuProductos.Size = new System.Drawing.Size(251, 100);
            this.panelMenuProductos.TabIndex = 8;
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.Location = new System.Drawing.Point(0, 333);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnProductos.Size = new System.Drawing.Size(251, 35);
            this.btnProductos.TabIndex = 7;
            this.btnProductos.Text = "Productos";
            this.btnProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // panelMenuUsuarios
            // 
            this.panelMenuUsuarios.AccessibleName = "";
            this.panelMenuUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelMenuUsuarios.Controls.Add(this.button3);
            this.panelMenuUsuarios.Controls.Add(this.button2);
            this.panelMenuUsuarios.Controls.Add(this.btnMostrarUsuarios);
            this.panelMenuUsuarios.Controls.Add(this.btnRegistrarUsuario);
            this.panelMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuUsuarios.Location = new System.Drawing.Point(0, 185);
            this.panelMenuUsuarios.Name = "panelMenuUsuarios";
            this.panelMenuUsuarios.Size = new System.Drawing.Size(251, 148);
            this.panelMenuUsuarios.TabIndex = 6;
            this.panelMenuUsuarios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelMenuUsuarios_Paint);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Image = global::Zapateria.Properties.Resources.Btn11;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 105);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(251, 35);
            this.button3.TabIndex = 4;
            this.button3.Text = "       Eliminar";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Zapateria.Properties.Resources.Btn09;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 70);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(251, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "       Modificar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnMostrarUsuarios
            // 
            this.btnMostrarUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnMostrarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMostrarUsuarios.FlatAppearance.BorderSize = 0;
            this.btnMostrarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarUsuarios.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnMostrarUsuarios.Image = global::Zapateria.Properties.Resources.Btn13;
            this.btnMostrarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarUsuarios.Location = new System.Drawing.Point(0, 35);
            this.btnMostrarUsuarios.Name = "btnMostrarUsuarios";
            this.btnMostrarUsuarios.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnMostrarUsuarios.Size = new System.Drawing.Size(251, 35);
            this.btnMostrarUsuarios.TabIndex = 2;
            this.btnMostrarUsuarios.Text = "       Mostrar";
            this.btnMostrarUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarUsuarios.UseVisualStyleBackColor = false;
            this.btnMostrarUsuarios.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.btnRegistrarUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.Image = global::Zapateria.Properties.Resources.Btn10;
            this.btnRegistrarUsuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(0, 0);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(251, 35);
            this.btnRegistrarUsuario.TabIndex = 1;
            this.btnRegistrarUsuario.Text = "       Registrar";
            this.btnRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.Image = global::Zapateria.Properties.Resources.Btn08;
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 150);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(251, 35);
            this.btnUsuarios.TabIndex = 5;
            this.btnUsuarios.Text = "       Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // panelMenuInicio
            // 
            this.panelMenuInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelMenuInicio.Controls.Add(this.btnSalir);
            this.panelMenuInicio.Controls.Add(this.btnCerrarSesión);
            this.panelMenuInicio.Controls.Add(this.btnIniciarSesión);
            this.panelMenuInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuInicio.Location = new System.Drawing.Point(0, 35);
            this.panelMenuInicio.Name = "panelMenuInicio";
            this.panelMenuInicio.Size = new System.Drawing.Size(251, 115);
            this.panelMenuInicio.TabIndex = 4;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Zapateria.Properties.Resources.Btn07;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(0, 70);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnSalir.Size = new System.Drawing.Size(251, 35);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "       Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrarSesión
            // 
            this.btnCerrarSesión.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCerrarSesión.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesión.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesión.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesión.Image = global::Zapateria.Properties.Resources.Btn05;
            this.btnCerrarSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesión.Location = new System.Drawing.Point(0, 35);
            this.btnCerrarSesión.Name = "btnCerrarSesión";
            this.btnCerrarSesión.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnCerrarSesión.Size = new System.Drawing.Size(251, 35);
            this.btnCerrarSesión.TabIndex = 1;
            this.btnCerrarSesión.Text = "       Cerrar Sesión";
            this.btnCerrarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarSesión.UseVisualStyleBackColor = true;
            this.btnCerrarSesión.Click += new System.EventHandler(this.btnCerrarSesión_Click);
            // 
            // btnIniciarSesión
            // 
            this.btnIniciarSesión.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIniciarSesión.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesión.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesión.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesión.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesión.Image = global::Zapateria.Properties.Resources.Btn04;
            this.btnIniciarSesión.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesión.Location = new System.Drawing.Point(0, 0);
            this.btnIniciarSesión.Name = "btnIniciarSesión";
            this.btnIniciarSesión.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnIniciarSesión.Size = new System.Drawing.Size(251, 35);
            this.btnIniciarSesión.TabIndex = 0;
            this.btnIniciarSesión.Text = "       Iniciar Sesión";
            this.btnIniciarSesión.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciarSesión.UseVisualStyleBackColor = true;
            this.btnIniciarSesión.Click += new System.EventHandler(this.btnIniciarSesión_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = global::Zapateria.Properties.Resources.Btn03;
            this.btnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.Location = new System.Drawing.Point(0, 0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInicio.Size = new System.Drawing.Size(251, 35);
            this.btnInicio.TabIndex = 3;
            this.btnInicio.Text = "       Inicio";
            this.btnInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // panelFechaHora
            // 
            this.panelFechaHora.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panelFechaHora.Controls.Add(this.lblFecha);
            this.panelFechaHora.Controls.Add(this.lblHora);
            this.panelFechaHora.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFechaHora.Font = new System.Drawing.Font("Arial Narrow", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelFechaHora.ForeColor = System.Drawing.Color.White;
            this.panelFechaHora.Location = new System.Drawing.Point(270, 0);
            this.panelFechaHora.Name = "panelFechaHora";
            this.panelFechaHora.Size = new System.Drawing.Size(834, 55);
            this.panelFechaHora.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.Location = new System.Drawing.Point(398, 9);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(398, 35);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblHora
            // 
            this.lblHora.Location = new System.Drawing.Point(43, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(300, 35);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "Hora";
            this.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerHoraFecha
            // 
            this.timerHoraFecha.Enabled = true;
            this.timerHoraFecha.Tick += new System.EventHandler(this.timerHoraFecha_Tick);
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(79)))), ((int)(((byte)(79)))));
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContenedor.Location = new System.Drawing.Point(270, 55);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(834, 466);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1104, 521);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelFechaHora);
            this.Controls.Add(this.panelMenuPrincipal);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1120, 560);
            this.Name = "frmPrincipal";
            this.Text = "Zapateria Big Feet";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.panelMenuPrincipal.ResumeLayout(false);
            this.panelMenuUsuarios.ResumeLayout(false);
            this.panelMenuInicio.ResumeLayout(false);
            this.panelFechaHora.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuPrincipal;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Panel panelMenuCategorias;
        private System.Windows.Forms.Button btnCategorias;
        private System.Windows.Forms.Panel panelMenuMarcas;
        private System.Windows.Forms.Button btnMarcas;
        private System.Windows.Forms.Panel panelMenuProductos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Panel panelMenuInicio;
        private System.Windows.Forms.Panel panelMenuVentas;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarSesión;
        private System.Windows.Forms.Button btnIniciarSesión;
        private System.Windows.Forms.Panel panelFechaHora;
        private System.Windows.Forms.Timer timerHoraFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnMostrarUsuarios;
        public System.Windows.Forms.Panel panelMenuUsuarios;
        public System.Windows.Forms.Button btnRegistrarUsuario;
        public System.Windows.Forms.Panel panelContenedor;
    }
}

