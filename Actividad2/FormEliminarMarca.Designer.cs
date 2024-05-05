namespace WindowsForms
{
    partial class FormEliminarMarca
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
            this.labelID = new System.Windows.Forms.Label();
            this.labelTituloMarca = new System.Windows.Forms.Label();
            this.comboboxMarca = new System.Windows.Forms.ComboBox();
            this.lblDescripcionCategoria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.btnAtrasListaMarca = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(361, 187);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(23, 16);
            this.labelID.TabIndex = 40;
            this.labelID.Text = "ID:";
            // 
            // labelTituloMarca
            // 
            this.labelTituloMarca.AutoSize = true;
            this.labelTituloMarca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTituloMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloMarca.Location = new System.Drawing.Point(404, 95);
            this.labelTituloMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloMarca.Name = "labelTituloMarca";
            this.labelTituloMarca.Size = new System.Drawing.Size(157, 27);
            this.labelTituloMarca.TabIndex = 39;
            this.labelTituloMarca.Text = "Eliminar Marca";
            // 
            // comboboxMarca
            // 
            this.comboboxMarca.FormattingEnabled = true;
            this.comboboxMarca.Location = new System.Drawing.Point(404, 186);
            this.comboboxMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboboxMarca.Name = "comboboxMarca";
            this.comboboxMarca.Size = new System.Drawing.Size(220, 24);
            this.comboboxMarca.TabIndex = 44;
            // 
            // lblDescripcionCategoria
            // 
            this.lblDescripcionCategoria.AutoSize = true;
            this.lblDescripcionCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDescripcionCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionCategoria.Location = new System.Drawing.Point(457, 236);
            this.lblDescripcionCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcionCategoria.Name = "lblDescripcionCategoria";
            this.lblDescripcionCategoria.Size = new System.Drawing.Size(129, 13);
            this.lblDescripcionCategoria.TabIndex = 54;
            this.lblDescripcionCategoria.Text = "aca va la descripcion";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(361, 236);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(82, 16);
            this.lblDescripcion.TabIndex = 53;
            this.lblDescripcion.Text = "Descripcion:";
            // 
            // btnAtrasListaMarca
            // 
            this.btnAtrasListaMarca.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtrasListaMarca.Image = global::Actividad2.Properties.Resources.icons8_atrás_161;
            this.btnAtrasListaMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasListaMarca.Location = new System.Drawing.Point(55, 480);
            this.btnAtrasListaMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAtrasListaMarca.Name = "btnAtrasListaMarca";
            this.btnAtrasListaMarca.Size = new System.Drawing.Size(79, 39);
            this.btnAtrasListaMarca.TabIndex = 43;
            this.btnAtrasListaMarca.Text = "Atras";
            this.btnAtrasListaMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtrasListaMarca.UseVisualStyleBackColor = true;
            this.btnAtrasListaMarca.Click += new System.EventHandler(this.btnAtrasListaMarca_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = global::Actividad2.Properties.Resources.multiply;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(451, 314);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(107, 39);
            this.btnEliminar.TabIndex = 42;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormEliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblDescripcionCategoria);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.comboboxMarca);
            this.Controls.Add(this.btnAtrasListaMarca);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelTituloMarca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormEliminarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar marca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelTituloMarca;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAtrasListaMarca;
        private System.Windows.Forms.ComboBox comboboxMarca;
        private System.Windows.Forms.Label lblDescripcionCategoria;
        private System.Windows.Forms.Label lblDescripcion;
    }
}