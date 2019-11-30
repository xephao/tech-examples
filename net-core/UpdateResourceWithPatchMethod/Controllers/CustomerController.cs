using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UpdateResourceWithPatchMethod.Controllers
{
    [Route("/api/customers")]
    public class CustomerController: Controller
    {
        private readonly ICustomerRepo _customerRepo;
        private readonly ILogger<CustomersController> _log;
        private readonly IMapper _mapper;

        public CustomersController(ICustomerRepo customerRepo,
            ILogger<CustomersController> log,
            IMapper mapper)
        {
            this._customerRepo = customerRepo;
            this._log = log;
            this._mapper = mapper;
        }
    }
}
