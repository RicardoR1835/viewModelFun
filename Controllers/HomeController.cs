using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using viewModelFun.Models;

namespace viewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            string torender = "This is a sample of a string model yo!";

            return View("Index", torender);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]
            {
                1,2,3,4,5,6,9,10,20
            };
            return View(numbers);
        }

        [HttpGet("user")]
        public IActionResult User(){
            MyModel rick = new MyModel(){
                FirstName = "Ricky",
                LastName = "Raccon"
            };
            return View(rick);
        }

        [HttpGet("users")]
        public IActionResult Users(){
            MyModel jonte = new MyModel(){
                FirstName = "jonte",
                LastName = "john"
            };
            MyModel novi = new MyModel(){
                FirstName = "Novi",
                LastName = "Nov"
            };
            MyModel Dave = new MyModel(){
                FirstName = "Dave",
                LastName = "Gee"
            };
            MyModel Juma = new MyModel(){
                FirstName = "Juma",
                LastName = "Hamden"
            };
            List<MyModel> allUsers = new List<MyModel>()
            {
                jonte, novi, Dave, Juma
            };
            return View(allUsers);
        }

    }
}
