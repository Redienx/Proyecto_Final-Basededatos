namespace Pantalla_Maestra
{
    partial class fmrActualizarProducto
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtValorP = new System.Windows.Forms.TextBox();
            this.lblValorP = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(101, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(238, 29);
            this.lblTitulo.TabIndex = 66;
            this.lblTitulo.Text = "Actualizar Producto";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(236, 210);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 65;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(119, 210);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(90, 35);
            this.btnActualizar.TabIndex = 64;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtValorP
            // 
            this.txtValorP.Location = new System.Drawing.Point(168, 155);
            this.txtValorP.Name = "txtValorP";
            this.txtValorP.Size = new System.Drawing.Size(171, 22);
            this.txtValorP.TabIndex = 63;
            // 
            // lblValorP
            // 
            this.lblValorP.AutoSize = true;
            this.lblValorP.Location = new System.Drawing.Point(44, 161);
            this.lblValorP.Name = "lblValorP";
            this.lblValorP.Size = new System.Drawing.Size(118, 16);
            this.lblValorP.TabIndex = 62;
            this.lblValorP.Text = "Valor del Producto";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(168, 127);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(171, 22);
            this.txtNombreP.TabIndex = 61;
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(25, 133);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(137, 16);
            this.lblNombreP.TabIndex = 60;
            this.lblNombreP.Text = "Nombre Del Producto";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(168, 99);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(171, 22);
            this.txtID.TabIndex = 59;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(142, 105);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(20, 16);
            this.lblID.TabIndex = 58;
            this.lblID.Text = "ID";
            // 
            // fmrActualizarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 326);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtValorP);
            this.Controls.Add(this.lblValorP);
            this.Controls.Add(this.txtNombreP);
            this.Controls.Add(this.lblNombreP);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblID);
            this.Name = "fmrActualizarProducto";
            this.Text = "Actualizar Producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox txtValorP;
        private System.Windows.Forms.Label lblValorP;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}