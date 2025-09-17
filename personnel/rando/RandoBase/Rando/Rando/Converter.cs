using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Rando
{
    static class Converter
    {
        public static List<Point> ToPoints(List<Trackpoint> trackpoints, int width, int height)
        {
            double minLat = trackpoints.Min(t => t.Latitude);
            double maxLat = trackpoints.Max(t => t.Latitude);
            double minLon = trackpoints.Min(t => t.Longitude);
            double maxLon = trackpoints.Max(t => t.Longitude);

            double scaleX = width / (maxLon - minLon);
            double scaleY = height / (maxLat - minLat);

            return trackpoints.Select(tp =>
                new Point(
                    (int)((tp.Longitude - minLon) * scaleX),
                    height - (int)((tp.Latitude - minLat) * scaleY)
                )
            ).ToList();
        }
    }
}
