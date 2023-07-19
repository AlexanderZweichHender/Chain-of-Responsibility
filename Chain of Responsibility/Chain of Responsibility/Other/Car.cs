using ChainOfResponsibility.Services;

namespace ChainOfResponsibility.Other
{
    internal class Car : ITransport
    {
        public ServiceRequirments Requirments { get; set; }

        public Car(ServiceRequirments requirments)
        {
            Requirments = requirments;
        }

        public bool IsServiceComplete()
        {
            return Requirments == ServiceRequirments.None;
        }
    }
}
