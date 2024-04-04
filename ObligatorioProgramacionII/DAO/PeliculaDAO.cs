using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using ObligatorioProgramacion.model;



namespace ObligatorioProgramacion.dao{
    public class PeliculaDAO{

        private static PeliculaDAO intancia;
        private string datosConexion;

        private PeliculaDAO(){
            //Informacion de la BD
            datosConexion = "Server=localhost;DataBase=ObligatorioProgramacion;Uid=melanie;Pwd=1234;";
        }

        public static PeliculaDAO getInstance(){
            if (intancia == null){
                intancia = new PeliculaDAO();
                return intancia;
            }else{
                return intancia;
            }
        }

        //Funciones del CRUD
        public bool agregarPelicula(Pelicula pelicula){
            Debug.Assert(pelicula != null, "La pelicula no puede ser null");
            // Crea un Objeto de la clase MySqlConnection, que representa una conexión a la BD
            MySqlConnection conexionBd = new MySqlConnection(datosConexion);
            conexionBd.Open(); //Abre la base de datos
            //Sentencia utilizada para insertar 
            String sql = $"INSERT INTO `peliculas` (`codigoPelicula`, `titulo`, `anio`, `genero`, `duracion`) VALUES(NULL,'{pelicula.Titulo}', {pelicula.Anio},'{pelicula.Genero}', '{pelicula.Duracion.ToString(@"hh\:mm\:ss")}');\r\n";
            MySqlCommand query = new MySqlCommand(sql, conexionBd); // Crea un objeto de la clase MySqlCommand, que representa un comando SQL
            // Metodo que se utiliza para ejecutar el comando 
            int filasAfectadas = query.ExecuteNonQuery();
            conexionBd.Close(); //Cierra la base de datos
            if (filasAfectadas == 1){
                return true;
            }else{
                return false;
            }
        }
        public bool modificarPelicula(Pelicula pelicula){
            Debug.Assert(pelicula != null, "La pelicula no puede ser null");
            MySqlConnection conexionBd = new MySqlConnection(datosConexion);
            conexionBd.Open();
            string sql = $"UPDATE `peliculas` SET `titulo` = '{pelicula.Titulo}',`anio` = {pelicula.Anio},`genero` = '{pelicula.Genero}', `duracion` = '{pelicula.Duracion.ToString(@"hh\:mm\:ss")}' WHERE `peliculas`.`codigoPelicula` = {pelicula.Codigo}";
            MySqlCommand query = new MySqlCommand(sql, conexionBd);
            int filasAfectadas = query.ExecuteNonQuery();
            conexionBd.Close();
            if (filasAfectadas == 1){
                return true;
            }else{
                return false;
            }
        }
        public bool eliminarPelicula(int codigoPelicula){
            MySqlConnection conexionBd = new MySqlConnection(datosConexion);
            conexionBd.Open();
            String sql = $" DELETE FROM peliculas WHERE `codigoPelicula` = {codigoPelicula}";
            MySqlCommand query = new MySqlCommand(sql, conexionBd);
            int filasAfectadas = query.ExecuteNonQuery();
            conexionBd.Close();
            if (filasAfectadas == 1){
                return true;
            }else{
                return false;
            }
        }

        // Muestra las peliculas en los DataGridView
        public List<Pelicula> obtenerPeliculas(int idActor){ //Según el actor muestra las peliculas en las que actúo.
            try{
                MySqlConnection conexionBd = new MySqlConnection(datosConexion);
                conexionBd.Open();
                String sql = $"SELECT * FROM `peliculas` WHERE `codigoPelicula` IN (SELECT `codigoPelicula` FROM actorespeliculas WHERE idActor = {idActor})";
                MySqlCommand query = new MySqlCommand(sql, conexionBd);
                MySqlDataReader datosLectura = query.ExecuteReader();
                List<Pelicula> peliculas = new List<Pelicula>();
                while (datosLectura.Read()){
                    peliculas.Add(new Pelicula(datosLectura.GetInt32(0), datosLectura.GetString(1), datosLectura.GetInt32(2), datosLectura.GetString(3), datosLectura.GetTimeSpan(4)));
                }
                conexionBd.Close();
                return peliculas;
            }catch(MySqlException ex){
                MessageBox.Show("Error de MySQL: " + ex.Message);
                return null;
            }catch (Exception ex){
                MessageBox.Show("Error general: " + ex.Message);
                return null;
            }
        }
        public List<Pelicula> obtenerTodasLasPeliculas(){
            try{
                MySqlConnection conexioBD = new MySqlConnection(datosConexion);
                conexioBD.Open();
                String sql = $"SELECT * FROM `peliculas`";
                MySqlCommand query = new MySqlCommand(sql, conexioBD);
                MySqlDataReader datosLectura = query.ExecuteReader();
                List<Pelicula> peliculas = new List<Pelicula>();
               while (datosLectura.Read()){
                    peliculas.Add(new Pelicula(datosLectura.GetInt32(0), datosLectura.GetString(1), datosLectura.GetInt32(2), datosLectura.GetString(3), datosLectura.GetTimeSpan(4)));
                }
                return peliculas;
            }catch (MySqlException ex){
                MessageBox.Show("Error de MySQL: " + ex.Message);
                return null;
            }catch (Exception ex){
                MessageBox.Show("Error general: " + ex.Message);
                return null;
            }
        }
        
        //FILTRADOS PELICULAS
        public List<Pelicula> peliculasFiltradasPorGenero(String genero){
            MySqlConnection conexionBD = new MySqlConnection(datosConexion);
            conexionBD.Open();
            String sql = $"SELECT * FROM `peliculas` WHERE `genero` = '{genero}'";
            MySqlCommand query = new MySqlCommand(sql, conexionBD);
            MySqlDataReader datosLectura = query.ExecuteReader();
            List<Pelicula> peliculas = new List<Pelicula>();
            while (datosLectura.Read()){
                peliculas.Add(new Pelicula(datosLectura.GetInt32(0), datosLectura.GetString(1), datosLectura.GetInt32(2), datosLectura.GetString(3), datosLectura.GetTimeSpan(4)));
            }
            return peliculas;
        }
        public List<Pelicula> peliculasFiltradasPorAnio(int anio){
            MySqlConnection conexionBD = new MySqlConnection(datosConexion);
            conexionBD.Open();
            String sql = $"SELECT * FROM `peliculas` WHERE `anio` = {anio}";
            MySqlCommand query = new MySqlCommand(sql, conexionBD);
            MySqlDataReader datosLectura = query.ExecuteReader();
            List<Pelicula> peliculas = new List<Pelicula>();
            while (datosLectura.Read()){
                peliculas.Add(new Pelicula(datosLectura.GetInt32(0), datosLectura.GetString(1), datosLectura.GetInt32(2), datosLectura.GetString(3), datosLectura.GetTimeSpan(4)));
            }
            return peliculas;
        }
        internal List<Pelicula> peliculasFiltradasPorAnioYGenero(int anio, string genero){
            MySqlConnection conexionBD = new MySqlConnection(datosConexion);
            conexionBD.Open();
            String sql = $"SELECT * FROM `peliculas` WHERE `anio` = {anio} AND `genero`='{genero}'";
            MySqlCommand query = new MySqlCommand(sql, conexionBD);
            MySqlDataReader datosLectura = query.ExecuteReader();
            List<Pelicula> peliculas = new List<Pelicula>();
            while (datosLectura.Read()){
                peliculas.Add(new Pelicula(datosLectura.GetInt32(0), datosLectura.GetString(1), datosLectura.GetInt32(2), datosLectura.GetString(3), datosLectura.GetTimeSpan(4)));
            }
            return peliculas;
        }
    }
}

