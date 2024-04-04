using ObligatorioProgramacion.controller;
using ObligatorioProgramacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObligatorioProgramacion.model;
using System.Numerics;

namespace ObligatorioProgramacionII.Vista{
    public partial class PanelListaActores : Form{

        VentanaPrincipal VentanaPrincipal;
        List<Actor> Actores;
        public PanelListaActores(VentanaPrincipal ventanaPrincipal){
            InitializeComponent();
            VentanaPrincipal = ventanaPrincipal;
        }

        public void mostrarActores(){
            List<Actor> actores = new ActorController().obtenerTodosLosActores();
            Actores = actores;
            tablaActores.Rows.Clear();
            if (actores != null){
                foreach (Actor actor in actores){
                    tablaActores.Rows.Add(actor.NroActor, actor.Nombre, actor.Apellido, actor.FechaDeNacimiento.ToString("dd-MM-yyyy"), actor.Nacionalidad);
                }
            }
        }

        //MUESTRA ACTORES SEGÚN LA PELÍCULA
        public void mostrarActoresPelicula(int codigoPelicula){
            List<Actor> actores = new ActorController().obtenerActores(codigoPelicula);
            Actores = actores;
            tablaActores.Rows.Clear();
            if (actores != null){
                foreach (Actor actor in actores){
                    tablaActores.Rows.Add(actor.NroActor, actor.Nombre, actor.Apellido, actor.FechaDeNacimiento.ToString("dd-MM-yyyy"), actor.Nacionalidad);
                }
            }
        }
        private void tablaActores_CellClick(object sender, DataGridViewCellEventArgs e){
            int numeroFilaSeleccionada = e.RowIndex;
            if (numeroFilaSeleccionada >= 0){
                Actor actor = Actores[numeroFilaSeleccionada];
                VentanaPrincipal.setActorSeleccionadoCRUD(actor);
            }
        }

    }
}
