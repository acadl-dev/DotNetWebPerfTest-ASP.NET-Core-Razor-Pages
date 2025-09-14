using AddEvent.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AddEvent.Pages
{
    public class AdicionarEventoModel : PageModel
    {
        // Delegate que será chamado sempre que um evento for criado
        public static Action<Evento> OnEventoCriado;

       

        [BindProperty]
        public Evento Evento { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }
            // Dispara o delegate (registrando no console, por exemplo)
            OnEventoCriado?.Invoke(Evento);

            // Você ainda pode escrever no console diretamente, se quiser
            Console.WriteLine($"Evento criado: {Evento.Titulo} em {Evento.Data}");
        }
    }
}
