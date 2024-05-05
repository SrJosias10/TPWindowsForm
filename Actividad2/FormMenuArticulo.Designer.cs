using System;

namespace WindowsForms
{
    partial class FormMenuArticulo
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.btnAtrasMarcaMenuArticulo = new System.Windows.Forms.Button();
            this.BtnModificarArticulo = new System.Windows.Forms.Button();
            this.BtnBorrarArticulo = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lblTituloArticulos = new System.Windows.Forms.Label();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.groupBoxFiltro = new System.Windows.Forms.GroupBox();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.textBoxFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.labelCampo = new System.Windows.Forms.Label();
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.comboBoxCriterio = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.groupBoxFiltro.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(109, 92);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(120, 20);
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Ingrese Nombre";
            // 
            // searchButton
            // 
            this.searchButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.searchButton.BackColor = System.Drawing.SystemColors.Control;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Image = global::Actividad2.Properties.Resources.lupa;
            this.searchButton.Location = new System.Drawing.Point(246, 91);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(23, 21);
            this.searchButton.TabIndex = 20;
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // btnAtrasMarcaMenuArticulo
            // 
            this.btnAtrasMarcaMenuArticulo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAtrasMarcaMenuArticulo.Image = global::Actividad2.Properties.Resources.icons8_atrás_161;
            this.btnAtrasMarcaMenuArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtrasMarcaMenuArticulo.Location = new System.Drawing.Point(15, 473);
            this.btnAtrasMarcaMenuArticulo.Name = "btnAtrasMarcaMenuArticulo";
            this.btnAtrasMarcaMenuArticulo.Size = new System.Drawing.Size(61, 42);
            this.btnAtrasMarcaMenuArticulo.TabIndex = 19;
            this.btnAtrasMarcaMenuArticulo.Text = "Atras";
            this.btnAtrasMarcaMenuArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtrasMarcaMenuArticulo.UseVisualStyleBackColor = true;
            this.btnAtrasMarcaMenuArticulo.Click += new System.EventHandler(this.btnAtrasMarcaMenuArticulo_Click);
            // 
            // BtnModificarArticulo
            // 
            this.BtnModificarArticulo.Image = global::Actividad2.Properties.Resources.icons8_modificar_16;
            this.BtnModificarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarArticulo.Location = new System.Drawing.Point(593, 34);
            this.BtnModificarArticulo.Name = "BtnModificarArticulo";
            this.BtnModificarArticulo.Size = new System.Drawing.Size(77, 37);
            this.BtnModificarArticulo.TabIndex = 18;
            this.BtnModificarArticulo.Text = "Modificar";
            this.BtnModificarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnModificarArticulo.UseVisualStyleBackColor = true;
            this.BtnModificarArticulo.Click += new System.EventHandler(this.BtnModificarArticulo_Click);
            // 
            // BtnBorrarArticulo
            // 
            this.BtnBorrarArticulo.Image = global::Actividad2.Properties.Resources.multiply;
            this.BtnBorrarArticulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnBorrarArticulo.Location = new System.Drawing.Point(676, 34);
            this.BtnBorrarArticulo.Name = "BtnBorrarArticulo";
            this.BtnBorrarArticulo.Size = new System.Drawing.Size(66, 37);
            this.BtnBorrarArticulo.TabIndex = 16;
            this.BtnBorrarArticulo.Text = "Borrar";
            this.BtnBorrarArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnBorrarArticulo.UseVisualStyleBackColor = true;
            this.BtnBorrarArticulo.Click += new System.EventHandler(this.BtnBorrarArticulo_Click_1);
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(15, 129);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(514, 265);
            this.dgvArticulos.TabIndex = 21;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // lblTituloArticulos
            // 
            this.lblTituloArticulos.AutoSize = true;
            this.lblTituloArticulos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloArticulos.Location = new System.Drawing.Point(12, 9);
            this.lblTituloArticulos.Name = "lblTituloArticulos";
            this.lblTituloArticulos.Size = new System.Drawing.Size(56, 13);
            this.lblTituloArticulos.TabIndex = 22;
            this.lblTituloArticulos.Text = "Articulos";
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(535, 129);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(253, 265);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 23;
            this.pbxArticulo.TabStop = false;
            this.pbxArticulo.Click += new System.EventHandler(this.pbxArticulo_Click);
            // 
            // groupBoxFiltro
            // 
            this.groupBoxFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxFiltro.Controls.Add(this.btnBusquedaAvanzada);
            this.groupBoxFiltro.Controls.Add(this.textBoxFiltroAvanzado);
            this.groupBoxFiltro.Controls.Add(this.labelCampo);
            this.groupBoxFiltro.Controls.Add(this.comboBoxCampo);
            this.groupBoxFiltro.Controls.Add(this.comboBoxCriterio);
            this.groupBoxFiltro.Location = new System.Drawing.Point(310, 77);
            this.groupBoxFiltro.Name = "groupBoxFiltro";
            this.groupBoxFiltro.Size = new System.Drawing.Size(478, 46);
            this.groupBoxFiltro.TabIndex = 60;
            this.groupBoxFiltro.TabStop = false;
            this.groupBoxFiltro.Text = "Filtro Avanzado";
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBusquedaAvanzada.BackColor = System.Drawing.SystemColors.Control;
            this.btnBusquedaAvanzada.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBusquedaAvanzada.Image = global::Actividad2.Properties.Resources.lupa;
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(439, 13);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(23, 21);
            this.btnBusquedaAvanzada.TabIndex = 58;
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = false;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFiltroAvanzado
            // 
            this.textBoxFiltroAvanzado.Location = new System.Drawing.Point(327, 13);
            this.textBoxFiltroAvanzado.Name = "textBoxFiltroAvanzado";
            this.textBoxFiltroAvanzado.Size = new System.Drawing.Size(96, 20);
            this.textBoxFiltroAvanzado.TabIndex = 57;
            // 
            // labelCampo
            // 
            this.labelCampo.AutoSize = true;
            this.labelCampo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCampo.Location = new System.Drawing.Point(16, 15);
            this.labelCampo.Name = "labelCampo";
            this.labelCampo.Size = new System.Drawing.Size(51, 16);
            this.labelCampo.TabIndex = 56;
            this.labelCampo.Text = "Campo";
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(73, 13);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampo.TabIndex = 55;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged_1);
            // 
            // comboBoxCriterio
            // 
            this.comboBoxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCriterio.FormattingEnabled = true;
            this.comboBoxCriterio.Location = new System.Drawing.Point(200, 13);
            this.comboBoxCriterio.Name = "comboBoxCriterio";
            this.comboBoxCriterio.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCriterio.TabIndex = 54;
            // 
            // FormMenuArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.groupBoxFiltro);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.lblTituloArticulos);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.btnAtrasMarcaMenuArticulo);
            this.Controls.Add(this.BtnModificarArticulo);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.BtnBorrarArticulo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenuArticulo";
            this.Text = "MenuArticulo";
            this.Load += new System.EventHandler(this.FormMenuArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.groupBoxFiltro.ResumeLayout(false);
            this.groupBoxFiltro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnAtrasListaArticulo_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button BtnModificarArticulo;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button BtnBorrarArticulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtrasMarcaMenuArticulo;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Label lblTituloArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.GroupBox groupBoxFiltro;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.TextBox textBoxFiltroAvanzado;
        private System.Windows.Forms.Label labelCampo;
        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.ComboBox comboBoxCriterio;
    }
}