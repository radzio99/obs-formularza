using System.ComponentModel.DataAnnotations;

namespace Formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Proszę podaj Imie")]
        [MinLength(2, ErrorMessage = "Imie musi zawierać co najmniej 2 znaki")]
        public string Imie { get; set; }

        [Required(ErrorMessage = "Proszę podaj Naziwsko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi zawierać co najmniej 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Proszę podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}", ErrorMessage = "Podaj poprawny adres email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Proszę podaj hasło")]
        [MinLength(8, ErrorMessage = "Hasło musi zawierać co najmniej 8 znaków")]
        [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d).{8,}$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą i małą literę")]
        [DataType(DataType.Password)]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Proszę potwierdzić hasło")]
        [Compare("Haslo", ErrorMessage = "Hasło musi być takie samo")]
        [DataType(DataType.Password)]
        public string PotwierdzenieHasla { get; set; }

        [Required(ErrorMessage = "Proszę podaj numer telefonu")]
        [Phone(ErrorMessage = "Podaj poprawny numer telefonu")]
        public string NumerTelefonu { get; set; }

        [Required(ErrorMessage = "Proszę podaj swój wiek")]
        [Range(11, 80, ErrorMessage = "Wiek musi być między 11 a 80")]
        public int Wiek { get; set; }

        public string Miasto { get; set; }
    }

    public enum MiastoEnum
    {
        Gdańsk,
        Warszawa,
        Kraków,
        Poznan,
        Katowice
    }
}

