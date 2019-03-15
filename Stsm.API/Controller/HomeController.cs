using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stsm.API.Controller
{
    public class HomeController:Microsoft.AspNetCore.Mvc.Controller
    {
        public List<RT> GetAll()
        {
            return System.Linq.Enumerable.Range(1, 10).Select(x => new RT() { Age = x, Name = "name" + x }).ToList();
        }
    }
}
