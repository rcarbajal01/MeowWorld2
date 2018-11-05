using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MeowWorld2.Controllers
{
    public class CatController
    {
        [HttpGet("cat/{cat}")]
        public string Cat(string cat)
        {
            switch (cat)
            {
                case "bill":
                    return "Meow!";
                case "steve":
                    return "Purr.";
            }
            return string.Empty;
        }
    }
}
