namespace WindowsForms
{
    partial class FormEliminarArticulo
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelTituloMarca = new System.Windows.Forms.Label();
            this.comboboxArticulo = new System.Windows.Forms.ComboBox();
            this.btnAtrasListaMarca = new System.Windows.Forms.Button();
            this.btneliminarArticulo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(126, 184);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(23, 16);
            this.labelNombre.TabIndex = 45;
            this.labelNombre.Text = "ID:";
            // 
            // labelTituloMarca
            // 
            this.labelTituloMarca.AutoSize = true;
            this.labelTituloMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTituloMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloMarca.Location = new System.Drawing.Point(119, 67);
            this.labelTituloMarca.Name = "labelTituloMarca";
            this.labelTituloMarca.Size = new System.Drawing.Size(169, 27);
            this.labelTituloMarca.TabIndex = 44;
            this.labelTituloMarca.Text = "Eliminar Articulo";
            // 
            // comboboxArticulo
            // 
            this.comboboxArticulo.FormattingEnabled = true;
            this.comboboxArticulo.Location = new System.Drawing.Point(155, 184);
            this.comboboxArticulo.Name = "comboboxArticulo";
            this.comboboxArticulo.Size = new System.Drawing.Size(121, 21);
            this.comboboxArticulo.TabIndex = 55;
            this.comboboxArticulo.SelectedIndexChanged += new System.EventHandler(this.comboboxArticulo_SelectedIndexChanged);
            // 
            // btnAtrasListaMarca
            // 
            this.btnAtrasListaMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtrasListaMarca.Image = global::Actividad2.Properties.Resources.icons8_atrás_161;
            this.btnAtrasListaMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasListaMarca.Location = new System.Drawing.Point(22, 384);
            this.btnAtrasListaMarca.Name = "btnAtrasListaMarca";
            this.btnAtrasListaMarca.Size = new System.Drawing.Size(59, 32);
            this.btnAtrasListaMarca.TabIndex = 48;
            this.btnAtrasListaMarca.Text = "Atras";
            this.btnAtrasListaMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtrasListaMarca.UseVisualStyleBackColor = true;
            this.btnAtrasListaMarca.Click += new System.EventHandler(this.btnAtrasListaMarca_Click);
            // 
            // btneliminarArticulo
            // 
            this.btneliminarArticulo.Image = global::Actividad2.Properties.Resources.multiply;
            this.btneliminarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminarArticulo.Location = new System.Drawing.Point(155, 267);
            this.btneliminarArticulo.Name = "btneliminarArticulo";
            this.btneliminarArticulo.Size = new System.Drawing.Size(80, 32);
            this.btneliminarArticulo.TabIndex = 47;
            this.btneliminarArticulo.Text = "Eliminar";
            this.btneliminarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btneliminarArticulo.UseVisualStyleBackColor = true;
            this.btneliminarArticulo.Click += new System.EventHandler(this.btneliminarArticulo_Click);
            // 
            // FormEliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 450);
            this.Controls.Add(this.comboboxArticulo);
            this.Controls.Add(this.btnAtrasListaMarca);
            this.Controls.Add(this.btneliminarArticulo);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelTituloMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEliminarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar articulo";
            this.Load += new System.EventHandler(this.FormEliminarArticulo_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtrasListaMarca;
        private System.Windows.Forms.Button btneliminarArticulo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelTituloMarca;
        private System.Windows.Forms.ComboBox comboboxArticulo;
    }
}