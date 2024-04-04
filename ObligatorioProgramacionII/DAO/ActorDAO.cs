using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ObligatorioProgramacion.model;



namespace ObligatorioProgramacion.dao{
    public class ActorDAO{

        private static ActorDAO intancia;
        private string datosConexion;

        private ActorDAO() {
            datosConexion = "Server=localhost;DataBase=ObligatorioProgramacion;Uid=melanie;Pwd=1234;";
        }
        
        public static ActorDAO getInstance(){
            if(intancia == null){
                intancia = new ActorDAO();
                return intancia;
            }else{
                return intancia;
            }
        }

        // Funciones del CRUD
        public bool agregarActor(Actor actor) {
            Debug.Assert(actor != null,"El actor no puede ser null");
            MySqlConnection conexionBd = new MySqlConnection(datosConexion);
            conexionBd.Open();
            String sql = $"INSERT INTO `actores` (`idActor`, `nombre`, `apellido`, `fechaDeNacimiento`, `nacionalidad`) VALUES (NULL, '{actor.Nombre}', '{actor.Apellido}', '{actor.FechaDeNacimiento.ToString("yyyy-MM-dd")}', '{actor.Nacionalidad}');\r\n";
            MySqlCommand query = new MySqlCommand(sql, conexionBd);
            int filasAfectadas = query.ExecuteNonQuery();
           conexionBd.Close();
            if (filasAfectadas == 1){
                return true;
            }else{
                return false;
            }
        }
        public bool modificarActor(Actor actor) {
            Debug.Assert(actor != null, "El actor no puede ser null");
            MySqlConnection conexionBd = new MySqlConnection(datosConexion);
            conexionBd.Open();
            String sql = $"UPDATE actores SET `nombre` ='{actor.Nombre}', `apellido`='{actor.Apellido}',`fechaDeNacimiento`='{actor.FechaDeNacimiento.ToString("yyyy-MM-dd")}',`nacionalidad`='{actor.Nacionalidad}' WHERE `idActor`= {actor.NroActor}";
            MySqlCommand query = new MySqlCommand(sql, conexionBd);
            int filasAfectadas = query.ExecuteNonQuery();
            conexionBd.Close();
            if (filasAfectadas == 1){
                return true;
            }else{
                return false;
            }
        }
        public bool eliminarActor(int idActor) {
            MySqlConnection conexionBd = new MySqlConnection(datosConexion);
            conexionBd.Open();
            String sql = $" DELETE FROM actores WHERE `idActor` = {idActor}";
            MySqlCommand query = new MySqlCommand(sql, conexionBd);
            int filasAfectadas = query.ExecuteNonQuery();
            conexionBd.Close();
            if (filasAfectadas == 1){
                return true;
            }else{
                return false;
            }
        }
        public bool asignarPelicula(Actor actor, Pelicula pelicula){
            MySqlConnection conexionBd = new MySqlConnection(datosConexion);
            conexionBd.Open();
            String sql = $"INSERT INTO `actorespeliculas` (`codigoPelicula`, `idActor`) VALUES ('{pelicula.Codigo}', '{actor.NroActor}');";
            MySqlCommand query = new MySqlCommand(sql, conexionBd);
            int filasAfectadas = query.ExecuteNonQuery();
            conexionBd.Close();
            if (filasAfectadas == 1){
                return true;
            }else{
                return false;
            }
        }

        //Muestra los actores en los DataGridView
        public List<Actor> obtenerActores(int codigoPelicula){ //Obtiene los actores según la película.
            try{
                MySqlConnection conexionBd = new MySqlConnection(datosConexion);
                conexionBd.Open();
                String sql = $"SELECT * FROM `actores` WHERE `idActor` IN (SELECT `idActor` FROM `actorespeliculas` WHERE `codigoPelicula` = {codigoPelicula})";
                MySqlCommand query = new MySqlCommand(sql, conexionBd);
                MySqlDataReader datosLectura = query.ExecuteReader();
                List<Actor> actoresDeLaPelicula = new List<Actor>();
                while (datosLectura.Read()){
                    actoresDeLaPelicula.Add(new Actor(datosLectura.GetInt32(0), datosLectura.GetString(1), datosLectura.GetString(2), datosLectura.GetDateTime(3), datosLectura.GetString(4)));
                }
                conexionBd.Close();
                return actoresDeLaPelicula;
            }catch(MySqlException ex){
                MessageBox.Show("Error de MySQL: " + ex.Message);
                return null;
            }catch(Exception ex){
                MessageBox.Show("Error general: " + ex.Message);
                return null;
            }
        } 
        public List<Actor> obtenerTodosLosActores(){
            try{
                MySqlConnection conexionBd = new MySqlConnection(datosConexion);
                conexionBd.Open();
                String sql = $"SELECT * FROM `actores`";
                MySqlCommand query = new MySqlCommand(sql, conexionBd);
                MySqlDataReader datosLectura = query.ExecuteReader();
                List<Actor> actores = new List<Actor>();
                while (datosLectura.Read()){
                    actores.Add(new Actor(datosLectura.GetInt32(0), datosLectura.GetString(1), datosLectura.GetString(2), datosLectura.GetDateTime(3), datosLectura.GetString(4)));
                }
                conexionBd.Close();
                return actores;
            }catch (MySqlException ex){
                MessageBox.Show("Error de MySQL: " + ex.Message);
                return null;
            }catch (Exception ex){
                MessageBox.Show("Error general: " + ex.Message);
                return null;
            }
        }
    }
}
