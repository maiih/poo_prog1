using System.ComponentModel.DataAnnotations;

namespace poo.Models;

// tipo espécie, cor, aroma, tamanho e valores 

public class Flower // classe
{
    public int FlowerId { get; set; }

    public string? Tipo { get; set; }

    public string? Especie { get; set; }

    public string? Cor { get; set; }

    public string? Aroma { get; set; }

    public int? Tamanho { get; set; }

    public double Valor { get; set; }


    public bool Validate() //método
    {
        if (string.IsNullOrEmpty(Tipo)
            || string.IsNullOrEmpty(Especie)
            || string.IsNullOrEmpty(Cor)
            || string.IsNullOrEmpty(Aroma)
        ) return false;

        return true;
    }
}