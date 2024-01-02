
namespace ControlBibliotecario
{
    partial class VerAlumnosForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.actualizar_Btn = new System.Windows.Forms.Button();
            this.buscar_Tbx = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.modificar_Btn = new System.Windows.Forms.Button();
            this.femenino_Rb = new System.Windows.Forms.RadioButton();
            this.eliminar_Btn = new System.Windows.Forms.Button();
            this.masculino_Rb = new System.Windows.Forms.RadioButton();
            this.apellidoPaterno_Tbx = new System.Windows.Forms.TextBox();
            this.apellidoMaterno_Tbx = new System.Windows.Forms.TextBox();
            this.fechaDeNacimiento_Tbx = new System.Windows.Forms.TextBox();
            this.numeroDeTelefono_Tbx = new System.Windows.Forms.TextBox();
            this.correoElectronico_Tbx = new System.Windows.Forms.TextBox();
            this.direccion_Tbx = new System.Windows.Forms.TextBox();
            this.nombre_Tbx = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 69);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(606, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuarios";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 163);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1230, 334);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // actualizar_Btn
            // 
            this.actualizar_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.actualizar_Btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.actualizar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.actualizar_Btn.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar_Btn.Location = new System.Drawing.Point(802, 100);
            this.actualizar_Btn.Name = "actualizar_Btn";
            this.actualizar_Btn.Size = new System.Drawing.Size(125, 33);
            this.actualizar_Btn.TabIndex = 10;
            this.actualizar_Btn.Text = "Actualizar";
            this.actualizar_Btn.UseVisualStyleBackColor = false;
            this.actualizar_Btn.Click += new System.EventHandler(this.actualizar_Btn_Click);
            // 
            // buscar_Tbx
            // 
            this.buscar_Tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buscar_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_Tbx.Location = new System.Drawing.Point(467, 100);
            this.buscar_Tbx.Name = "buscar_Tbx";
            this.buscar_Tbx.Size = new System.Drawing.Size(320, 31);
            this.buscar_Tbx.TabIndex = 8;
            this.buscar_Tbx.TextChanged += new System.EventHandler(this.buscar_Tbx_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.modificar_Btn);
            this.panel2.Controls.Add(this.femenino_Rb);
            this.panel2.Controls.Add(this.eliminar_Btn);
            this.panel2.Controls.Add(this.masculino_Rb);
            this.panel2.Controls.Add(this.apellidoPaterno_Tbx);
            this.panel2.Controls.Add(this.apellidoMaterno_Tbx);
            this.panel2.Controls.Add(this.fechaDeNacimiento_Tbx);
            this.panel2.Controls.Add(this.numeroDeTelefono_Tbx);
            this.panel2.Controls.Add(this.correoElectronico_Tbx);
            this.panel2.Controls.Add(this.direccion_Tbx);
            this.panel2.Controls.Add(this.nombre_Tbx);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 512);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 381);
            this.panel2.TabIndex = 11;
            // 
            // modificar_Btn
            // 
            this.modificar_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.modificar_Btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.modificar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modificar_Btn.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_Btn.Location = new System.Drawing.Point(799, 309);
            this.modificar_Btn.Name = "modificar_Btn";
            this.modificar_Btn.Size = new System.Drawing.Size(120, 43);
            this.modificar_Btn.TabIndex = 33;
            this.modificar_Btn.Text = "Modificar";
            this.modificar_Btn.UseVisualStyleBackColor = false;
            this.modificar_Btn.Click += new System.EventHandler(this.modificar_Btn_Click);
            // 
            // femenino_Rb
            // 
            this.femenino_Rb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.femenino_Rb.AutoSize = true;
            this.femenino_Rb.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.femenino_Rb.Location = new System.Drawing.Point(1032, 25);
            this.femenino_Rb.Name = "femenino_Rb";
            this.femenino_Rb.Size = new System.Drawing.Size(113, 29);
            this.femenino_Rb.TabIndex = 32;
            this.femenino_Rb.TabStop = true;
            this.femenino_Rb.Text = "Femenino";
            this.femenino_Rb.UseVisualStyleBackColor = true;
            // 
            // eliminar_Btn
            // 
            this.eliminar_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.eliminar_Btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.eliminar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminar_Btn.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_Btn.Location = new System.Drawing.Point(954, 309);
            this.eliminar_Btn.Name = "eliminar_Btn";
            this.eliminar_Btn.Size = new System.Drawing.Size(120, 43);
            this.eliminar_Btn.TabIndex = 34;
            this.eliminar_Btn.Text = "Eliminar";
            this.eliminar_Btn.UseVisualStyleBackColor = false;
            this.eliminar_Btn.Click += new System.EventHandler(this.eliminar_Btn_Click);
            // 
            // masculino_Rb
            // 
            this.masculino_Rb.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.masculino_Rb.AutoSize = true;
            this.masculino_Rb.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.masculino_Rb.Location = new System.Drawing.Point(889, 24);
            this.masculino_Rb.Name = "masculino_Rb";
            this.masculino_Rb.Size = new System.Drawing.Size(115, 29);
            this.masculino_Rb.TabIndex = 33;
            this.masculino_Rb.TabStop = true;
            this.masculino_Rb.Text = "Masculino";
            this.masculino_Rb.UseVisualStyleBackColor = true;
            // 
            // apellidoPaterno_Tbx
            // 
            this.apellidoPaterno_Tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.apellidoPaterno_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoPaterno_Tbx.Location = new System.Drawing.Point(380, 97);
            this.apellidoPaterno_Tbx.Name = "apellidoPaterno_Tbx";
            this.apellidoPaterno_Tbx.Size = new System.Drawing.Size(218, 30);
            this.apellidoPaterno_Tbx.TabIndex = 31;
            // 
            // apellidoMaterno_Tbx
            // 
            this.apellidoMaterno_Tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.apellidoMaterno_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoMaterno_Tbx.Location = new System.Drawing.Point(380, 167);
            this.apellidoMaterno_Tbx.Name = "apellidoMaterno_Tbx";
            this.apellidoMaterno_Tbx.Size = new System.Drawing.Size(218, 30);
            this.apellidoMaterno_Tbx.TabIndex = 30;
            // 
            // fechaDeNacimiento_Tbx
            // 
            this.fechaDeNacimiento_Tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fechaDeNacimiento_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDeNacimiento_Tbx.Location = new System.Drawing.Point(380, 239);
            this.fechaDeNacimiento_Tbx.Name = "fechaDeNacimiento_Tbx";
            this.fechaDeNacimiento_Tbx.Size = new System.Drawing.Size(218, 30);
            this.fechaDeNacimiento_Tbx.TabIndex = 29;
            // 
            // numeroDeTelefono_Tbx
            // 
            this.numeroDeTelefono_Tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.numeroDeTelefono_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroDeTelefono_Tbx.Location = new System.Drawing.Point(914, 240);
            this.numeroDeTelefono_Tbx.Name = "numeroDeTelefono_Tbx";
            this.numeroDeTelefono_Tbx.Size = new System.Drawing.Size(218, 30);
            this.numeroDeTelefono_Tbx.TabIndex = 27;
            // 
            // correoElectronico_Tbx
            // 
            this.correoElectronico_Tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.correoElectronico_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correoElectronico_Tbx.Location = new System.Drawing.Point(914, 167);
            this.correoElectronico_Tbx.Name = "correoElectronico_Tbx";
            this.correoElectronico_Tbx.Size = new System.Drawing.Size(218, 30);
            this.correoElectronico_Tbx.TabIndex = 27;
            // 
            // direccion_Tbx
            // 
            this.direccion_Tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.direccion_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccion_Tbx.Location = new System.Drawing.Point(914, 89);
            this.direccion_Tbx.Name = "direccion_Tbx";
            this.direccion_Tbx.Size = new System.Drawing.Size(218, 30);
            this.direccion_Tbx.TabIndex = 28;
            // 
            // nombre_Tbx
            // 
            this.nombre_Tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nombre_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_Tbx.Location = new System.Drawing.Point(380, 23);
            this.nombre_Tbx.Name = "nombre_Tbx";
            this.nombre_Tbx.Size = new System.Drawing.Size(218, 30);
            this.nombre_Tbx.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(683, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 28);
            this.label6.TabIndex = 24;
            this.label6.Text = "Correo Electronico";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(683, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "Numero de Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(683, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Apellido Materno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(683, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha de Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Apellido Paterno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(155, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ControlBibliotecario.Properties.Resources.buscar1;
            this.pictureBox1.Location = new System.Drawing.Point(421, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // VerAlumnosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1307, 586);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.actualizar_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buscar_Tbx);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "VerAlumnosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VerAlumnosForm";
            this.Load += new System.EventHandler(this.VerAlumnosForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button actualizar_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox buscar_Tbx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox apellidoPaterno_Tbx;
        private System.Windows.Forms.TextBox apellidoMaterno_Tbx;
        private System.Windows.Forms.TextBox fechaDeNacimiento_Tbx;
        private System.Windows.Forms.TextBox correoElectronico_Tbx;
        private System.Windows.Forms.TextBox direccion_Tbx;
        private System.Windows.Forms.TextBox nombre_Tbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button eliminar_Btn;
        private System.Windows.Forms.Button modificar_Btn;
        private System.Windows.Forms.TextBox numeroDeTelefono_Tbx;
        private System.Windows.Forms.RadioButton femenino_Rb;
        private System.Windows.Forms.RadioButton masculino_Rb;
    }
}