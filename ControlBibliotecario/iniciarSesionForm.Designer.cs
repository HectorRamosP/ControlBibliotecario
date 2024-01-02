
namespace ControlBibliotecario
{
    partial class iniciarSesionForm
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
            this.admin_Btn = new System.Windows.Forms.Button();
            this.invitado_Btn = new System.Windows.Forms.Button();
            this.nombreUsuario_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // admin_Btn
            // 
            this.admin_Btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.admin_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.admin_Btn.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_Btn.ForeColor = System.Drawing.Color.White;
            this.admin_Btn.Location = new System.Drawing.Point(56, 160);
            this.admin_Btn.Name = "admin_Btn";
            this.admin_Btn.Size = new System.Drawing.Size(305, 50);
            this.admin_Btn.TabIndex = 5;
            this.admin_Btn.Text = "Adiministrador";
            this.admin_Btn.UseVisualStyleBackColor = false;
            this.admin_Btn.Click += new System.EventHandler(this.admin_Btn_Click);
            // 
            // invitado_Btn
            // 
            this.invitado_Btn.BackColor = System.Drawing.Color.MediumTurquoise;
            this.invitado_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.invitado_Btn.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invitado_Btn.ForeColor = System.Drawing.Color.White;
            this.invitado_Btn.Location = new System.Drawing.Point(56, 231);
            this.invitado_Btn.Name = "invitado_Btn";
            this.invitado_Btn.Size = new System.Drawing.Size(305, 50);
            this.invitado_Btn.TabIndex = 5;
            this.invitado_Btn.Text = "Invitado";
            this.invitado_Btn.UseVisualStyleBackColor = false;
            this.invitado_Btn.Click += new System.EventHandler(this.invitado_Btn_Click);
            // 
            // nombreUsuario_Lbl
            // 
            this.nombreUsuario_Lbl.AutoSize = true;
            this.nombreUsuario_Lbl.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreUsuario_Lbl.Location = new System.Drawing.Point(108, 60);
            this.nombreUsuario_Lbl.Name = "nombreUsuario_Lbl";
            this.nombreUsuario_Lbl.Size = new System.Drawing.Size(195, 38);
            this.nombreUsuario_Lbl.TabIndex = 1;
            this.nombreUsuario_Lbl.Text = "Iniciar Sesion";
            // 
            // iniciarSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(424, 365);
            this.Controls.Add(this.invitado_Btn);
            this.Controls.Add(this.admin_Btn);
            this.Controls.Add(this.nombreUsuario_Lbl);
            this.Name = "iniciarSesionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button admin_Btn;
        private System.Windows.Forms.Button invitado_Btn;
        private System.Windows.Forms.Label nombreUsuario_Lbl;
    }
}

