using GeometriaModels.DALs;
using GeometriaModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.Service
{
    public class FiguraService
    {
        IFigurasDAL _figuraDAL;

        public FiguraService (IFigurasDAL figurasDAL)
        {
            _figuraDAL = figurasDAL;
        }

        public List<FiguraModel> GetAll()
        {
            return _figuraDAL.GetAll();
        }

        public FiguraModel GetById(int id)
        {
            return _figuraDAL.GetById(id);
        }


        public FiguraModel AddFigura(FiguraModel nueva)
        {
            return _figuraDAL.Add(nueva);
        }
    }
}
