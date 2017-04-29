namespace CarShop
{
    class EngineStatus
    {
        public float TempratureC { get; private set; }

        public EngineStatus(float tempratureC)
        {
            TempratureC = tempratureC;
        }
    }
}
