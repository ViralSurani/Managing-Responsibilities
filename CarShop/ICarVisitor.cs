namespace CarShop
{
    interface ICarVisitor : ICarPartVisitor
    {
        void VisitCar(string make, string model);
    }

    interface ICarVisitor<T> : ICarVisitor
    {
        T ProduceResult();
    }
}
