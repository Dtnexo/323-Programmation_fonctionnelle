using System.Collections.Generic;
using System.Xml.Linq;

namespace Rando
{
    class GpxWriter
    {
        public static void WriteGpx(string filePath, List<Trackpoint> trackpoints)
        {
            XNamespace ns = "http://www.topografix.com/GPX/1/1";

            var gpx = new XElement(ns + "gpx",
                new XAttribute("version", "1.1"),
                new XAttribute("creator", "RandoApp"),
                new XElement(ns + "trk",
                    new XElement(ns + "trkseg",
                        trackpoints.Select(tp =>
                            new XElement(ns + "trkpt",
                                new XAttribute("lat", tp.Latitude),
                                new XAttribute("lon", tp.Longitude),
                                new XElement(ns + "ele", tp.Elevation)
                            )
                        )
                    )
                )
            );

            gpx.Save(filePath);
        }
    }
}
