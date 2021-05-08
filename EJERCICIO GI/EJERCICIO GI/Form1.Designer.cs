
namespace EJERCICIO_GI
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresarDato = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.dgtDatos = new System.Windows.Forms.DataGridView();
            this.REGISTRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese un dato";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIngresarDato
            // 
            this.txtIngresarDato.Location = new System.Drawing.Point(57, 51);
            this.txtIngresarDato.Name = "txtIngresarDato";
            this.txtIngresarDato.Size = new System.Drawing.Size(179, 20);
            this.txtIngresarDato.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(106, 88);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // dgtDatos
            // 
            this.dgtDatos.AllowUserToAddRows = false;
            this.dgtDatos.AllowUserToDeleteRows = false;
            this.dgtDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.REGISTRO});
            this.dgtDatos.Location = new System.Drawing.Point(33, 132);
            this.dgtDatos.Name = "dgtDatos";
            this.dgtDatos.ReadOnly = true;
            this.dgtDatos.Size = new System.Drawing.Size(240, 150);
            this.dgtDatos.TabIndex = 3;
            // 
            // REGISTRO
            // 
            this.REGISTRO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.REGISTRO.HeaderText = "REGISTRO";
            this.REGISTRO.Name = "REGISTRO";
            this.REGISTRO.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 317);
            this.Controls.Add(this.dgtDatos);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtIngresarDato);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIngresarDato;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.DataGridView dgtDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGISTRO;
    }
}

