
namespace ControlBibliotecario
{
    partial class VerLibrosForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buscar_Tbx = new System.Windows.Forms.TextBox();
            this.actualizar_Btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.eliminar_Btn = new System.Windows.Forms.Button();
            this.modificar_Btn = new System.Windows.Forms.Button();
            this.nombreDelAutor_Tbx = new System.Windows.Forms.TextBox();
            this.editorial_Tbx = new System.Windows.Forms.TextBox();
            this.edicion_Tbx = new System.Windows.Forms.TextBox();
            this.cantidadDeCopias_Tbx = new System.Windows.Forms.TextBox();
            this.fechaDePublicacion_Tbx = new System.Windows.Forms.TextBox();
            this.categoria_Tbx = new System.Windows.Forms.TextBox();
            this.titulo_Tbx = new System.Windows.Forms.TextBox();
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
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventario";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1163, 69);
            this.panel1.TabIndex = 1;
            // 
            // buscar_Tbx
            // 
            this.buscar_Tbx.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buscar_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar_Tbx.Location = new System.Drawing.Point(416, 102);
            this.buscar_Tbx.Name = "buscar_Tbx";
            this.buscar_Tbx.Size = new System.Drawing.Size(320, 31);
            this.buscar_Tbx.TabIndex = 3;
            this.buscar_Tbx.TextChanged += new System.EventHandler(this.buscar_Tbx_TextChanged);
            // 
            // actualizar_Btn
            // 
            this.actualizar_Btn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.actualizar_Btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.actualizar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.actualizar_Btn.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualizar_Btn.Location = new System.Drawing.Point(751, 102);
            this.actualizar_Btn.Name = "actualizar_Btn";
            this.actualizar_Btn.Size = new System.Drawing.Size(125, 33);
            this.actualizar_Btn.TabIndex = 5;
            this.actualizar_Btn.Text = "Actualizar";
            this.actualizar_Btn.UseVisualStyleBackColor = false;
            this.actualizar_Btn.Click += new System.EventHandler(this.actualizar_Btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 174);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1135, 334);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.eliminar_Btn);
            this.panel2.Controls.Add(this.modificar_Btn);
            this.panel2.Controls.Add(this.nombreDelAutor_Tbx);
            this.panel2.Controls.Add(this.editorial_Tbx);
            this.panel2.Controls.Add(this.edicion_Tbx);
            this.panel2.Controls.Add(this.cantidadDeCopias_Tbx);
            this.panel2.Controls.Add(this.fechaDePublicacion_Tbx);
            this.panel2.Controls.Add(this.categoria_Tbx);
            this.panel2.Controls.Add(this.titulo_Tbx);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1152, 292);
            this.panel2.TabIndex = 7;
            // 
            // eliminar_Btn
            // 
            this.eliminar_Btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.eliminar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.eliminar_Btn.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminar_Btn.Location = new System.Drawing.Point(834, 230);
            this.eliminar_Btn.Name = "eliminar_Btn";
            this.eliminar_Btn.Size = new System.Drawing.Size(120, 43);
            this.eliminar_Btn.TabIndex = 34;
            this.eliminar_Btn.Text = "Eliminar";
            this.eliminar_Btn.UseVisualStyleBackColor = false;
            this.eliminar_Btn.Click += new System.EventHandler(this.eliminar_Btn_Click);
            // 
            // modificar_Btn
            // 
            this.modificar_Btn.BackColor = System.Drawing.Color.PapayaWhip;
            this.modificar_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.modificar_Btn.Font = new System.Drawing.Font("Malgun Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar_Btn.Location = new System.Drawing.Point(683, 230);
            this.modificar_Btn.Name = "modificar_Btn";
            this.modificar_Btn.Size = new System.Drawing.Size(120, 43);
            this.modificar_Btn.TabIndex = 33;
            this.modificar_Btn.Text = "Modificar";
            this.modificar_Btn.UseVisualStyleBackColor = false;
            this.modificar_Btn.Click += new System.EventHandler(this.modificar_Btn_Click);
            // 
            // nombreDelAutor_Tbx
            // 
            this.nombreDelAutor_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreDelAutor_Tbx.Location = new System.Drawing.Point(340, 91);
            this.nombreDelAutor_Tbx.Name = "nombreDelAutor_Tbx";
            this.nombreDelAutor_Tbx.Size = new System.Drawing.Size(218, 30);
            this.nombreDelAutor_Tbx.TabIndex = 31;
            // 
            // editorial_Tbx
            // 
            this.editorial_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editorial_Tbx.Location = new System.Drawing.Point(340, 163);
            this.editorial_Tbx.Name = "editorial_Tbx";
            this.editorial_Tbx.Size = new System.Drawing.Size(218, 30);
            this.editorial_Tbx.TabIndex = 30;
            // 
            // edicion_Tbx
            // 
            this.edicion_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edicion_Tbx.Location = new System.Drawing.Point(340, 235);
            this.edicion_Tbx.Name = "edicion_Tbx";
            this.edicion_Tbx.Size = new System.Drawing.Size(218, 30);
            this.edicion_Tbx.TabIndex = 29;
            // 
            // cantidadDeCopias_Tbx
            // 
            this.cantidadDeCopias_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadDeCopias_Tbx.Location = new System.Drawing.Point(807, 163);
            this.cantidadDeCopias_Tbx.Name = "cantidadDeCopias_Tbx";
            this.cantidadDeCopias_Tbx.Size = new System.Drawing.Size(218, 30);
            this.cantidadDeCopias_Tbx.TabIndex = 27;
            // 
            // fechaDePublicacion_Tbx
            // 
            this.fechaDePublicacion_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDePublicacion_Tbx.Location = new System.Drawing.Point(807, 22);
            this.fechaDePublicacion_Tbx.Name = "fechaDePublicacion_Tbx";
            this.fechaDePublicacion_Tbx.Size = new System.Drawing.Size(218, 30);
            this.fechaDePublicacion_Tbx.TabIndex = 28;
            // 
            // categoria_Tbx
            // 
            this.categoria_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria_Tbx.Location = new System.Drawing.Point(807, 88);
            this.categoria_Tbx.Name = "categoria_Tbx";
            this.categoria_Tbx.Size = new System.Drawing.Size(218, 30);
            this.categoria_Tbx.TabIndex = 28;
            // 
            // titulo_Tbx
            // 
            this.titulo_Tbx.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_Tbx.Location = new System.Drawing.Point(340, 19);
            this.titulo_Tbx.Name = "titulo_Tbx";
            this.titulo_Tbx.Size = new System.Drawing.Size(218, 30);
            this.titulo_Tbx.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(576, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "Cantidad de Copias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(576, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 28);
            this.label8.TabIndex = 19;
            this.label8.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 25;
            this.label4.Text = "Editorial";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(576, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Fecha de Publicacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(127, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 28);
            this.label5.TabIndex = 21;
            this.label5.Text = "Edicion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 28);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nombre del Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 28);
            this.label2.TabIndex = 22;
            this.label2.Text = "Titulo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::ControlBibliotecario.Properties.Resources.buscar1;
            this.pictureBox1.Location = new System.Drawing.Point(370, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // VerLibrosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1160, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.actualizar_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buscar_Tbx);
            this.Controls.Add(this.panel1);
            this.Name = "VerLibrosForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.VerLibrosForm_Load);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox buscar_Tbx;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button actualizar_Btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button eliminar_Btn;
        private System.Windows.Forms.Button modificar_Btn;
        private System.Windows.Forms.TextBox nombreDelAutor_Tbx;
        private System.Windows.Forms.TextBox editorial_Tbx;
        private System.Windows.Forms.TextBox edicion_Tbx;
        private System.Windows.Forms.TextBox cantidadDeCopias_Tbx;
        private System.Windows.Forms.TextBox categoria_Tbx;
        private System.Windows.Forms.TextBox titulo_Tbx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fechaDePublicacion_Tbx;
    }
}