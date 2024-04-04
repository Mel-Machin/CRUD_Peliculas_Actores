using ObligatorioProgramacion.dao;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using ObligatorioProgramacion.model;


namespace ObligatorioProgramacion.controller{
    public class ActorController{

        public bool agregarActor(Actor actor) {
            Debug.Assert(actor != null, "El actor no puede ser null");
            ActorDAO actorDAO = ActorDAO.getInstance();
            return actorDAO.agregarActor(actor);
        }
        public bool modificarActor(Actor actor) {
            ActorDAO actorDAO = ActorDAO.getInstance();
            return actorDAO.modificarActor(actor);
        }
        public bool eliminarActor(int idActor) {
            ActorDAO actorDAO = ActorDAO.getInstance();
            return actorDAO.eliminarActor(idActor);
        }
        public List<Actor> obtenerActores(int codigoPelicula) {
            ActorDAO actorDAO = ActorDAO.getInstance();
            return actorDAO.obtenerActores(codigoPelicula);
        }
        public List<Actor> obtenerTodosLosActores(){
            ActorDAO actorDAO = ActorDAO.getInstance();
            return actorDAO.obtenerTodosLosActores();
        }
        public bool asignarPelicula(Actor actor, Pelicula pelicula){
            ActorDAO actorDAO = ActorDAO.getInstance();
            return actorDAO.asignarPelicula(actor, pelicula);
        }
    }
}
