namespace ObligatorioProgramacionII
{
    partial class VentanaPrincipal
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

        public void cargarPeliculas()
        {
            
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.Menu = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerActores = new System.Windows.Forms.Button();
            this.btnVerPeliculas = new System.Windows.Forms.Button();
            this.iframe = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.iframeCRUDPeliculaActores = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.crudAnioPelicula = new System.Windows.Forms.NumericUpDown();
            this.crudTiempoPelicula = new System.Windows.Forms.DateTimePicker();
            this.iframeCRUDListaPelicula = new System.Windows.Forms.Panel();
            this.CrudGeneroPelicula = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.crudTituloPelicula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar_Pelicula = new System.Windows.Forms.Button();
            this.btnModificar_Pelicula = new System.Windows.Forms.Button();
            this.btnAgregar_Pelicula = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.iframeCRUDActorPeliculas = new System.Windows.Forms.Panel();
            this.iframeCRUDListaActores = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.crudApellidoActor = new System.Windows.Forms.TextBox();
            this.crudNombreActor = new System.Windows.Forms.TextBox();
            this.crudNacimientoActor = new System.Windows.Forms.DateTimePicker();
            this.crudNacionalidadActor = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAsignarPelicula = new System.Windows.Forms.Button();
            this.btnEliminar_Actor = new System.Windows.Forms.Button();
            this.btnModificar_Actor = new System.Windows.Forms.Button();
            this.btnAgregar_Actor = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crudAnioPelicula)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Controls.Add(this.tabPage1);
            this.Menu.Controls.Add(this.tabPage2);
            this.Menu.Controls.Add(this.tabPage3);
            this.Menu.Location = new System.Drawing.Point(1, 1);
            this.Menu.Name = "Menu";
            this.Menu.SelectedIndex = 0;
            this.Menu.Size = new System.Drawing.Size(1244, 577);
            this.Menu.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel5);
            this.tabPage1.Controls.Add(this.iframe);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1236, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ver listados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.btnVerActores);
            this.panel5.Controls.Add(this.btnVerPeliculas);
            this.panel5.Location = new System.Drawing.Point(0, 6);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 441);
            this.panel5.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ObligatorioProgramacionII.Properties.Resources.logoterminado;
            this.pictureBox1.Location = new System.Drawing.Point(6, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnVerActores
            // 
            this.btnVerActores.Location = new System.Drawing.Point(6, 96);
            this.btnVerActores.Name = "btnVerActores";
            this.btnVerActores.Size = new System.Drawing.Size(161, 41);
            this.btnVerActores.TabIndex = 1;
            this.btnVerActores.TabStop = false;
            this.btnVerActores.Text = "Actores";
            this.btnVerActores.UseVisualStyleBackColor = true;
            this.btnVerActores.Click += new System.EventHandler(this.btnVerActores_Click);
            // 
            // btnVerPeliculas
            // 
            this.btnVerPeliculas.Location = new System.Drawing.Point(6, 49);
            this.btnVerPeliculas.Name = "btnVerPeliculas";
            this.btnVerPeliculas.Size = new System.Drawing.Size(161, 41);
            this.btnVerPeliculas.TabIndex = 0;
            this.btnVerPeliculas.Text = "Películas";
            this.btnVerPeliculas.UseVisualStyleBackColor = true;
            this.btnVerPeliculas.Click += new System.EventHandler(this.btnVerPeliculas_Click);
            // 
            // iframe
            // 
            this.iframe.Location = new System.Drawing.Point(179, 6);
            this.iframe.Name = "iframe";
            this.iframe.Size = new System.Drawing.Size(1051, 545);
            this.iframe.TabIndex = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.iframeCRUDPeliculaActores);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.crudAnioPelicula);
            this.tabPage2.Controls.Add(this.crudTiempoPelicula);
            this.tabPage2.Controls.Add(this.iframeCRUDListaPelicula);
            this.tabPage2.Controls.Add(this.CrudGeneroPelicula);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.crudTituloPelicula);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1236, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crud de Peliculas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // iframeCRUDPeliculaActores
            // 
            this.iframeCRUDPeliculaActores.Location = new System.Drawing.Point(164, 346);
            this.iframeCRUDPeliculaActores.Name = "iframeCRUDPeliculaActores";
            this.iframeCRUDPeliculaActores.Size = new System.Drawing.Size(1066, 202);
            this.iframeCRUDPeliculaActores.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Título";
            // 
            // crudAnioPelicula
            // 
            this.crudAnioPelicula.Location = new System.Drawing.Point(294, 79);
            this.crudAnioPelicula.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.crudAnioPelicula.Name = "crudAnioPelicula";
            this.crudAnioPelicula.Size = new System.Drawing.Size(69, 20);
            this.crudAnioPelicula.TabIndex = 1;
            this.crudAnioPelicula.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // crudTiempoPelicula
            // 
            this.crudTiempoPelicula.CustomFormat = "hh:mm:ss";
            this.crudTiempoPelicula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.crudTiempoPelicula.Location = new System.Drawing.Point(294, 140);
            this.crudTiempoPelicula.Name = "crudTiempoPelicula";
            this.crudTiempoPelicula.ShowUpDown = true;
            this.crudTiempoPelicula.Size = new System.Drawing.Size(69, 20);
            this.crudTiempoPelicula.TabIndex = 3;
            this.crudTiempoPelicula.Value = new System.DateTime(2023, 11, 7, 0, 0, 0, 0);
            // 
            // iframeCRUDListaPelicula
            // 
            this.iframeCRUDListaPelicula.Location = new System.Drawing.Point(486, 47);
            this.iframeCRUDListaPelicula.Name = "iframeCRUDListaPelicula";
            this.iframeCRUDListaPelicula.Size = new System.Drawing.Size(744, 270);
            this.iframeCRUDListaPelicula.TabIndex = 15;
            // 
            // CrudGeneroPelicula
            // 
            this.CrudGeneroPelicula.FormattingEnabled = true;
            this.CrudGeneroPelicula.Items.AddRange(new object[] {
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
            this.CrudGeneroPelicula.Location = new System.Drawing.Point(294, 110);
            this.CrudGeneroPelicula.Name = "CrudGeneroPelicula";
            this.CrudGeneroPelicula.Size = new System.Drawing.Size(176, 21);
            this.CrudGeneroPelicula.TabIndex = 2;
            this.CrudGeneroPelicula.Text = "Seleccionar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(623, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Actores que participan : ";
            // 
            // crudTituloPelicula
            // 
            this.crudTituloPelicula.Location = new System.Drawing.Point(294, 47);
            this.crudTituloPelicula.MaxLength = 30;
            this.crudTituloPelicula.Name = "crudTituloPelicula";
            this.crudTituloPelicula.Size = new System.Drawing.Size(176, 20);
            this.crudTituloPelicula.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Duración";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(160, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Género";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(160, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Año de estreno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(623, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Crud de Películas";
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.btnEliminar_Pelicula);
            this.panel1.Controls.Add(this.btnModificar_Pelicula);
            this.panel1.Controls.Add(this.btnAgregar_Pelicula);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 516);
            this.panel1.TabIndex = 1;
            // 
            // btnEliminar_Pelicula
            // 
            this.btnEliminar_Pelicula.Location = new System.Drawing.Point(3, 190);
            this.btnEliminar_Pelicula.Name = "btnEliminar_Pelicula";
            this.btnEliminar_Pelicula.Size = new System.Drawing.Size(147, 37);
            this.btnEliminar_Pelicula.TabIndex = 6;
            this.btnEliminar_Pelicula.Text = "Eliminar";
            this.btnEliminar_Pelicula.UseVisualStyleBackColor = true;
            this.btnEliminar_Pelicula.Click += new System.EventHandler(this.btnEliminar_Pelicula_Click);
            // 
            // btnModificar_Pelicula
            // 
            this.btnModificar_Pelicula.Location = new System.Drawing.Point(3, 129);
            this.btnModificar_Pelicula.Name = "btnModificar_Pelicula";
            this.btnModificar_Pelicula.Size = new System.Drawing.Size(147, 37);
            this.btnModificar_Pelicula.TabIndex = 5;
            this.btnModificar_Pelicula.Text = "Modificar";
            this.btnModificar_Pelicula.UseVisualStyleBackColor = true;
            this.btnModificar_Pelicula.Click += new System.EventHandler(this.btnModificar_Pelicula_Click);
            // 
            // btnAgregar_Pelicula
            // 
            this.btnAgregar_Pelicula.Location = new System.Drawing.Point(3, 74);
            this.btnAgregar_Pelicula.Name = "btnAgregar_Pelicula";
            this.btnAgregar_Pelicula.Size = new System.Drawing.Size(147, 36);
            this.btnAgregar_Pelicula.TabIndex = 4;
            this.btnAgregar_Pelicula.Text = "Agregar";
            this.btnAgregar_Pelicula.UseVisualStyleBackColor = true;
            this.btnAgregar_Pelicula.Click += new System.EventHandler(this.btnAgregar_Pelicula_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.iframeCRUDActorPeliculas);
            this.tabPage3.Controls.Add(this.iframeCRUDListaActores);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.crudApellidoActor);
            this.tabPage3.Controls.Add(this.crudNombreActor);
            this.tabPage3.Controls.Add(this.crudNacimientoActor);
            this.tabPage3.Controls.Add(this.crudNacionalidadActor);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1236, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Crud de Actores";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // iframeCRUDActorPeliculas
            // 
            this.iframeCRUDActorPeliculas.Location = new System.Drawing.Point(164, 349);
            this.iframeCRUDActorPeliculas.Name = "iframeCRUDActorPeliculas";
            this.iframeCRUDActorPeliculas.Size = new System.Drawing.Size(1066, 202);
            this.iframeCRUDActorPeliculas.TabIndex = 25;
            // 
            // iframeCRUDListaActores
            // 
            this.iframeCRUDListaActores.Location = new System.Drawing.Point(492, 53);
            this.iframeCRUDListaActores.Name = "iframeCRUDListaActores";
            this.iframeCRUDListaActores.Size = new System.Drawing.Size(744, 270);
            this.iframeCRUDListaActores.TabIndex = 24;
            this.iframeCRUDListaActores.UseWaitCursor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(613, 326);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(192, 20);
            this.label13.TabIndex = 23;
            this.label13.Text = "Películas en las que actúa";
            // 
            // crudApellidoActor
            // 
            this.crudApellidoActor.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.crudApellidoActor.Location = new System.Drawing.Point(269, 81);
            this.crudApellidoActor.MaxLength = 30;
            this.crudApellidoActor.Name = "crudApellidoActor";
            this.crudApellidoActor.Size = new System.Drawing.Size(184, 20);
            this.crudApellidoActor.TabIndex = 1;
            // 
            // crudNombreActor
            // 
            this.crudNombreActor.Location = new System.Drawing.Point(269, 51);
            this.crudNombreActor.MaxLength = 30;
            this.crudNombreActor.Name = "crudNombreActor";
            this.crudNombreActor.Size = new System.Drawing.Size(184, 20);
            this.crudNombreActor.TabIndex = 0;
            // 
            // crudNacimientoActor
            // 
            this.crudNacimientoActor.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.crudNacimientoActor.Location = new System.Drawing.Point(269, 113);
            this.crudNacimientoActor.Name = "crudNacimientoActor";
            this.crudNacimientoActor.Size = new System.Drawing.Size(85, 20);
            this.crudNacimientoActor.TabIndex = 2;
            // 
            // crudNacionalidadActor
            // 
            this.crudNacionalidadActor.FormattingEnabled = true;
            this.crudNacionalidadActor.Items.AddRange(new object[] {
            "Estados Unidos",
            "Canadá",
            "Reino Unido",
            "Australia",
            "India",
            "Alemania",
            "Francia",
            "España",
            "Italia",
            "México",
            "Brasil",
            "China",
            "Japón",
            "Corea del Sur",
            "Rusia",
            "Sudáfrica",
            "Argentina",
            "Chile",
            "Colombia",
            "Perú",
            "Uruguay"});
            this.crudNacionalidadActor.Location = new System.Drawing.Point(269, 144);
            this.crudNacionalidadActor.Name = "crudNacionalidadActor";
            this.crudNacionalidadActor.Size = new System.Drawing.Size(184, 21);
            this.crudNacionalidadActor.TabIndex = 3;
            this.crudNacionalidadActor.Text = "Seleccionar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(162, 144);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(93, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Nacionalidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(162, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 18);
            this.label11.TabIndex = 17;
            this.label11.Text = "Nacimiento";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(162, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 18);
            this.label10.TabIndex = 16;
            this.label10.Text = "Apellido";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(162, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(613, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Crud de Actores";
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.btnAsignarPelicula);
            this.panel2.Controls.Add(this.btnEliminar_Actor);
            this.panel2.Controls.Add(this.btnModificar_Actor);
            this.panel2.Controls.Add(this.btnAgregar_Actor);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(156, 516);
            this.panel2.TabIndex = 2;
            // 
            // btnAsignarPelicula
            // 
            this.btnAsignarPelicula.Location = new System.Drawing.Point(3, 255);
            this.btnAsignarPelicula.Name = "btnAsignarPelicula";
            this.btnAsignarPelicula.Size = new System.Drawing.Size(147, 36);
            this.btnAsignarPelicula.TabIndex = 8;
            this.btnAsignarPelicula.Text = "Asignar Película";
            this.btnAsignarPelicula.UseVisualStyleBackColor = true;
            this.btnAsignarPelicula.Click += new System.EventHandler(this.btnAsignarPelicula_Click);
            // 
            // btnEliminar_Actor
            // 
            this.btnEliminar_Actor.Location = new System.Drawing.Point(3, 190);
            this.btnEliminar_Actor.Name = "btnEliminar_Actor";
            this.btnEliminar_Actor.Size = new System.Drawing.Size(147, 37);
            this.btnEliminar_Actor.TabIndex = 6;
            this.btnEliminar_Actor.Text = "Eliminar";
            this.btnEliminar_Actor.UseVisualStyleBackColor = true;
            this.btnEliminar_Actor.Click += new System.EventHandler(this.btnEliminar_Actor_Click);
            // 
            // btnModificar_Actor
            // 
            this.btnModificar_Actor.Location = new System.Drawing.Point(3, 129);
            this.btnModificar_Actor.Name = "btnModificar_Actor";
            this.btnModificar_Actor.Size = new System.Drawing.Size(147, 37);
            this.btnModificar_Actor.TabIndex = 5;
            this.btnModificar_Actor.Text = "Modificar";
            this.btnModificar_Actor.UseVisualStyleBackColor = true;
            this.btnModificar_Actor.Click += new System.EventHandler(this.btnModificar_Actor_Click);
            // 
            // btnAgregar_Actor
            // 
            this.btnAgregar_Actor.Location = new System.Drawing.Point(3, 74);
            this.btnAgregar_Actor.Name = "btnAgregar_Actor";
            this.btnAgregar_Actor.Size = new System.Drawing.Size(147, 36);
            this.btnAgregar_Actor.TabIndex = 4;
            this.btnAgregar_Actor.Text = "Agregar";
            this.btnAgregar_Actor.UseVisualStyleBackColor = true;
            this.btnAgregar_Actor.Click += new System.EventHandler(this.btnAgregar_Actor_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 576);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.Name = "VentanaPrincipal";
            this.Text = "CRUD de Películas";
            this.Menu.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crudAnioPelicula)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Menu;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEliminar_Actor;
        private System.Windows.Forms.Button btnModificar_Actor;
        private System.Windows.Forms.Button btnAgregar_Actor;
        private System.Windows.Forms.ComboBox crudNacionalidadActor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox crudApellidoActor;
        private System.Windows.Forms.TextBox crudNombreActor;
        private System.Windows.Forms.DateTimePicker crudNacimientoActor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnVerActores;
        private System.Windows.Forms.Button btnVerPeliculas;
        private System.Windows.Forms.Panel iframe;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox CrudGeneroPelicula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox crudTituloPelicula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEliminar_Pelicula;
        private System.Windows.Forms.Button btnModificar_Pelicula;
        private System.Windows.Forms.Button btnAgregar_Pelicula;
        private System.Windows.Forms.DateTimePicker crudTiempoPelicula;
        private System.Windows.Forms.NumericUpDown crudAnioPelicula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel iframeCRUDPeliculaActores;
        private System.Windows.Forms.Panel iframeCRUDListaPelicula;
        private System.Windows.Forms.Panel iframeCRUDActorPeliculas;
        private System.Windows.Forms.Panel iframeCRUDListaActores;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAsignarPelicula;
    }

   
}

