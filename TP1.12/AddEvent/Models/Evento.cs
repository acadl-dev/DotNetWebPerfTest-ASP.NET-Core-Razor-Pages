using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AddEvent.Models
{
    public class Evento : IValidatableObject
    {
        public int Id { get; set; }
        //Constraints
        [Display(Name = "Nome do evento")]
        [Required(ErrorMessage = "Nome do evento é obrigatório")]
        [MinLength(2, ErrorMessage = "Nome tem no mínimo dois caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Data é obrigatório")]
        public DateTime Data { get; set; }

        [Required(ErrorMessage = "Local é obrigatório")]
        public string Local { get; set; }

        public Evento() { }

        public Evento(int id, string titulo, DateTime data, string local)
        {
            Id = id;
            Titulo = titulo;
            Data = data;
            Local = local;
        }

        public override string ToString()
        {
            return Id + " " + Titulo + " " + Data + " " + Local;
        }

        // Validação personalizada para verificar se a data é passada
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Data < DateTime.Now)
            {
                yield return new ValidationResult(
                    "A data do evento não pode ser no passado.",
                    new[] { nameof(Data) }
                );
            }
        }
    }
}
