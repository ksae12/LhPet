using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LhPet.Models;

namespace LhPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // Intância da classe cliente 
        Cliente cliente1 = new Cliente(01, "Anderson", "129.323.443-60", "anderson@gmail.com", "floquinho");
        Cliente cliente2 = new Cliente(02, "Maria", "127.543.497-00", "maria_nas@gmail.com", "Snow");
        Cliente cliente3 = new Cliente(03, "Talyson", "431.312.342-71", "talyson1ena@gmail.com", "Loboc");
        Cliente cliente4 = new Cliente(04, "Katy Perry", "112.125.786-12", "katyPerry@gmail.com", "Tyrion");
        Cliente cliente5 = new Cliente(05, "Daenarys", "875.234.534-21", "daenarys123c@gmail.com", "Francis");

        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes;

        // Intância da classe fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Cat&Dog cia", "14.182.102/0001-00", "contato@cat&dog.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "Animals Vet", "21.652.103/0311-03", "contato@animalsvet.com");
        Fornecedor fornecedor3 = new Fornecedor(02, "JavaPets", "12.342.323/2231-33", "contato@javapets.com");

        List<Fornecedor> listaFornecedor = new List<Fornecedor>();
        listaFornecedor.Add(fornecedor1);
        listaFornecedor.Add(fornecedor2);
        listaFornecedor.Add(fornecedor3);

        ViewBag.listaFornecedor = listaFornecedor;

        return View();
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
