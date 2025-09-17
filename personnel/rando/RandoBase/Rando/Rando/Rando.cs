using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Rando
{
    public partial class Rando : Form
    {
        private List<Trackpoint> _trackpoints;

        // Palette de couleurs pour altitudes
        private readonly Color[] gradient = new Color[]
        {
            Color.FromArgb(255, 144, 238, 144),
            Color.FromArgb(255, 162, 216, 128),
            Color.FromArgb(255, 180, 194, 112),
            Color.FromArgb(255, 198, 172, 96),
            Color.FromArgb(255, 216, 150, 80),
            Color.FromArgb(255, 234, 128, 64),
            Color.FromArgb(255, 244, 106, 48),
            Color.FromArgb(255, 248,  84, 36),
            Color.FromArgb(255, 252,  62, 24),
            Color.FromArgb(255, 254,  48, 18),
            Color.FromArgb(255, 255,  32, 12),
            Color.FromArgb(255, 255,  16,  6),
            Color.FromArgb(255, 255,   0,  0)
        };

        public Rando()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            
            _trackpoints = GpxReader.ReadGpx("../../../../../../gpx/Ballade_châtaignère_🌰.gpx");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (_trackpoints == null || _trackpoints.Count < 2)
                return;

            var points = Converter.ToPoints(_trackpoints, this.ClientSize.Width, this.ClientSize.Height);

           
            for (int i = 0; i < points.Count - 1; i++)
            {
                int idx = (int)(_trackpoints[i].Elevation / 100);
                idx = Math.Min(idx, gradient.Length - 1);

                using Pen pen = new Pen(gradient[idx], 2);
                e.Graphics.DrawLine(pen, points[i], points[i + 1]);
            }
        }
    }
}
