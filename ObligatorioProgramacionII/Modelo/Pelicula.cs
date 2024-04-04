using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatorioProgramacion.model{
    public class Pelicula{
        public string Titulo { get; set; }
        public int Anio {  get; set; }
        public string Genero {  get; set; }
        public TimeSpan Duracion {  get; set; }
        public int  Codigo { get; set; }

        public Pelicula(){
            
        }

        public Pelicula(int codigo, string titulo, int anio, string genero, TimeSpan duracion){
            Codigo = codigo;
            Titulo = titulo;
            Anio = anio;    
            Genero = genero;
            Duracion = duracion;

        }
    }
}

