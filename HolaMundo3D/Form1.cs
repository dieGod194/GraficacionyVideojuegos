namespace HolaMundo3D
{
    public partial class Form1 : Form
    {
        Canvas canvas;

        Bitmap bmp;
        Graphics g;

        static float delta;
        static DateTime lastTime, currentTime;
        static int framesRendered = 0;
        public static int fps;

        Space f;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            bmp = new Bitmap(Canvas.Width, Canvas.Height);

            g = Graphics.FromImage(bmp);
            Canvas.Image = bmp;
            canvas = new Canvas(bmp);
            f = new Space(10, 1, 1);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            framesRendered++;
            currentTime = DateTime.Now;
            if((currentTime - lastTime).TotalSeconds>=1)
            {
                fps = framesRendered;
                framesRendered = 0;
                delta = (float)(currentTime - lastTime).TotalMilliseconds / 1000000;
                lastTime=currentTime;
            }
            f.Render(canvas, delta);
            label1.Text=fps.ToString();
            Canvas.Refresh();
        }
    }
}
