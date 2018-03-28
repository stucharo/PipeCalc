namespace PipeCalc
{
    public class PipelinePoint
    {
        public double KP { get; private set; } = 0.0;
        public double Depth { get; private set; } = 0.0;
        public double Tmin { get; private set; } = 0.0;
        public double Tburst { get; private set; } = 0.0;
        public double Tbuckle { get; private set; } = 0.0;
        public double Tcollapse { get; private set; } = 0.0;
        public double Tselected { get; private set; } = 0.0;
    }
}