using ChainOfResponsibility.Services;
using ChainOfResponsibility.Other;

namespace ChainOfResponsibility
{
    internal class Program
    {
        private static void Main()
        {
            var engineService = new EngineService();
            var wheelsService = new WheelsService();

            engineService.SetNextService(wheelsService);

            engineService.Service(new Car(ServiceRequirments.Engine | ServiceRequirments.Wheels));
            engineService.Service(new Bus(ServiceRequirments.Engine));
        }
    }
}
