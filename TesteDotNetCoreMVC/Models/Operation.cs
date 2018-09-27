using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TesteDotNetCoreMVC.Interfaces;

namespace TesteDotNetCoreMVC.Models
{
    public class Operation : IOperationTransient, IOperationScoped, IOperationSingleton
    {
        public Operation()
        {
            this.OperationId = Guid.NewGuid();
        }

        public Guid OperationId { get; }
    }
}
