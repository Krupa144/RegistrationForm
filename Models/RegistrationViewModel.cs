using System;
using System.ComponentModel.DataAnnotations;

public class RegistrationViewModel
{
    [Required(ErrorMessage = "Imię jest wymagane.")]
    [MinLength(2, ErrorMessage = "Imię musi mieć przynajmniej 2 znaki.")]
    public string FirstName { get; set; }

    [Required(ErrorMessage = "Nazwisko jest wymagane.")]
    [MinLength(2, ErrorMessage = "Nazwisko musi mieć przynajmniej 2 znaki.")]
    public string LastName { get; set; }

    [Required(ErrorMessage = "E-mail jest wymagany.")]
    [EmailAddress(ErrorMessage = "Niepoprawny format e-mail.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Hasło jest wymagane.")]
    [MinLength(8, ErrorMessage = "Hasło musi mieć przynajmniej 8 znaków.")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [Required(ErrorMessage = "Potwierdzenie hasła jest wymagane.")]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Hasła muszą się zgadzać.")]
    public string ConfirmPassword { get; set; }

    [Required(ErrorMessage = "Numer telefonu jest wymagany.")]
    [Phone(ErrorMessage = "Niepoprawny numer telefonu.")]
    public string PhoneNumber { get; set; }

    [Required(ErrorMessage = "Wiek jest wymagany.")]
    [Range(10, 80, ErrorMessage = "Wiek musi być między 10 a 80.")]
    public int Age { get; set; }

    [Required(ErrorMessage = "Miasto jest wymagane.")]
    public CityOptions City { get; set; }
}

public enum CityOptions
{
    Warszawa = 1,
    Krakow = 2,
    Wroclaw = 3,
    Poznan = 4,
    Gdansk = 5
}

