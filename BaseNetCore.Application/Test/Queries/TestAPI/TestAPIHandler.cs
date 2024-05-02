using BaseNetCore.Application.Common.Interdaces;
using MediatR;

namespace BaseNetCore.Application.Test.Queries.TestAPI
{
    public class TestAPIHandler : IRequestHandler<TestAPIQuery, bool>
    {
        private readonly IService _service; 
        public TestAPIHandler(IService service) { 
            _service = service;
        }

        public Task<bool> Handle(TestAPIQuery request, CancellationToken cancellationToken)
        {
            return _service.TestService(true);
        }
    }
}
