using ChainOfResponsibility.Other;

namespace ChainOfResponsibility.Services
{
    internal abstract class BaseService
    {
        protected ServiceRequirments _servicesProvide;
        protected BaseService _nextService;

        public BaseService(ServiceRequirments serviceProvide)
            => _servicesProvide = serviceProvide;

        public void Service(ITransport transport)
        {
            if (_servicesProvide == (transport.Requirments & _servicesProvide))
            {
                Console.WriteLine($"{this.GetType().Name} is providing {_servicesProvide} services " +
                    $"for {transport.GetType().Name}");

                transport.Requirments &= ~_servicesProvide;
            }

            if (transport.IsServiceComplete() || _nextService == null)
                return;
            else
            {
                _nextService.Service(transport);
            }
        }

        public void SetNextService(BaseService nextService)
            => _nextService = nextService;
    }
}
