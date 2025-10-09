using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaModels.Models;

public class RectanguloModel:FiguraModel
{
    public double Largo { get; set; }
    public double Ancho { get; set; }

    public RectanguloModel()
    {
    }

    public RectanguloModel (double largo, double ancho  )
    {
        Largo = largo;
        Ancho = ancho;
    }
}
