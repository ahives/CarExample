namespace CarTests
{
    using Car;
    using Microsoft.Extensions.DependencyInjection;
    using NUnit.Framework;

    [TestFixture]
    public class CarTests
    {
        [Test]
        public void Test()
        {
            var service = new ServiceCollection();

            service.AddSingleton<IEngine, TestV8Engine>();
            service.AddSingleton<IVehicle, Car>();

            var services = service.BuildServiceProvider();

            IVehicle vehicle = services.GetService<IVehicle>();
            // IVehicle vehicle = new Car(new V8Engine());

            var drive = vehicle.Drive();
            
            Assert.AreEqual(EngineType.NA, drive);
        }

        [Test]
        public void Test2()
        {
            var car = new Car(new V12Engine());
            IVehicle vehicle = car;
            IInterior interior = car;

            var drive = vehicle.Drive();
            
            Assert.AreEqual(true, interior.HasRadio());
            
            Assert.AreEqual(EngineType.V12, drive);
        }
    }

    public class TestV8Engine : IEngine
    {
        public EngineType Engine() => EngineType.NA;
    }
}