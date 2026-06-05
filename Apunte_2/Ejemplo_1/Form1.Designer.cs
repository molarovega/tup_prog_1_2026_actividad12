namespace Ejemplo_1
{
    partial class FormPrincipal
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrarAlumno = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbLU = new System.Windows.Forms.TextBox();
            this.btnBuscarYVerAlumno = new System.Windows.Forms.Button();
            this.rbSecuencial = new System.Windows.Forms.RadioButton();
            this.rbBinaria = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnMostrarListadoOrdenado = new System.Windows.Forms.Button();
            this.rbBurbuja = new System.Windows.Forms.RadioButton();
            this.rbQuickSort = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrarAlumno);
            this.groupBox1.Location = new System.Drawing.Point(19, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Solicitud datos alumno";
            // 
            // btnRegistrarAlumno
            // 
            this.btnRegistrarAlumno.Location = new System.Drawing.Point(28, 37);
            this.btnRegistrarAlumno.Name = "btnRegistrarAlumno";
            this.btnRegistrarAlumno.Size = new System.Drawing.Size(158, 26);
            this.btnRegistrarAlumno.TabIndex = 0;
            this.btnRegistrarAlumno.Text = "Registrar";
            this.btnRegistrarAlumno.UseVisualStyleBackColor = true;
            this.btnRegistrarAlumno.Click += new System.EventHandler(this.btnRegistrarAlumno_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbBinaria);
            this.groupBox2.Controls.Add(this.rbSecuencial);
            this.groupBox2.Controls.Add(this.btnBuscarYVerAlumno);
            this.groupBox2.Controls.Add(this.tbLU);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(19, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 90);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salidas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LU:";
            // 
            // tbLU
            // 
            this.tbLU.Location = new System.Drawing.Point(49, 25);
            this.tbLU.Name = "tbLU";
            this.tbLU.Size = new System.Drawing.Size(67, 20);
            this.tbLU.TabIndex = 1;
            // 
            // btnBuscarYVerAlumno
            // 
            this.btnBuscarYVerAlumno.Location = new System.Drawing.Point(129, 24);
            this.btnBuscarYVerAlumno.Name = "btnBuscarYVerAlumno";
            this.btnBuscarYVerAlumno.Size = new System.Drawing.Size(55, 20);
            this.btnBuscarYVerAlumno.TabIndex = 2;
            this.btnBuscarYVerAlumno.Text = "Buscar";
            this.btnBuscarYVerAlumno.UseVisualStyleBackColor = true;
            this.btnBuscarYVerAlumno.Click += new System.EventHandler(this.btnBuscarYVerAlumno_Click);
            // 
            // rbSecuencial
            // 
            this.rbSecuencial.AutoSize = true;
            this.rbSecuencial.Location = new System.Drawing.Point(43, 60);
            this.rbSecuencial.Name = "rbSecuencial";
            this.rbSecuencial.Size = new System.Drawing.Size(78, 17);
            this.rbSecuencial.TabIndex = 3;
            this.rbSecuencial.TabStop = true;
            this.rbSecuencial.Text = "Secuencial";
            this.rbSecuencial.UseVisualStyleBackColor = true;
            // 
            // rbBinaria
            // 
            this.rbBinaria.AutoSize = true;
            this.rbBinaria.Location = new System.Drawing.Point(127, 60);
            this.rbBinaria.Name = "rbBinaria";
            this.rbBinaria.Size = new System.Drawing.Size(57, 17);
            this.rbBinaria.TabIndex = 4;
            this.rbBinaria.TabStop = true;
            this.rbBinaria.Text = "Binaria";
            this.rbBinaria.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbQuickSort);
            this.groupBox3.Controls.Add(this.rbBurbuja);
            this.groupBox3.Controls.Add(this.btnMostrarListadoOrdenado);
            this.groupBox3.Location = new System.Drawing.Point(22, 237);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(196, 92);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salidas";
            // 
            // btnMostrarListadoOrdenado
            // 
            this.btnMostrarListadoOrdenado.Location = new System.Drawing.Point(41, 28);
            this.btnMostrarListadoOrdenado.Name = "btnMostrarListadoOrdenado";
            this.btnMostrarListadoOrdenado.Size = new System.Drawing.Size(110, 25);
            this.btnMostrarListadoOrdenado.TabIndex = 0;
            this.btnMostrarListadoOrdenado.Text = "Mostrar Listado";
            this.btnMostrarListadoOrdenado.UseVisualStyleBackColor = true;
            this.btnMostrarListadoOrdenado.Click += new System.EventHandler(this.btnMostrarListadoOrdenado_Click);
            // 
            // rbBurbuja
            // 
            this.rbBurbuja.AutoSize = true;
            this.rbBurbuja.Checked = true;
            this.rbBurbuja.Location = new System.Drawing.Point(23, 66);
            this.rbBurbuja.Name = "rbBurbuja";
            this.rbBurbuja.Size = new System.Drawing.Size(61, 17);
            this.rbBurbuja.TabIndex = 1;
            this.rbBurbuja.TabStop = true;
            this.rbBurbuja.Text = "Burbuja";
            this.rbBurbuja.UseVisualStyleBackColor = true;
            // 
            // rbQuickSort
            // 
            this.rbQuickSort.AutoSize = true;
            this.rbQuickSort.Location = new System.Drawing.Point(113, 66);
            this.rbQuickSort.Name = "rbQuickSort";
            this.rbQuickSort.Size = new System.Drawing.Size(75, 17);
            this.rbQuickSort.TabIndex = 2;
            this.rbQuickSort.Text = "Quick Sort";
            this.rbQuickSort.UseVisualStyleBackColor = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(239, 346);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividad 11";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRegistrarAlumno;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBinaria;
        private System.Windows.Forms.RadioButton rbSecuencial;
        private System.Windows.Forms.Button btnBuscarYVerAlumno;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.RadioButton rbBurbuja;
        private System.Windows.Forms.Button btnMostrarListadoOrdenado;
    }
}

