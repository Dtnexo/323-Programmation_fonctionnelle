using System;
using System.Collections.Generic;
using System.Linq;

namespace Rando
{
    class GpxMerger
    {
        static double Distance(Trackpoint a, Trackpoint b)
        {
            double dLat = a.Latitude - b.Latitude;
            double dLon = a.Longitude - b.Longitude;
            return Math.Sqrt(dLat * dLat + dLon * dLon);
        }

        public static List<Trackpoint> Merge(List<Trackpoint> t1, List<Trackpoint> t2)
        {
            if (Distance(t1.Last(), t2.First()) > 0.01) // seuil arbitraire
                throw new Exception("Les tracés ne sont pas connectés");

            var merged = new List<Trackpoint>();
            merged.AddRange(t1);
            merged.AddRange(t2);
            return merged;
        }
    }
}
