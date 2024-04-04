
using ObligatorioProgramacionII;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObligatorioProgramacion.controller;
using ObligatorioProgramacion.model;


namespace ObligatorioProgramacionII.Vista{
    public partial class PanelListaPeliculas : Form{
        VentanaPrincipal VentanaPrincipal;
        List<Pelicula> Peliculas;

        public PanelListaPeliculas(VentanaPrincipal ventanaPrincipal){
            VentanaPrincipal = ventanaPrincipal;
            InitializeComponent();
            mostrarPeliculas();
        }

        public void mostrarPeliculas(){
            List<Pelicula> peliculas = new PeliculaController().obtenerTodasLasPeliculas();
            Peliculas = peliculas;
            tablaPelicula.Rows.Clear();
            if (peliculas != null){
                foreach (Pelicula pelicula in peliculas){
                    tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                }
            }
        }


        //MUESTRA PELÍCULAS SEGÚN EL ACTOR 
        public void mostrarPeliculasActor(int idActor){
            List<Pelicula> peliculas = new PeliculaController().obtenerPeliculas(idActor);
            tablaPelicula.Rows.Clear();
            if (peliculas != null)
            {
                foreach (Pelicula pelicula in peliculas)
                {
                    tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                }
            }
        }
      
        #region FILTRADO PELICULAS

        private void filtrarPeliculas(){
            if (filtroAnioActivo.Checked && Combo_ListaGenero.Text != "Todos"){
                cargarTablaPeliculaAnioYGenero();
            }else if (filtroAnioActivo.Checked && Combo_ListaGenero.Text == "Todos"){
                cargarTablaPeliculaAnio();
            }else{
                cargarTablaPeliculaGenero();
            }
        }
        private void cargarTablaPeliculaAnioYGenero(){
            String genero = Combo_ListaGenero.Text;
            int anio = Convert.ToInt32(filtroAnio.Value);
            List<Pelicula> peliculas = new PeliculaController().peliculasFiltradasPorAnioYGenero(anio, genero);
            Peliculas = peliculas;
            tablaPelicula.Rows.Clear();
            if (peliculas != null){
                foreach (Pelicula pelicula in peliculas){
                    tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                }
            }
        }

        //FILTRAR POR AÑO
        private void cargarTablaPeliculaAnio(){
            List<Pelicula> peliculas;
            peliculas = new PeliculaController().peliculasFiltradasPorAnio(Convert.ToInt32(filtroAnio.Value));
            Peliculas = peliculas;
            tablaPelicula.Rows.Clear();
            if (peliculas != null){
                foreach (Pelicula pelicula in peliculas){
                    tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                }
            }
        }
        private void filtroAnio_ValueChanged(object sender, EventArgs e){
            filtrarPeliculas();
        }
        private void filtroAnioActivo_CheckedChanged(object sender, EventArgs e){
            filtrarPeliculas();
        }

        //FILTRAR POR GÉNERO
        private void cargarTablaPeliculaGenero(){
            if (Combo_ListaGenero.Text == "Todos"){
                mostrarPeliculas();
            }else{
                List<Pelicula> peliculas = new PeliculaController().peliculasFiltradasPorGenero(Combo_ListaGenero.Text);
                Peliculas = peliculas;
                tablaPelicula.Rows.Clear();
                if (peliculas != null){
                    foreach (Pelicula pelicula in peliculas){
                        tablaPelicula.Rows.Add(pelicula.Codigo, pelicula.Titulo, pelicula.Anio, pelicula.Genero, pelicula.Duracion);
                    }
                }
            }
        }
        private void Combo_ListaGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            filtrarPeliculas();
        }
       
        #endregion

        //SELECCIONA PELÍCULA EN LA LISTA
        private void tablaPelicula_CellClick(object sender, DataGridViewCellEventArgs e){
            int numeroFilaSeleccionada = e.RowIndex;
            if (numeroFilaSeleccionada >= 0){
                Pelicula peliculaSeleecionada = Peliculas[numeroFilaSeleccionada];
                VentanaPrincipal.setPeliculaSeleccionadaCRUD(peliculaSeleecionada);
            }
        }

        public void refrescar(){
            Combo_ListaGenero.Text = "Todos";
            filtroAnioActivo.Checked = false;
            filtroAnio.Value = 2023;
            mostrarPeliculas();
        }

    }
}
