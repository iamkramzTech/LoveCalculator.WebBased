using System.ComponentModel.DataAnnotations;

namespace LoveCalculator.WebBased.Models
{
    public class LoveCalculatorModel
    {
        [Required(ErrorMessage = "Please Enter your Name")]
        public string YourName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter your Partner's Name")]
        public string PartnersName { get; set; } = string.Empty;
        public string? Result { get; set; }
    }
}
