namespace Rando
{
    class Trackpoint
    {
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Elevation { get; set; }

        public override string ToString() => $"({Latitude}, {Longitude}, {Elevation}m)";
    }
}
