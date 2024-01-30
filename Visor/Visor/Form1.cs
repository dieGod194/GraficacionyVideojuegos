using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Visor
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap bmp;
        double angle;
        Canvas canvas;
        Figura figuraActual;
        bool ejesVisible = true;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(canva.Width, canva.Height);
            canvas = new Canvas(Graphics.FromImage(bmp), bmp);
            canva.Image = bmp;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            canvas.Renderplane();
            RedibujarCanvas();
        }
        private void RedibujarCanvas()
        {

            canvas.Clear();
            if (ejesVisible)
            {
                canvas.Renderplane();
            }
            if (figuraActual != null)
            {
                canvas.RenderFigura(figuraActual);
            }
            canva.Invalidate();
        }


        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void buttonCuadrado_Click(object sender, EventArgs e)
        {
            int centerX = canva.Width / 2;
            int centerY = canva.Height / 2;
            int lado = 100;

            figuraActual = Figura.CrearCuadrado(centerX, centerY, lado);
            RedibujarCanvas();
        }

        private void buttonTriangulo_Click(object sender, EventArgs e)
        {
            int centerX = canva.Width / 2;
            int centerY = canva.Height / 2;
            int lado = 100;

            figuraActual = Figura.CrearTriangulo(centerX, centerY, lado);
            RedibujarCanvas();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            angle = Convert.ToDouble(ValorRotar.Text);
            angle = angle * Math.PI / 180;

            if (figuraActual != null)
            {
                figuraActual.Rotar(angle);
                RedibujarCanvas();
            }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonTras_Click(object sender, EventArgs e)
        {
            int deltaX = Convert.ToInt32(textBox1.Text);
            int deltaY = Convert.ToInt32(textBox2.Text);

            figuraActual.Trasladar(deltaX, deltaY);
            RedibujarCanvas();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void buttonEsc_Click(object sender, EventArgs e)
        {
            if (figuraActual != null)
            {
                double factor;
                if (double.TryParse(textBox3.Text, out factor))
                {
                    figuraActual.Escalar(factor);
                    RedibujarCanvas();
                }
            }
        }
    }
}
