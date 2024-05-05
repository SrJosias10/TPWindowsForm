namespace WindowsForms
{
    partial class FormModificarCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarCategoria));
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxCategoriaMod = new System.Windows.Forms.ComboBox();
            this.labelIDActual = new System.Windows.Forms.Label();
            this.labelDescripcionActual = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Image = global::Actividad2.Properties.Resources.multiply1;
            this.buttonCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCancelar.Location = new System.Drawing.Point(474, 370);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(79, 40);
            this.buttonCancelar.TabIndex = 62;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Image = ((System.Drawing.Image)(resources.GetObject("buttonAgregar.Image")));
            this.buttonAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAgregar.Location = new System.Drawing.Point(234, 370);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(79, 40);
            this.buttonAgregar.TabIndex = 61;
            this.buttonAgregar.Text = "   Agregar";
            this.buttonAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(202, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(216, 18);
            this.label7.TabIndex = 80;
            this.label7.Text = "Id de la categoria a modificar:";
            // 
            // comboBoxCategoriaMod
            // 
            this.comboBoxCategoriaMod.FormattingEnabled = true;
            this.comboBoxCategoriaMod.Location = new System.Drawing.Point(428, 80);
            this.comboBoxCategoriaMod.Name = "comboBoxCategoriaMod";
            this.comboBoxCategoriaMod.Size = new System.Drawing.Size(143, 21);
            this.comboBoxCategoriaMod.TabIndex = 79;
            // 
            // labelIDActual
            // 
            this.labelIDActual.AutoSize = true;
            this.labelIDActual.BackColor = System.Drawing.Color.Silver;
            this.labelIDActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelIDActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIDActual.Location = new System.Drawing.Point(162, 183);
            this.labelIDActual.Name = "labelIDActual";
            this.labelIDActual.Size = new System.Drawing.Size(71, 18);
            this.labelIDActual.TabIndex = 77;
            this.labelIDActual.Text = "\"ID actual\"";
            // 
            // labelDescripcionActual
            // 
            this.labelDescripcionActual.AutoSize = true;
            this.labelDescripcionActual.BackColor = System.Drawing.Color.Silver;
            this.labelDescripcionActual.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDescripcionActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcionActual.Location = new System.Drawing.Point(162, 254);
            this.labelDescripcionActual.Name = "labelDescripcionActual";
            this.labelDescripcionActual.Size = new System.Drawing.Size(130, 18);
            this.labelDescripcionActual.TabIndex = 78;
            this.labelDescripcionActual.Text = "\"Descripcion actual\"";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(518, 184);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(121, 20);
            this.textBoxID.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(385, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 16);
            this.label6.TabIndex = 75;
            this.label6.Text = "Nueva descripcion:";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(518, 254);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(121, 20);
            this.textBoxDescripcion.TabIndex = 74;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(385, 185);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(66, 16);
            this.labelNombre.TabIndex = 73;
            this.labelNombre.Text = "Nuevo ID:";
            // 
            // FormModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxCategoriaMod);
            this.Controls.Add(this.labelIDActual);
            this.Controls.Add(this.labelDescripcionActual);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxDescripcion);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAgregar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormModificarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar categoria";
            this.Load += new System.EventHandler(this.FormModificarCategoria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxCategoriaMod;
        private System.Windows.Forms.Label labelIDActual;
        private System.Windows.Forms.Label labelDescripcionActual;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Label labelNombre;
    }
}