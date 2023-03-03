using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // instancias do tipo cliente
        Cliente cliente1 = new Cliente(01, "Aninha A.", "123.456.789-00", "ana.69@hotmai.com", "Cabritinha");
        Cliente cliente2 = new Cliente(02, "Aninho B.", "111.456.789-11", "aninho.96@hotmai.com", "Pato");
        Cliente cliente3 = new Cliente(03, "Anno X.", "222.456.789-22", "ano.24@hotmai.com", "Coelhinho");
        Cliente cliente4 = new Cliente(04, "Paninha T.", "333.456.789-33", "pan.48@hotmai.com", "Peixe");
        Cliente cliente5 = new Cliente(05, "Caninha ÃO.", "444.456.789-44", "cana.77@hotmai.com", "Galo");

        // Lista de clientes e atribuí os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(cliente1);
        listaClientes.Add(cliente2);
        listaClientes.Add(cliente3);
        listaClientes.Add(cliente4);
        listaClientes.Add(cliente5);

        ViewBag.listaClientes = listaClientes; // ViewBag = tipo uma "bolsa" que leva os dados para algum lugar.

        // instancias do tipo fornecedor
        Fornecedor fornecedor1 = new Fornecedor(01, "Lojol", "11.616.777/0001-11", "loja.ol@hotmai.com");
        Fornecedor fornecedor2 = new Fornecedor(02, "BBidas xtd.", "33.666.020/0001-00", "b.b.x@hotmai.com");
        Fornecedor fornecedor3 = new Fornecedor(03, "Cabides de Loja", "17.322.001/0001-13", "cab.ideslo@hotmai.com");
        Fornecedor fornecedor4 = new Fornecedor(04, "Loja Um", "10.125.033/0001-22", "loja.1@hotmai.com");
        Fornecedor fornecedor5 = new Fornecedor(05, "Empresa4", "20.675.000/0001-33", "empresa.4@hotmai.com");

        // Lista de fornecedores e atribuí os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(fornecedor1);
        listaFornecedores.Add(fornecedor2);
        listaFornecedores.Add(fornecedor3);
        listaFornecedores.Add(fornecedor4);
        listaFornecedores.Add(fornecedor5);

        ViewBag.listaFornecedores = listaFornecedores; // ViewBag = tipo uma "bolsa" que leva os dados para algum lugar.


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
