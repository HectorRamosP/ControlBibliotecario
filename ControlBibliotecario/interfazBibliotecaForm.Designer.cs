
namespace ControlBibliotecario
{
    partial class interfazBibliotecaForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anadirUnNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarUnNuevoUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verInformacionDelUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.solicitarUnLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverUnLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.menuStrip1.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.librosToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 72);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anadirUnNuevoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.librosToolStripMenuItem.Image = global::ControlBibliotecario.Properties.Resources.libro_1_;
            this.librosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(139, 68);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // anadirUnNuevoToolStripMenuItem
            // 
            this.anadirUnNuevoToolStripMenuItem.Image = global::ControlBibliotecario.Properties.Resources.agregar;
            this.anadirUnNuevoToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.anadirUnNuevoToolStripMenuItem.Name = "anadirUnNuevoToolStripMenuItem";
            this.anadirUnNuevoToolStripMenuItem.Size = new System.Drawing.Size(326, 70);
            this.anadirUnNuevoToolStripMenuItem.Text = "Anadir un Nuevo Libro";
            this.anadirUnNuevoToolStripMenuItem.Click += new System.EventHandler(this.anadirUnNuevoToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.Image = global::ControlBibliotecario.Properties.Resources.buscar;
            this.verToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(326, 70);
            this.verToolStripMenuItem.Text = "Ver Libros";
            this.verToolStripMenuItem.Click += new System.EventHandler(this.verToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarUnNuevoUsuarioToolStripMenuItem,
            this.verInformacionDelUsuarioToolStripMenuItem});
            this.usuariosToolStripMenuItem.Image = global::ControlBibliotecario.Properties.Resources.perfil;
            this.usuariosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 68);
            this.usuariosToolStripMenuItem.Text = "Usuario";
            // 
            // agregarUnNuevoUsuarioToolStripMenuItem
            // 
            this.agregarUnNuevoUsuarioToolStripMenuItem.Image = global::ControlBibliotecario.Properties.Resources.agregar_usuario;
            this.agregarUnNuevoUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.agregarUnNuevoUsuarioToolStripMenuItem.Name = "agregarUnNuevoUsuarioToolStripMenuItem";
            this.agregarUnNuevoUsuarioToolStripMenuItem.Size = new System.Drawing.Size(368, 70);
            this.agregarUnNuevoUsuarioToolStripMenuItem.Text = "Agregar un Nuevo Usuario";
            this.agregarUnNuevoUsuarioToolStripMenuItem.Click += new System.EventHandler(this.agregarUnNuevoUsuarioToolStripMenuItem_Click);
            // 
            // verInformacionDelUsuarioToolStripMenuItem
            // 
            this.verInformacionDelUsuarioToolStripMenuItem.Image = global::ControlBibliotecario.Properties.Resources.busqueda_de_trabajo;
            this.verInformacionDelUsuarioToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.verInformacionDelUsuarioToolStripMenuItem.Name = "verInformacionDelUsuarioToolStripMenuItem";
            this.verInformacionDelUsuarioToolStripMenuItem.Size = new System.Drawing.Size(368, 70);
            this.verInformacionDelUsuarioToolStripMenuItem.Text = "Ver Informacion del Usuario";
            this.verInformacionDelUsuarioToolStripMenuItem.Click += new System.EventHandler(this.verInformacionDelUsuarioToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitarUnLibroToolStripMenuItem,
            this.devolverUnLibroToolStripMenuItem});
            this.prestamosToolStripMenuItem.Image = global::ControlBibliotecario.Properties.Resources.pedir_prestado;
            this.prestamosToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(173, 68);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // solicitarUnLibroToolStripMenuItem
            // 
            this.solicitarUnLibroToolStripMenuItem.Image = global::ControlBibliotecario.Properties.Resources.educacion;
            this.solicitarUnLibroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.solicitarUnLibroToolStripMenuItem.Name = "solicitarUnLibroToolStripMenuItem";
            this.solicitarUnLibroToolStripMenuItem.Size = new System.Drawing.Size(285, 70);
            this.solicitarUnLibroToolStripMenuItem.Text = "Solicitar un Libro";
            this.solicitarUnLibroToolStripMenuItem.Click += new System.EventHandler(this.solicitarUnLibroToolStripMenuItem_Click);
            // 
            // devolverUnLibroToolStripMenuItem
            // 
            this.devolverUnLibroToolStripMenuItem.Image = global::ControlBibliotecario.Properties.Resources.devolver;
            this.devolverUnLibroToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.devolverUnLibroToolStripMenuItem.Name = "devolverUnLibroToolStripMenuItem";
            this.devolverUnLibroToolStripMenuItem.Size = new System.Drawing.Size(285, 70);
            this.devolverUnLibroToolStripMenuItem.Text = "Devolver un Libro";
            this.devolverUnLibroToolStripMenuItem.Click += new System.EventHandler(this.devolverUnLibroToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = global::ControlBibliotecario.Properties.Resources.salida_de_emergencia;
            this.salirToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(124, 68);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // interfazBibliotecaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControlBibliotecario.Properties.Resources.photo_1507842217343_583bb7270b66;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(974, 578);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "interfazBibliotecaForm";
            this.Text = "Sistema Bibliotecario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anadirUnNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarUnNuevoUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verInformacionDelUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem solicitarUnLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverUnLibroToolStripMenuItem;
    }
}