namespace CarShop
{
    class EngineStructure
    {
        public float Power { get; private set; }
        public float CylinderVolumn { get; private set; }

        public EngineStructure(float power, float cylinderVolumn)
        {
            Power = power;
            CylinderVolumn = cylinderVolumn;
        }
    }
}
