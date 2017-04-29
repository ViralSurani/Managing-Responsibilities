using System;

namespace CarShop
{
    class Engine
    {
        private float Power;
        private float CylinderVolumn;

        private const float WorkingTemperatureC = 90.0F;
        private float temperatureC = 20.0F;

        public Engine(float power, float cylinderVolumn)
        {
            this.Power = power;
            this.CylinderVolumn = cylinderVolumn;
        }

        public void Accept(Func<ICarPartVisitor> visitorFactory)
        {
            EngineStructure structure = new EngineStructure(Power, CylinderVolumn);
            EngineStatus status = new EngineStatus(temperatureC);
            visitorFactory().VisitEngine(structure, status);
        }

        public void Run(TimeSpan time)
        {
            TimeSpan heatingTime = this.GetHeatingTime();

            if (time > heatingTime)
            {
                this.temperatureC = WorkingTemperatureC;
            }
            else
            {
                double temperatureDelta = WorkingTemperatureC - this.temperatureC;
                double timeRatio = time.TotalMinutes / heatingTime.TotalMinutes;
                this.temperatureC += (float)(temperatureDelta * timeRatio);
            }
        }

        private TimeSpan GetHeatingTime()
        {
            double meanPower = 180.0;
            double nominalHeatingTimeSec = 300.0;

            int seconds = (int)(nominalHeatingTimeSec * meanPower / this.Power);

            return new TimeSpan(0, 0, seconds);
        }
    }
}
