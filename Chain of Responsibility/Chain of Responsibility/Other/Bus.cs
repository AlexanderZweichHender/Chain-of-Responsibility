using ChainOfResponsibility.Services;

namespace ChainOfResponsibility.Other
{
    internal class Bus : TransportBase
    { 
        public Bus(ServiceRequirments requirments) : base(requirments)
        { }
    }
}
