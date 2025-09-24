using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPXReaderLib;

namespace Rando
{
    internal class GpxReadeer
    {
        public static void ProcessGpx(Stream input, Stream output) 
        { 
            using (GpxReadeer reader = new GpxReadeer(input))
            {
                using (GpxWriter writer = new GpxWriter(output))
                {
                    while (reader.Read())
                    {
                        switch (reader.ObjectType)
                        {
                            case GpxObjectType.Metadata:
                                writer.WriteMetadata(reader.Metadata);
                                break;
                            case GpxObjectType.WayPoint:
                                writer.WriteWayPoint(reader.WayPoint);
                                break;
                            case GpxObjectType.Route:
                                writer.WriteRoute(reader.Route);
                                break;
                            case GpxObjectType.Track:
                                writer.WriteTrack(reader.Track);
                                break;
                        }
                    }
                }
            }
        }
        
    }
    
    public class GpxReader
    {
        private readonly Stream input;

        public GpxReader(Stream input)
        {
            this.input = input;
        }

    }
}
