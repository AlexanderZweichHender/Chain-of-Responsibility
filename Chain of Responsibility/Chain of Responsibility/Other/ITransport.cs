using ChainOfResponsibility.Services;

namespace ChainOfResponsibility.Other
{
    internal interface ITransport
    {
        ServiceRequirments Requirments { get; set; }
        bool IsServiceComplete();
    }
}
