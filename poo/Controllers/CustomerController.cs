using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using poo.Models;

namespace poo.Controllers;

public class CustomerController : Controller
{
    public IActionResult Index()
    {
        int id = 1;

        Customer cu = new Customer(); // construtor  
        cu.CustomerId = id;
        cu.EmailAddress = "cumail@example.com";
        cu.FirstName = "Fulano";
        cu.LastName = "De Tal";

        Customer cu1 = new Customer
        {
            CustomerId = ++id,
            EmailAddress = "cu1mail@example.com",
            FirstName = "Ciclano",
            LastName = "De Tal"
        };

        var cu2 = new Customer()
        {
            CustomerId = ++id,
            EmailAddress = "cu2mail@example.com",
            FirstName = "Beltrano",
            LastName = "De Tal"
        };

        List<Customer> customers = new List<Customer>();
        customers.Add(cu);
        customers.Add(cu1);
        customers.Add(cu2);


        return View(customers);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}