using GeometriaModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.DALs
{
    internal class FigurasListDAL : IFiguraDAL
    {
        List<FiguraModel> figuras = new List<FiguraModel>();
        public FiguraModel Add(FiguraModel figura)
        {
            figura.Id = (from f in figuras select f.Id).DefaultIfEmpty(0).Max() + 1;
            figuras.Add(figura);
            return figura;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<FiguraModel> GetAll()
        {
            return figuras;
        }

        public FiguraModel GetById(int id)
        {
            return figuras.FirstOrDefault(f => f.Id == id);

        }

        public FiguraModel Save(FiguraModel entidad)
        {
            throw new NotImplementedException();
        }
    }
}
