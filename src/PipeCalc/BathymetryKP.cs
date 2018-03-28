namespace PipeCalc
{
    public class BathymetryKP
    {
        public double KP { get; private set; }
        public double Depth { get; private set; }

        public BathymetryKP(double kp, double depth)
        {
            KP = kp;
            Depth = depth;
        }
    }
}