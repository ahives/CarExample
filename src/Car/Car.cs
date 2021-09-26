namespace Car
{
    public class Car :
        IVehicle, IInterior
    {
        readonly IEngine _engine;

        public Car(IEngine engine)
        {
            _engine = engine;
        }

        public EngineType Drive() => _engine.Engine();
        public bool HasRadio() => true;
    }
}