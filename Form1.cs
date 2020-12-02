using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FigurasGeometricas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnAreaCuadrado_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Cuadrado(numLado.Value);
            lblCuadrado.Text = resultado + "";
        }

        private void btnAreaRectangulo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Rectangulo(numbase.Value, numAltura.Value);
            lblRectangulo.Text = resultado + "";
        }

        private void btnAreaTrapecio_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Trapecio(numAlturaTrapecio.Value, numbTrapecio.Value, numBaseTrapecio.Value);
            lblTrapecio.Text = resultado + "";
        }

        private void btnAreaTriangulo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Triangulo(numBaseTriangulo.Value, numAltura.Value);
            lblTriangulo.Text = resultado + "";
        }

        private void btnAreaCirculo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Circulo(numRadio.Value);
            lblCirculo.Text = resultado + "" ;
        }

        private void btnAreaRombo_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Rombo(numDiametroRombo.Value, numDiametromenor.Value);
            lblRombo.Text = resultado + "";
        }

        private void btnAreaRomboide_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Romboide(numBaseRomboide.Value, numBaseRomboide.Value);
            lblRomboide.Text = resultado + "";
        }

        private void btnAreaPoligono_Click(object sender, EventArgs e)
        {
            CAreas a = new CAreas();
            decimal resultado = a.Poligono(numPerimetroPoligono.Value, numApotemaPoligono.Value);
            lblPoligono.Text = resultado + "";
        }
    }

}
