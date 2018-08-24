using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            {
                ArrayList moviedata = getData();


                return View(moviedata);
            }
            ArrayList getData()
            {
                Moviedata data = new Moviedata();
                return data.getData();
            }
        }
    }
}