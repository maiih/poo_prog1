using System.ComponentModel.DataAnnotations;

namespace poo.Models;

public class Customer // classe
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EmailAddress { get; set; }

    public bool Validate() //método
    {
        if (string.IsNullOrEmpty(EmailAddress)
            || string.IsNullOrEmpty(FirstName)
            || string.IsNullOrEmpty(LastName)
        ) return false;

        return true;
    }
}