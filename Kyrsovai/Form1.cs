using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrsovai
{

    public partial class Form1 : Form
    {
        List<Emitter> emitters = new List<Emitter>();
        RotatingEmitter rotatingEmitter; // добавим поле для эмиттера

        public Form1()
        {
            InitializeComponent();
            picDisplay.Image = new Bitmap(picDisplay.Width, picDisplay.Height);

            this.rotatingEmitter = new RotatingEmitter// создаю эмиттер и привязываю его к полю rotatingEmitter
            {
                Direction = 0,
                Spreading = 10,
                SpeedMin = 10,
                SpeedMax = 10,
                ColorFrom = Color.Silver,
                ColorTo = Color.FromArgb(0, Color.Black),
                ParticlesPerTick = 10,
                X = picDisplay.Width / 2,
                Y = picDisplay.Height / 2,
                Center = new Point(picDisplay.Width / 2, picDisplay.Height / 2),
                CircleRadius = 125
            };

            emitters.Add(this.rotatingEmitter);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            rotatingEmitter.UpdateState(); //обновляем эмиттер

            using (var g = Graphics.FromImage(picDisplay.Image))
            {
                g.Clear(Color.Black);
                rotatingEmitter.Render(g); // рендерим систему
            }
            picDisplay.Invalidate();
        }
        List<Particle> particles = new List<Particle>();
        // Разброс частиц
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            rotatingEmitter.Spreading = tbSpreading.Value; //  разброс
            lblRaz.Text = $"{tbSpreading.Value}°"; // добавил вывод значения
        }

        // Размер окружности
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            rotatingEmitter.CircleRadius = tbPower.Value;
            tbPow.Text = $"{tbPower.Value} R"; // добавил вывод значения
            
        }

       
        //Скорость частицы
        private void tbSpeed_Scroll_1(object sender, EventArgs e)
        {
            rotatingEmitter.Speed = tbSpeed.Value;
        }
        // Частицы за тик
        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            rotatingEmitter.ParticlesPerTick = tbTick.Value;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void picDisplay_Click(object sender, EventArgs e)
        {

        }

       
    }
}
