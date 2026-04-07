using System;
using System.Collections.Generic;
using System.Linq;
using Hmi.Core;
using System.Text;
using System.Threading.Tasks;

namespace Hmi.Infrastructure
{
    public class TestInfra
    {
        public string GetName()
        {
            return new Testcore().Name;
        }
    }
}
