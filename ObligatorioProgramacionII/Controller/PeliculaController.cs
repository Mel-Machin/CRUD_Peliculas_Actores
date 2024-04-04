using ObligatorioProgramacion.dao;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObligatorioProgramacion.model;


namespace ObligatorioProgramacion.controller{
    public class PeliculaController{
        public bool agregarPelicula(Pelicula pelicula) { 
            Debug.Assert(pelicula != null, "La pelicula no puede ser null");
            PeliculaDAO peliculaDao = PeliculaDAO.getInstance();
            return peliculaDao.agregarPelicula(pelicula);
        }
        public bool modificarPelicula(Pelicula pelicula) { 
            PeliculaDAO peliculaDAO = PeliculaDAO.getInstance();
            return peliculaDAO.modificarPelicula(pelicula);
        }
        public bool eliminarPelicula(int codigoPelicula) {
            PeliculaDAO peliculaDAO = PeliculaDAO.getInstance();
            return peliculaDAO.eliminarPelicula(codigoPelicula);
        }
        public List<Pelicula> obtenerPeliculas(int idActor) {
            PeliculaDAO peliculaDAO = PeliculaDAO.getInstance();
            return peliculaDAO.obtenerPeliculas(idActor);
        }
        public List<Pelicula> obtenerTodasLasPeliculas(){
            PeliculaDAO peliculaDAO = PeliculaDAO.getInstance();
            return peliculaDAO.obtenerTodasLasPeliculas();
        }
        public List<Pelicula> peliculasFiltradasPorGenero(String genero){
            PeliculaDAO peliculaDAO = PeliculaDAO.getInstance();
            return peliculaDAO.peliculasFiltradasPorGenero(genero);
        }
        public List<Pelicula> peliculasFiltradasPorAnio(int anio){
            PeliculaDAO peliculaDAO = PeliculaDAO.getInstance();
            return peliculaDAO.peliculasFiltradasPorAnio(anio);
        }
        public List<Pelicula> peliculasFiltradasPorAnioYGenero(int anio, String genero){
            PeliculaDAO peliculaDAO = PeliculaDAO.getInstance();
            return peliculaDAO.peliculasFiltradasPorAnioYGenero(anio,genero);
        }
    }
}
