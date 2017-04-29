namespace CarShop
{
    class CarRegistrationBuilder : ICarVisitor<CarRegistration>
    {
        private ICar _car;
        private string _make, _model;
        private float _engineCapacity;
        private int _seatCount;

        public CarRegistrationBuilder(ICar car)
        {
            _car = car;
        }

        public void VisitCar(string make, string model)
        {
            _make = make;
            _model = model;
        }

        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            _engineCapacity = structure.CylinderVolumn;
        }

        public void VisitSeat(string name, int capacity)
        {
            _seatCount += capacity;
        }

        public CarRegistration ProduceResult()
        {
            _car.Accept(() => (ICarVisitor)this);
            return new CarRegistration(_make.ToUpper(), _model, _engineCapacity, _seatCount);
        }
    }
}
