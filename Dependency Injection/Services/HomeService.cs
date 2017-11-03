using Dependency_Injection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dependency_Injection.Services
{
    public class HomeService : IHomeService
    {
        public string GetMessage()
        {
            return "Hello";
        }
    }
}