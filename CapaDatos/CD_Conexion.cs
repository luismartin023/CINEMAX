using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Conexion
    {
        private SqlConnection conexion;

        public CD_Conexion()
        {
            conexion = new SqlConnection(
                "Server=LAPTOP-0EMQK151\\MSSQLSERVER01; Database=CineDB; User Id=yeni; Password=12345; TrustServerCertificate=True;"
            );
        }

        public SqlConnection AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed)
                conexion.Open();

            return conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open)
                conexion.Close();

            return conexion;
        }
    }
}v
