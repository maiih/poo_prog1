using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using poo.Models;

namespace poo.Controllers;

public class FlowerController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        int id = 1;

        Flower Rosa = new Flower
        {
            FlowerId = ++id,
            Tipo = "Flor",
            Especie = "Rosa",
            Cor = "Vermelha",
            Aroma = "Doce",
            Tamanho = 40,
            Valor = 15.2
        };


        Flower Tulipa = new Flower
        {
            FlowerId = ++id,
            Tipo = "Flor",
            Especie = "Tulipa",
            Cor = "Amarela",
            Aroma = "Suave",
            Tamanho = 35,
            Valor = 12.5
        };

        Flower Orquidea = new Flower
        {
            FlowerId = ++id,
            Tipo = "Flor",
            Especie = "Orquídea",
            Cor = "Roxa",
            Aroma = "Leve",
            Tamanho = 30,
            Valor = 25.0
        };

        Flower Girassol = new Flower
        {
            FlowerId = ++id,
            Tipo = "Flor",
            Especie = "Girassol",
            Cor = "Amarela",
            Aroma = "Natural",
            Tamanho = 150,
            Valor = 18.0
        };

        Flower Lirio = new Flower
        {
            FlowerId = ++id,
            Tipo = "Flor",
            Especie = "Lírio",
            Cor = "Branca",
            Aroma = "Intenso",
            Tamanho = 60,
            Valor = 20.0
        };

        Flower Margarida = new Flower
        {
            FlowerId = ++id,
            Tipo = "Flor",
            Especie = "Margarida",
            Cor = "Branca",
            Aroma = "Suave",
            Tamanho = 25,
            Valor = 8.0
        };

        Flower Cravo = new Flower
        {
            FlowerId = ++id,
            Tipo = "Flor",
            Especie = "Cravo",
            Cor = "Rosa",
            Aroma = "Marcante",
            Tamanho = 45,
            Valor = 10.0
        };

        Flower Hortensia = new Flower
        {
            FlowerId = ++id,
            Tipo = "Flor",
            Especie = "Hortênsia",
            Cor = "Azul",
            Aroma = "Leve",
            Tamanho = 70,
            Valor = 22.0
        };

        Flower Lavanda = new Flower
        {
            FlowerId = ++id,
            Tipo = "Flor",
            Especie = "Lavanda",
            Cor = "Lilás",
            Aroma = "Relaxante",
            Tamanho = 50,
            Valor = 14.0
        };

        Flower Jasmim = new Flower
        {
            FlowerId = ++id,
            Tipo = "Flor",
            Especie = "Jasmim",
            Cor = "Branca",
            Aroma = "Muito doce",
            Tamanho = 20,
            Valor = 16.0
        };

        List<Flower> Flower = new List<Flower>();

        Flower.Add(Rosa);
        Flower.Add(Tulipa);
        Flower.Add(Orquidea);
        Flower.Add(Girassol);
        Flower.Add(Lirio);
        Flower.Add(Margarida);
        Flower.Add(Cravo);
        Flower.Add(Hortensia);
        Flower.Add(Lavanda);
        Flower.Add(Jasmim);

        return View(Flower);
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