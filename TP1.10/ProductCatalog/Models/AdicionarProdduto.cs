using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models
{
    public class AdicionarProdduto
    {
        public int Id { get; set; }
        //Constraints
        [Display(Name = "Nome do produto")]
        [Required(ErrorMessage = "Nome obrigatório")]
        [MinLength(2, ErrorMessage = "Nome tem no mínimo dois caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Valor obrigatório")]
        public double Valor { get; set; }

        public AdicionarProdduto() { }

        public AdicionarProdduto(int id, string nome, double valor)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
        }

        public override string ToString()
        {
            return Id + " " + Nome + " " + Valor;
        }
    }
}
