using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace construir_app
{
    internal class DiscoService
    {
        public List<Disco> listar()
        {
            List<Disco> lista = new List<Disco>();

            //MÉTODOS PARA INTERACTUAR CON DB

            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;


            //CONFIGURACIÓN PARA CONSULTAR

            try
            {
                //DÓNDE ME VOY A CONECTAR
                conexion.ConnectionString = "server = .\\SQLEXPRESS; database = DISCOS_DB; integrated security = true";

                //ENVIAR LA SENTENCIA SQL QUE QUIERO EJECUTAR
                comando.CommandType = System.Data.CommandType.Text; //DE TIPO TEXTO

                //CONFIGURAR LA CONSULTA
                comando.CommandText = "Select D.Titulo Album, D.CantidadCanciones, D.FechaLanzamiento, D.UrlImagenTapa, E.Descripcion Genero, T.Descripcion Edicion From ESTILOS E, DISCOS D, TIPOSEDICION T where D.IdEstilo = E.Id AND D.IdTipoEdicion = T.Id";

                //ABRO LA CONEXIÓN Y REALIZO LA LECTURA
                comando.Connection = conexion;
                conexion.Open();
                lector = comando.ExecuteReader();

                //LEER LA INFO DEL LECTOR

                while (lector.Read())
                {
                    Disco aux = new Disco();
                    aux.Album = (string)lector["Album"];
                    aux.FechaLanzamiento = (DateTime)lector["FechaLanzamiento"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.UrlImagenTapa = (string)lector["UrlImagenTapa"];

                    //BASES DE DATOS RELACIONALES
                    aux.Genero = new Estilo();
                    aux.Genero.Descripcion = (string)lector["Genero"];

                    aux.Edicion = new Edicion();
                    aux.Edicion.Descripcion = (string)lector["Edicion"];


                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
