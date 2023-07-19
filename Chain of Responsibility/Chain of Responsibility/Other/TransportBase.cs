using ChainOfResponsibility.Services;

namespace ChainOfResponsibility.Other
{
    internal abstract class TransportBase : ITransport
    {
        public ServiceRequirments Requirments { get; set; }

        public TransportBase(ServiceRequirments requirments)
            => Requirments = requirments;

        bool ITransport.IsServiceComplete()
        {
            return Requirments == ServiceRequirments.None;
        }
    }
}
