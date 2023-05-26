namespace Pantalla_Maestra
{
    partial class fmrCrearProducto
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
            this.lblNombreP = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.lblValorP = new System.Windows.Forms.Label();
            this.txtValorP = new System.Windows.Forms.TextBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(23, 93);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(137, 16);
            this.lblNombreP.TabIndex = 51;
            this.lblNombreP.Text = "Nombre Del Producto";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(166, 87);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(171, 22);
            this.txtNombreP.TabIndex = 52;
            // 
            // lblValorP
            // 
            this.lblValorP.AutoSize = true;
            this.lblValorP.Location = new System.Drawing.Point(42, 121);
            this.lblValorP.Name = "lblValorP";
            this.lblValorP.Size = new System.Drawing.Size(118, 16);
            this.lblValorP.TabIndex = 53;
            this.lblValorP.Text = "Valor del Producto";
            // 
            // txtValorP
            // 
            this.txtValorP.Location = new System.Drawing.Point(166, 115);
            this.txtValorP.Name = "txtValorP";
            this.txtValorP.Size = new System.Drawing.Size(171, 22);
            this.txtValorP.TabIndex = 54;
            this.txtValorP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtValorp_KeyPress);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(130, 159);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(90, 35);
            this.btnCrear.TabIndex = 55;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(247, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 56;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(134, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(190, 29);
            this.lblTitulo.TabIndex = 57;
            this.lblTitulo.Text = "Crear Producto";
            // 
            // fmrCrearProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 326);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.txtValorP);
            this.Controls.Add(this.lblValorP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.lblNombreP);
            this.Name = "fmrCrearProducto";
            this.Text = "Crear Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label lblValorP;
        private System.Windows.Forms.TextBox txtValorP;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblTitulo;
    }
}