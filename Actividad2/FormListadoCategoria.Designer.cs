namespace WindowsForms
{
    partial class FormListadoCategoria
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
            this.lblBusquedaCategorias = new System.Windows.Forms.Label();
            this.txtBusquedaCategorias = new System.Windows.Forms.TextBox();
            this.btnAtrasListaCat = new System.Windows.Forms.Button();
            this.btnBorrarCategoria = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.lblTituloCategoria = new System.Windows.Forms.Label();
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBusquedaCategorias
            // 
            this.lblBusquedaCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBusquedaCategorias.AutoSize = true;
            this.lblBusquedaCategorias.Location = new System.Drawing.Point(50, 36);
            this.lblBusquedaCategorias.Name = "lblBusquedaCategorias";
            this.lblBusquedaCategorias.Size = new System.Drawing.Size(40, 13);
            this.lblBusquedaCategorias.TabIndex = 21;
            this.lblBusquedaCategorias.Text = "Buscar";
            // 
            // txtBusquedaCategorias
            // 
            this.txtBusquedaCategorias.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBusquedaCategorias.BackColor = System.Drawing.Color.White;
            this.txtBusquedaCategorias.Location = new System.Drawing.Point(111, 32);
            this.txtBusquedaCategorias.MaxLength = 500;
            this.txtBusquedaCategorias.Name = "txtBusquedaCategorias";
            this.txtBusquedaCategorias.Size = new System.Drawing.Size(236, 20);
            this.txtBusquedaCategorias.TabIndex = 19;
            this.txtBusquedaCategorias.TextChanged += new System.EventHandler(this.txtBusquedaCategorias_TextChanged_1);
            // 
            // btnAtrasListaCat
            // 
            this.btnAtrasListaCat.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtrasListaCat.Image = global::Actividad2.Properties.Resources.icons8_atrás_161;
            this.btnAtrasListaCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasListaCat.Location = new System.Drawing.Point(53, 387);
            this.btnAtrasListaCat.Name = "btnAtrasListaCat";
            this.btnAtrasListaCat.Size = new System.Drawing.Size(59, 32);
            this.btnAtrasListaCat.TabIndex = 23;
            this.btnAtrasListaCat.Text = "Atras";
            this.btnAtrasListaCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtrasListaCat.UseVisualStyleBackColor = true;
            this.btnAtrasListaCat.Click += new System.EventHandler(this.btnAtrasListaCat_Click);
            // 
            // btnBorrarCategoria
            // 
            this.btnBorrarCategoria.Image = global::Actividad2.Properties.Resources.multiply;
            this.btnBorrarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrarCategoria.Location = new System.Drawing.Point(692, 26);
            this.btnBorrarCategoria.Name = "btnBorrarCategoria";
            this.btnBorrarCategoria.Size = new System.Drawing.Size(59, 32);
            this.btnBorrarCategoria.TabIndex = 25;
            this.btnBorrarCategoria.Text = "Borrar";
            this.btnBorrarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrarCategoria.UseVisualStyleBackColor = true;
            this.btnBorrarCategoria.Click += new System.EventHandler(this.btnBorrarCategoria_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Image = global::Actividad2.Properties.Resources.icons8_modificar_16;
            this.btnModificarCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModificarCategoria.Location = new System.Drawing.Point(612, 26);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(74, 32);
            this.btnModificarCategoria.TabIndex = 24;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // lblTituloCategoria
            // 
            this.lblTituloCategoria.AutoSize = true;
            this.lblTituloCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloCategoria.Location = new System.Drawing.Point(2, 3);
            this.lblTituloCategoria.Name = "lblTituloCategoria";
            this.lblTituloCategoria.Size = new System.Drawing.Size(67, 13);
            this.lblTituloCategoria.TabIndex = 26;
            this.lblTituloCategoria.Text = "Categorias";
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(53, 93);
            this.dataGridViewCategorias.MultiSelect = false;
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCategorias.Size = new System.Drawing.Size(698, 259);
            this.dataGridViewCategorias.TabIndex = 27;
            // 
            // FormListadoCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewCategorias);
            this.Controls.Add(this.lblTituloCategoria);
            this.Controls.Add(this.btnBorrarCategoria);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnAtrasListaCat);
            this.Controls.Add(this.lblBusquedaCategorias);
            this.Controls.Add(this.txtBusquedaCategorias);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListadoCategoria";
            this.Text = "FormListarCategoria";
            this.Load += new System.EventHandler(this.FormListadoCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAtrasListaCat;
        private System.Windows.Forms.Label lblBusquedaCategorias;
        private System.Windows.Forms.TextBox txtBusquedaCategorias;
        private System.Windows.Forms.Button btnBorrarCategoria;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Label lblTituloCategoria;
        private System.Windows.Forms.DataGridView dataGridViewCategorias;
    }
}