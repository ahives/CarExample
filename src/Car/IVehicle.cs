namespace Car
{
    public interface IVehicle
    {
        EngineType Drive();
    }

    class Motorcycle : IVehicle, IInterior
    {
        public EngineType Drive() => EngineType.V8;
        public bool HasRadio() => true;
    }
}