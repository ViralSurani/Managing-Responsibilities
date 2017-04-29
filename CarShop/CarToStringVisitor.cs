namespace CarShop
{
    class CarToStringVisitor : ICarVisitor
    {
        private string _carDetails;
        private string _engineDetails;
        private int _seatCount;

        public void VisitCar(string make, string model)
        {
            _carDetails = string.Format("{0} {1}", make, model);
        }

        public void VisitEngine(EngineStructure structure, EngineStatus status)
        {
            _engineDetails = string.Format("{0} cc {1} KW", structure.CylinderVolumn, structure.Power);
        }

        public void VisitSeat(string name, int capacity)
        {
            _seatCount = _seatCount + capacity;
        }

        public string GetCarDescription()
        {
            return string.Format("{0} {1} {2} seat(s)", _carDetails, _engineDetails, _seatCount);
        }

    }
}
