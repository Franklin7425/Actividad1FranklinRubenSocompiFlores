using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasComputadoras.Modelos;

namespace SistemasComputadoras.DAL
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadorasDAL()
        {
            string consulta = "select * from computadora";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;
        }

        public void InsertarComputadoraDAL(Computadora computadora)
        {
            string consulta = "insert into computadora values('" + computadora.Nombre + "' ," +
                                                         "'" + computadora.Descripcion + "' ," +
                                                         "'" + computadora.Precio + "' ," +
                                                         "'" + computadora.FechaFabricacion + "' )";
            conexion.Ejecutar(consulta);
        }

        public Computadora ObtenerComputadoraId(int id)
        {
            string consulta = "SELECT * FROM Computadora WHERE IdComputadora = " + id;
            DataTable tabla = conexion.EjecutarDataTabla(consulta, "tabla");
            Computadora computadora = new Computadora();
            if (tabla.Rows.Count > 0)
            {
                computadora.IdComputadora = Convert.ToInt32(tabla.Rows[0]["IdComputadora"]);
                computadora.Nombre = tabla.Rows[0]["Nombre"].ToString();
                computadora.Descripcion = tabla.Rows[0]["Descripcion"].ToString();
                computadora.Precio = Convert.ToDecimal(tabla.Rows[0]["Precio"]);
                computadora.FechaFabricacion = Convert.ToDateTime(tabla.Rows[0]["FechaFabricacion"]);
            }
            return computadora;

        }

        public void EditarComputadoraDal(Computadora computadora)
        {
            string consulta = "update computadora set nombre='" + computadora.Nombre + "'," +
                                                 "descripcion='" + computadora.Descripcion + "'," +
                                                 "precio='" + computadora.Precio + "'," +
                                                 "fechafabricacion='" + computadora.FechaFabricacion + "'," +
                                           "where idcomputadora=" + computadora.IdComputadora;

            conexion.Ejecutar(consulta);
        }

        public void EliminarComputadoraDal(int id)
        {
            string consulta = "delete from computadora where idcomputadora =" + id;
            conexion.Ejecutar(consulta);
        }
    }
}
