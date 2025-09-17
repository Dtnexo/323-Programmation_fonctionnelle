using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Xml.Linq;

namespace Rando
{
    class GpxReader
    {
        public static List<Trackpoint> ReadGpx(string filePath)
        {
            XDocument doc = XDocument.Load(filePath);

            var trackpoints = doc.Descendants()
                .Where(x => x.Name.LocalName == "trkpt")
                .Select(x => new Trackpoint
                {
                    Latitude = double.Parse(x.Attribute("lat").Value, CultureInfo.InvariantCulture),
                    Longitude = double.Parse(x.Attribute("lon").Value, CultureInfo.InvariantCulture),
                    Elevation = double.Parse(
                        x.Elements().First(e => e.Name.LocalName == "ele").Value,
                        CultureInfo.InvariantCulture)
                })
                .ToList();

            return trackpoints;
        }
    }
}
