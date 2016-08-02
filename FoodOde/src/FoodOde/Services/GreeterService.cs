using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodOde.Services
{
    public interface IGreeterService
    {
        string GetGreeting();
    }
    public class GreeterService : IGreeterService
    {
        private string _greeting;

        public GreeterService(IConfiguration conf)
        {
            _greeting = conf["greeting"];
        }
        public string GetGreeting()
        {
            return _greeting;
        }
    }
}
