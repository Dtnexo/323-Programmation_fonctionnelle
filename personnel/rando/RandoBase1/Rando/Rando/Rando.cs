using Aspose.Gis;
using Aspose.Gis.Formats.Gpx;
using Aspose.Gis.Geometries;
using System.CodeDom;
using System.Diagnostics;

namespace Rando
{
    public partial class Rando : Form
    {
        public Rando()
        {
            Pen myPen = new Pen(Color.Red);
            myPen.Width = 2;

            List<Trackpoint> trackpoint = new List<Trackpoint>();
            GpxOptions options = new GpxOptions()
            {
                ReadNestedAttributes = true
            };

            List<Color.Red, System.Drawing.Point> points = Convert

            // Load the GPX file and open layer to read features
            var layer = Drivers.Gpx.OpenLayer(@"C:\Users\pt22ugm\Documents\GitHub\323-Programmation_fonctionnelle\personnel\rando\gpx\Chemin_des_planètes_3_4.gpx");

            foreach (var feature in layer)
            {
                // Check for MultiLineString geometry
                if (feature.Geometry.GeometryType == GeometryType.MultiLineString)
                {
                    // Read track
                    var lines = (MultiLineString)feature.Geometry;


                    lines.ToList().ForEach(line =>
                    {
                        List<string> coordlist = line.AsText().ToString().Replace("LINESTRING Z (", "").Replace(")", "").Split(",").ToList();
                        coordlist.ForEach(coord =>
                        {
                            List<string> coordone = coord.ToString().Trim().Split(" ").ToList();

                            double lat = double.Parse(coordone.First().ToString());
                            double log = double.Parse(coordone.Skip(1).First().ToString());
                            double ele = double.Parse(coordone.Last().ToString());
                            trackpoint.Add(new Trackpoint(lat, log, ele));
                        });


                    }
                    );
                    this.CreateGraphics().DrawLines(myPen, trackpoint);

                }
            }
        }



    class Trackpoint
    {
        private double _latitude;
        private double _longitude;
        private double _elevation;
        public Trackpoint(double latitude, double longitude, double elevation)
        {
            _latitude = latitude;
            _longitude = longitude;
            _elevation = elevation;
        }
    }
}
