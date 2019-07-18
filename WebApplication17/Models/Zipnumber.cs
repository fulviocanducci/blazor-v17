using System.ComponentModel.DataAnnotations;
namespace Models
{
    public class Zipnumber
    {
        [Required(ErrorMessage = "Digite o CEP" )]
        [RegularExpression("[0-9]{5}-[0-9]{3}", ErrorMessage = "Formato inválido, exemplo: 00000-000")]
        public string Number { get; set; }
    }
}
