using ObligatorioProgramacion.controller;
using ObligatorioProgramacion.model;
using ObligatorioProgramacionII.Vista;
using System;
using System.Globalization;
using System.Windows.Forms;


namespace ObligatorioProgramacionII{
    public partial class VentanaPrincipal : Form{
        PanelListaPeliculas panelListaPelicula;
        PanelListaActores panelListaActores;
        PanelListaPeliculas panelListaPeliculasCRUD;
        PanelListaActores panelListaActoresCRUDPelicula;
        Pelicula peliculaSeleccionada;
        PanelListaActores panelListaActoresCRUD;
        PanelListaPeliculas panelListaPeliculasCRUDActor;
        Actor actorSeleccionado;

        bool asignandoPeliculaActor=false;

        public VentanaPrincipal(){
            panelListaPelicula = new PanelListaPeliculas(this);
            panelListaPeliculasCRUD = new PanelListaPeliculas(this); //Lista peliculas CRUD
            panelListaActores = new PanelListaActores(this);
            peliculaSeleccionada = null;
            panelListaActoresCRUDPelicula = new PanelListaActores(this); //Lista actores segun la pelicula.
            panelListaActoresCRUD = new PanelListaActores(this); // Listado actores CRUD
            actorSeleccionado = null;
            panelListaPeliculasCRUDActor = new PanelListaPeliculas(this); //Lista peliculas segun el actor.


            InitializeComponent();

            panelListaPelicula.TopLevel = false;
            panelListaActores.TopLevel = false;
            panelListaPeliculasCRUD.TopLevel = false;
            panelListaActoresCRUDPelicula.TopLevel = false;
            panelListaActoresCRUD.TopLevel = false;
            panelListaPeliculasCRUDActor.TopLevel = false;

            iframeCRUDListaPelicula.Controls.Add(panelListaPeliculasCRUD); //Listado peliculas CRUD 
            panelListaPeliculasCRUD.Size = iframeCRUDListaPelicula.Size;

            iframeCRUDPeliculaActores.Controls.Add(panelListaActoresCRUDPelicula); // Lista actores según pelicula
            panelListaActoresCRUDPelicula.Size = iframeCRUDPeliculaActores.Size;

            iframeCRUDListaActores.Controls.Add(panelListaActoresCRUD); // Listado actores CRUD
            panelListaActoresCRUD.Size = iframeCRUDListaActores.Size;

            iframeCRUDActorPeliculas.Controls.Add(panelListaPeliculasCRUDActor); //Lista peliculas según actor
            panelListaPeliculasCRUDActor.Size = iframeCRUDActorPeliculas.Size;

            panelListaPelicula.Size = iframe.Size;

            panelListaActores.Size = iframe.Size;

            panelListaActoresCRUDPelicula.Show();
            panelListaPeliculasCRUD.Show();
            panelListaActoresCRUD.Show();
            panelListaPeliculasCRUDActor.Show();

            panelListaActoresCRUD.mostrarActores();
        }

        //PESTAÑA VER LISTADO (INICIO)
        private void btnVerPeliculas_Click(object sender, EventArgs e){
            iframe.Controls.Clear();
            iframe.Controls.Add(panelListaPelicula);
            panelListaPelicula.Show();
            panelListaActores.Hide();
        }
        private void btnVerActores_Click(object sender, EventArgs e){
            iframe.Controls.Clear();
            iframe.Controls.Add(panelListaActores);
            panelListaPelicula.Hide();
            panelListaActores.Show();
            panelListaActores.mostrarActores();
        }


        // PESTAÑAS CRUD

        #region CRUD PELÍCULAS

        public void setPeliculaSeleccionadaCRUD(Pelicula pelicula){
            int indicePestanaActual = Menu.SelectedIndex;
            switch(indicePestanaActual){
                case 0: // pestaña Listados
                    break;
                case 1: // pestaña Peliulas
                    crudTituloPelicula.Text = pelicula.Titulo;
                    crudAnioPelicula.Value = pelicula.Anio;
                    crudTiempoPelicula.Text = pelicula.Duracion.ToString(@"hh\:mm\:ss");
                    CrudGeneroPelicula.Text = pelicula.Genero;
                    peliculaSeleccionada = pelicula;
                    panelListaActoresCRUDPelicula.mostrarActoresPelicula(pelicula.Codigo);
                    break;
                case 2: // pestaña Actores
                    if (asignandoPeliculaActor){
                        asignarPeliculaActor(pelicula);
                    }
                    break;
            }
        }
       // Resetea los valores de los input y la seleccion de la pelicula
        public void clearPeliculaSeleccionadaCRUD(){
            crudTituloPelicula.Clear();
            crudAnioPelicula.Value = new DateTime(DateTime.Now.Year, 1, 1).Year; ;
            crudTiempoPelicula.Text = "00:00:00";
            CrudGeneroPelicula.Text = "";
            peliculaSeleccionada = null;
        }
       

        //MODIFICA PELICULA
        private void btnModificar_Pelicula_Click(object sender, EventArgs e){
            modificarPeliculaSeleccioanda();
        }
        private void modificarPeliculaSeleccioanda(){
            PeliculaController peliculaController = new PeliculaController();
            String titulo = crudTituloPelicula.Text;
            int anio = Convert.ToInt32(crudAnioPelicula.Value);
            TimeSpan duracion = TimeSpan.ParseExact(crudTiempoPelicula.Text, "hh\\:mm\\:ss", null);
            String genero = CrudGeneroPelicula.Text;
            Pelicula peliculaModificada = new Pelicula(peliculaSeleccionada.Codigo, titulo, anio, genero, duracion);
            if (peliculaSeleccionada != null){
                if (peliculaController.modificarPelicula(peliculaModificada)){
                    MessageBox.Show("Película modificada con éxito.");
                    clearPeliculaSeleccionadaCRUD();
                    panelListaPeliculasCRUD.refrescar();
                }else{
                    MessageBox.Show("Error al modificar la película.");
                }
            }else{
                MessageBox.Show("No se encuentra una película seleccionada.");
            }
        }


        //ELIMINA PELICULA
        private void eliminarPeliculaSeleccionada(){
            PeliculaController peliculaController = new PeliculaController();
            if (peliculaSeleccionada != null){
                if (peliculaController.eliminarPelicula(peliculaSeleccionada.Codigo)){
                    MessageBox.Show("Película eliminada con exito.");
                    clearPeliculaSeleccionadaCRUD();
                    panelListaPeliculasCRUD.refrescar();
                }else{
                    MessageBox.Show("Error al eliminar la película.");
                }
            }else{
                MessageBox.Show("No se encuentra una película seleccionada.");
            }
        }
        private void btnEliminar_Pelicula_Click(object sender, EventArgs e){
            eliminarPeliculaSeleccionada();
        }


        //AGREGAR PELICULA 
        private void crearPelicula(){
            PeliculaController peliculaController = new PeliculaController();
            String titulo = crudTituloPelicula.Text;
            int anio = Convert.ToInt32(crudAnioPelicula.Value);
            TimeSpan duracion = TimeSpan.ParseExact(crudTiempoPelicula.Text, "hh\\:mm\\:ss", null);
            String genero = CrudGeneroPelicula.Text;
            Pelicula peliculaNueva = new Pelicula(0, titulo, anio, genero, duracion);
            if (peliculaController.agregarPelicula(peliculaNueva)){
                MessageBox.Show("Película creada con éxito.");
                clearPeliculaSeleccionadaCRUD();
                panelListaPeliculasCRUD.refrescar();
            }else{
                MessageBox.Show("Error al crear la película.");
            }
        }
        private void btnAgregar_Pelicula_Click(object sender, EventArgs e){
            crearPelicula();
        }
        
        #endregion


        #region CRUD ACTORES
        public void setActorSeleccionadoCRUD(Actor actor){
            int indicePestanaActual = Menu.SelectedIndex;
            switch (indicePestanaActual){
                case 0: // pestaña Listados
                    break;
                case 1: // pestaña Peliulas
                    break;
                case 2: // pestaña Actores
                    crudNombreActor.Text = actor.Nombre;
                    crudApellidoActor.Text = actor.Apellido;
                    crudNacimientoActor.Text = actor.FechaDeNacimiento.ToString("yyyy-MM-dd");
                    crudNacionalidadActor.Text = actor.Nacionalidad;
                    actorSeleccionado = actor;
                    panelListaPeliculasCRUDActor.mostrarPeliculasActor(actor.NroActor);
                    break;
            }
        }
        public void clearActorSeleccionadoCRUD(){
            crudNombreActor.Clear();
            crudApellidoActor.Clear();
            crudNacimientoActor.Text = "";
            crudNacionalidadActor.Text = "Seleccionar";
            actorSeleccionado = null;
        }


        //MODIFICA ACTOR
        private void modificarActorSeleccionado(){
            ActorController actorController = new ActorController();
            String nombre = crudNombreActor.Text;
            String apellido = crudApellidoActor.Text;
            DateTime nacimiento = DateTime.ParseExact(crudNacimientoActor.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture); ;
            String nacionalidad = crudNacionalidadActor.Text;
            Actor actorModificado = new Actor(actorSeleccionado.NroActor, nombre, apellido, nacimiento, nacionalidad);
            if (actorSeleccionado != null){
                if (actorController.modificarActor(actorModificado)){
                    MessageBox.Show("Actor modificado con éxito.");
                    clearActorSeleccionadoCRUD();
                    panelListaActoresCRUD.mostrarActores();
                }else{
                    MessageBox.Show("Error al modificar el actor.");
                }
            }else{
                MessageBox.Show("No se encuentra un actor seleccionado.");
            }
        }
        private void btnModificar_Actor_Click(object sender, EventArgs e){
            modificarActorSeleccionado();
        }


        //AGREGA ACTOR 
        private void crearActor(){
            ActorController actorController = new ActorController();
            String nombre = crudNombreActor.Text;
            String apellido = crudApellidoActor.Text;
           
            DateTime nacimiento = DateTime.ParseExact(crudNacimientoActor.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            String nacionalidad = crudNacionalidadActor.Text;
            if (nacionalidad != "Uruguay" && nacionalidad != "Argentina"){
                Actor actorNuevo = new Actor(0, nombre, apellido, nacimiento, nacionalidad);
                if (actorController.agregarActor(actorNuevo)){
                    MessageBox.Show("Actor creada con éxito.");
                    clearActorSeleccionadoCRUD();
                    panelListaActoresCRUD.mostrarActores();
                }else{
                    MessageBox.Show("Error al crear la película.");
                }
            }else{
                MessageBox.Show("Debe tener una nacionalidad distinta de Uruguay y Argentina");
            }
        }
        private void btnAgregar_Actor_Click(object sender, EventArgs e){
            crearActor();
        }


        //ELIMINA ACTOR 
        private void eliminarActorSeleccionado(){
            ActorController actorController = new ActorController();
            if (actorController != null){
                if (actorController.eliminarActor(actorSeleccionado.NroActor)){
                    MessageBox.Show("Actor eliminado con éxito.");
                    clearActorSeleccionadoCRUD();
                }else{ 
                    MessageBox.Show("Error al eliminar el actor.");
                }
            }else{
                MessageBox.Show("No se encuentra un actor seleccionado.");
            }
            panelListaActoresCRUD.mostrarActores();
        }
        private void btnEliminar_Actor_Click(object sender, EventArgs e){
            eliminarActorSeleccionado();
        }


        //ASIGNA PELICULAS AL ACTOR
        public void asignarPeliculaActor(Pelicula pelicula){
            if ((new ActorController()).asignarPelicula(actorSeleccionado, pelicula)){
                MessageBox.Show($"Película {pelicula.Titulo} asignada a {actorSeleccionado.Nombre} {actorSeleccionado.Apellido} con éxito.");
                panelListaPeliculasCRUDActor.mostrarPeliculasActor(actorSeleccionado.NroActor);
            }else{
                MessageBox.Show("Error al asignar película.");
            }
            asignandoPeliculaActor = false;
            clearActorSeleccionadoCRUD();
        }
        private void btnAsignarPelicula_Click(object sender, EventArgs e){
            if (actorSeleccionado != null){
                MessageBox.Show("Seleciona una película.");
                asignandoPeliculaActor = true;
                panelListaPeliculasCRUDActor.mostrarPeliculas();
            }else{
                MessageBox.Show("Tiene que selecionar un actor.");
            }
        }

        #endregion

     
    }
}
