namespace ObligatorioProgramacionII.Vista
{
    partial class PanelListaPeliculas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.filtroAnioActivo = new System.Windows.Forms.CheckBox();
            this.filtroAnio = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_filtrado = new System.Windows.Forms.Label();
            this.Combo_ListaGenero = new System.Windows.Forms.ComboBox();
            this.tablaPelicula = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtroAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPelicula)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.filtroAnioActivo);
            this.panel1.Controls.Add(this.filtroAnio);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lbl_filtrado);
            this.panel1.Controls.Add(this.Combo_ListaGenero);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // filtroAnioActivo
            // 
            this.filtroAnioActivo.AutoSize = true;
            this.filtroAnioActivo.Location = new System.Drawing.Point(542, 55);
            this.filtroAnioActivo.Name = "filtroAnioActivo";
            this.filtroAnioActivo.Size = new System.Drawing.Size(15, 14);
            this.filtroAnioActivo.TabIndex = 16;
            this.filtroAnioActivo.UseVisualStyleBackColor = true;
            this.filtroAnioActivo.CheckedChanged += new System.EventHandler(this.filtroAnioActivo_CheckedChanged);
            // 
            // filtroAnio
            // 
            this.filtroAnio.Location = new System.Drawing.Point(478, 52);
            this.filtroAnio.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.filtroAnio.Name = "filtroAnio";
            this.filtroAnio.Size = new System.Drawing.Size(58, 20);
            this.filtroAnio.TabIndex = 15;
            this.filtroAnio.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.filtroAnio.ValueChanged += new System.EventHandler(this.filtroAnio_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(446, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Año";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Genero";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Lista de películas";
            // 
            // lbl_filtrado
            // 
            this.lbl_filtrado.AutoEllipsis = true;
            this.lbl_filtrado.AutoSize = true;
            this.lbl_filtrado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filtrado.Location = new System.Drawing.Point(31, 53);
            this.lbl_filtrado.Name = "lbl_filtrado";
            this.lbl_filtrado.Size = new System.Drawing.Size(97, 16);
            this.lbl_filtrado.TabIndex = 11;
            this.lbl_filtrado.Text = "Filtrar películas";
            // 
            // Combo_ListaGenero
            // 
            this.Combo_ListaGenero.FormattingEnabled = true;
            this.Combo_ListaGenero.Items.AddRange(new object[] {
            "Todos",
            "Comedia",
            "Drama",
            "Acción",
            "Suspenso",
            "Terror",
            "Ciencia ficción ",
            "Fantasía",
            "Musical",
            "Romance",
            "Policíaco",
            "Animación",
            "Documental",
            "Aventura"});
            this.Combo_ListaGenero.Location = new System.Drawing.Point(220, 52);
            this.Combo_ListaGenero.Name = "Combo_ListaGenero";
            this.Combo_ListaGenero.Size = new System.Drawing.Size(116, 21);
            this.Combo_ListaGenero.TabIndex = 9;
            this.Combo_ListaGenero.Text = "Todos";
            this.Combo_ListaGenero.SelectedIndexChanged += new System.EventHandler(this.Combo_ListaGenero_SelectedIndexChanged);
            // 
            // tablaPelicula
            // 
            this.tablaPelicula.AllowUserToAddRows = false;
            this.tablaPelicula.AllowUserToDeleteRows = false;
            this.tablaPelicula.AllowUserToResizeColumns = false;
            this.tablaPelicula.AllowUserToResizeRows = false;
            this.tablaPelicula.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablaPelicula.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaPelicula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPelicula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.titulo,
            this.anio,
            this.genero,
            this.duracion});
            this.tablaPelicula.Location = new System.Drawing.Point(0, 81);
            this.tablaPelicula.MultiSelect = false;
            this.tablaPelicula.Name = "tablaPelicula";
            this.tablaPelicula.ReadOnly = true;
            this.tablaPelicula.RowHeadersVisible = false;
            this.tablaPelicula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaPelicula.Size = new System.Drawing.Size(800, 371);
            this.tablaPelicula.TabIndex = 1;
            this.tablaPelicula.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPelicula_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // titulo
            // 
            this.titulo.HeaderText = "Título";
            this.titulo.Name = "titulo";
            this.titulo.ReadOnly = true;
            this.titulo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // anio
            // 
            this.anio.HeaderText = "Año";
            this.anio.Name = "anio";
            this.anio.ReadOnly = true;
            this.anio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // genero
            // 
            this.genero.HeaderText = "Género";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // duracion
            // 
            this.duracion.HeaderText = "Duración";
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            this.duracion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PanelListaPeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tablaPelicula);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelListaPeliculas";
            this.Text = "tablaPeliculas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filtroAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPelicula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_filtrado;
        private System.Windows.Forms.ComboBox Combo_ListaGenero;
        private System.Windows.Forms.DataGridView tablaPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown filtroAnio;
        private System.Windows.Forms.CheckBox filtroAnioActivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn anio;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
    }
}