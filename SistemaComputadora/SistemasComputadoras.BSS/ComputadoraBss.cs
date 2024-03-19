using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemasComputadoras.Modelos;
using SistemasComputadoras.DAL;
using System.Data;

namespace SistemasComputadoras.BSS
{
    public class ComputadoraBss
    {
        ComputadoraDal dal = new ComputadoraDal();
        public DataTable ListarComputadorasBss()
        {
            return dal.ListarComputadorasDAL();
        }

        public void InsertarComputadorasBss(Computadora computadora)
        {
            dal.InsertarComputadoraDAL(computadora);
        }

        public Computadora ObtenerIdBss(int id)
        {
            return dal.ObtenerComputadoraId(id);
        }

        public void EditarComputadoraBss(Computadora computadora)
        {
            dal.EditarComputadoraDal(computadora);
        }

        public void EliminarComputadoraBss(int id)
        {
            dal.EliminarComputadoraDal(id);
        }
    }
}
