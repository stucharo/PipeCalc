using System.Collections.Generic;

namespace PipeCalc
{
    public class Pipeline
    
    {
        public string Name { get; private set; }
        public double StartKP { get; private set;}
        public double EndKP { get; private set; }
        private List<PipelinePoint> points;
        private List<BathymetryKP> bathymetry;


    }
}