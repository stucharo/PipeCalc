using System;

namespace PipeCalc
{
    public class PD8010_2
    {
        private double _OD;
        private double _ID;
        private double _WT;
        private bool _ODControlled;
        private double _internalPressure;   
        private double _maxExternalPressure;
        private double _minExternalPressure;
        private double _yieldStrength;
        private double _tMinBurst;

        public PD8010_2(double diameter, double Pi, double Pe_max, double Pe_min, double yieldStrength, bool isOdControlled = true)
        {
            if(isOdControlled)
            {
                _OD = diameter;
            }
            else
            {
                _ID = diameter;
            }
            _ODControlled = isOdControlled;
            _internalPressure = Pi;
            _maxExternalPressure = Pe_max;
            _minExternalPressure = Pe_min;
            _yieldStrength = yieldStrength;
        }

        private void GetTMinBurst()
        {

        }
    }
}
