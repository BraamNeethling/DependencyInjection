using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dependency_Injection.Services.Interfaces;

namespace Dependency_Injection.Services
{
    public class TestService : ITestService
    {
        public string MessageAgain()
        {
            return "There";
        }
    }
}