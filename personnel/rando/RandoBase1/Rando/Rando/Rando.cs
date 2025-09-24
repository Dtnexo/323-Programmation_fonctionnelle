namespace Rando
{
    public partial class Rando : Form
    {
        public object Drivers { get; }
        public Rando()
        {
            InitializeComponent();
            GpxOptions options = new GpxOptions()
            {
                ReadNestedAttributes = true
            };


            // Load the GPX file and open layer to read features
            using (var layer = Drivers.Gpx.OpenLayer(@"D:\Files\GIS\nested_data.gpx", options))
            {
                foreach (var feature in layer)
                {
                    // Check for MultiLineString geometry
                    if (feature.Geometry.GeometryType == GeometryType.MultiLineString)
                    {
                        // Read segment
                        var lines = (MultiLineString)feature.Geometry;
                        for (int i = 0; i < lines.Count; i++)
                        {
                            Console.WriteLine($"....segment({i})......");
                            var segment = (LineString)lines[i];

                            // Read points in segment
                            for (int j = 0; j < segment.Count; j++)
                            {
                                // Look for attribute
                                string attributeName = $"name__{i}__{j}";
                                if (layer.Attributes.Contains(attributeName) && feature.IsValueSet(attributeName))
                                {
                                    // Print a point and attribute
                                    var value = feature.GetValue<string>(attributeName);
                                    Console.WriteLine($"{segment[j].AsText()} - {attributeName}: {value}, ");
                                }
                                else
                                {
                                    // Print a point only
                                    Console.WriteLine(segment[j].AsText());
                                }
                            }
                        }
                        Console.WriteLine("..........");
                    }
                }
            }
        }


        private void Rando_Form_Paint(object sender, PaintEventArgs e)
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;

            Point[] points = new Point[4] { new Point(30,50), new Point(50,10), new Point(80,50), new Point(111,400) };
            this.CreateGraphics().DrawLines(myPen, points);
        }

    }

    class Trackpoint
    {
        private double _latitude;
        private double _longitude;
        private double _elevation;
    }
}
