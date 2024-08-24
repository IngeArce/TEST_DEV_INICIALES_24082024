namespace Practica_RegistroEmpleados
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pcbAñadir = new System.Windows.Forms.PictureBox();
            this.pcbEliminar = new System.Windows.Forms.PictureBox();
            this.pcbModificar = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellidoPaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAñadir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbModificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbAñadir
            // 
            this.pcbAñadir.BackColor = System.Drawing.Color.SeaShell;
            this.pcbAñadir.Image = ((System.Drawing.Image)(resources.GetObject("pcbAñadir.Image")));
            this.pcbAñadir.Location = new System.Drawing.Point(751, 30);
            this.pcbAñadir.Name = "pcbAñadir";
            this.pcbAñadir.Size = new System.Drawing.Size(70, 70);
            this.pcbAñadir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbAñadir.TabIndex = 0;
            this.pcbAñadir.TabStop = false;
            this.pcbAñadir.Click += new System.EventHandler(this.pcbAñadir_Click);
            // 
            // pcbEliminar
            // 
            this.pcbEliminar.Image = ((System.Drawing.Image)(resources.GetObject("pcbEliminar.Image")));
            this.pcbEliminar.Location = new System.Drawing.Point(751, 260);
            this.pcbEliminar.Name = "pcbEliminar";
            this.pcbEliminar.Size = new System.Drawing.Size(70, 70);
            this.pcbEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbEliminar.TabIndex = 1;
            this.pcbEliminar.TabStop = false;
            this.pcbEliminar.Click += new System.EventHandler(this.pcbEliminar_Click);
            // 
            // pcbModificar
            // 
            this.pcbModificar.Image = ((System.Drawing.Image)(resources.GetObject("pcbModificar.Image")));
            this.pcbModificar.Location = new System.Drawing.Point(751, 148);
            this.pcbModificar.Name = "pcbModificar";
            this.pcbModificar.Size = new System.Drawing.Size(70, 70);
            this.pcbModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbModificar.TabIndex = 2;
            this.pcbModificar.TabStop = false;
            this.pcbModificar.Click += new System.EventHandler(this.pcbModificar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaID,
            this.ColumnaNombre,
            this.ColumnaApellidoPaterno,
            this.ColumnaApellidoMaterno,
            this.ColumnaEdad,
            this.ColumnaMail});
            this.dataGridView1.Location = new System.Drawing.Point(30, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(643, 300);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnaID
            // 
            this.ColumnaID.HeaderText = "ID";
            this.ColumnaID.Name = "ColumnaID";
            this.ColumnaID.ReadOnly = true;
            // 
            // ColumnaNombre
            // 
            this.ColumnaNombre.HeaderText = "Nombre";
            this.ColumnaNombre.Name = "ColumnaNombre";
            this.ColumnaNombre.ReadOnly = true;
            // 
            // ColumnaApellidoPaterno
            // 
            this.ColumnaApellidoPaterno.HeaderText = "Apellido Paterno";
            this.ColumnaApellidoPaterno.Name = "ColumnaApellidoPaterno";
            this.ColumnaApellidoPaterno.ReadOnly = true;
            // 
            // ColumnaApellidoMaterno
            // 
            this.ColumnaApellidoMaterno.HeaderText = "Apellido Materno";
            this.ColumnaApellidoMaterno.Name = "ColumnaApellidoMaterno";
            this.ColumnaApellidoMaterno.ReadOnly = true;
            // 
            // ColumnaEdad
            // 
            this.ColumnaEdad.HeaderText = "Edad";
            this.ColumnaEdad.Name = "ColumnaEdad";
            this.ColumnaEdad.ReadOnly = true;
            // 
            // ColumnaMail
            // 
            this.ColumnaMail.HeaderText = "E-mail";
            this.ColumnaMail.Name = "ColumnaMail";
            this.ColumnaMail.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 429);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pcbModificar);
            this.Controls.Add(this.pcbEliminar);
            this.Controls.Add(this.pcbAñadir);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAñadir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbModificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbAñadir;
        private System.Windows.Forms.PictureBox pcbEliminar;
        private System.Windows.Forms.PictureBox pcbModificar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellidoPaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaApellidoMaterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMail;
    }
}

