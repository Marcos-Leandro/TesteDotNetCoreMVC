using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TesteDotNetCoreMVC.Interfaces;
using TesteDotNetCoreMVC.Services;

namespace TesteDotNetCoreMVC.Controllers
{
    public class OperationsController : Controller
    {
        private readonly OperationService _operationService;
        private readonly IOperationTransient _transientOperation;
        private readonly IOperationScoped _scopedOperation;
        private readonly IOperationSingleton _singletonOperation;

        public OperationsController(OperationService operationService, IOperationTransient transientOperation, IOperationScoped scopedOperation, IOperationSingleton singletonOperation)
        {
            _operationService = operationService;
            _transientOperation = transientOperation;
            _scopedOperation = scopedOperation;
            _singletonOperation = singletonOperation;
        }

        public IActionResult Index()
        {
            // viewbag contains controller-requested services
            ViewBag.Transient = _transientOperation.OperationId;
            ViewBag.Scoped = _scopedOperation.OperationId;
            ViewBag.Singleton = _singletonOperation.OperationId;

            // operation service has its own requested services
            ViewBag.Service = _operationService;
            return View();
        }
    }
}