using GeometriaModels.Models;
using GeometriaModels.Service;

namespace GeometriaDekstop;

public partial class Form1 : Form
{
    FiguraService _figuraService { get; set; }
    public Form1(FiguraService figuraService)
    {
        InitializeComponent();
        this._figuraService = figuraService;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        _figuraService.AddFigura(new RectanguloModel { Largo = 1 });
    }

    private void label3_Click(object sender, EventArgs e)
    {

    }
}
