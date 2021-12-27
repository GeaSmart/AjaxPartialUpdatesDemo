using CustomerAjax.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAjax.Controllers
{
    public class CustomerController : Controller
    {
        List<Customer> listado;
        public CustomerController()
        {
            listado = new List<Customer>()
            {
                new Customer { Id = 1, Name = "Gerson", Age = 32 },
                new Customer { Id = 2, Name = "Eder", Age = 27 },
                new Customer { Id = 3, Name = "Antonio", Age = 12 },
                new Customer { Id = 4, Name = "Rosa", Age = 22 },
                new Customer { Id = 5, Name = "Nancy", Age = 25 }
            };            
        }

        public IActionResult Index()
        {
            Tuple<List<Customer>, Customer> tupla = new Tuple<List<Customer>, Customer>(listado, listado[0]);            

            ViewData["PageTitle"] = "Customer";
            return View(tupla);
        }
    }
}
