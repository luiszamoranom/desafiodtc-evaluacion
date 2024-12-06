using Microsoft.AspNetCore.Mvc.RazorPages;

namespace desafiodtc_backend.Pages.Evaluador;

public class Id : PageModel
{
    public string idEvaluador {get; set;}
    public void OnGet(string idEvaluador)
    {
        this.idEvaluador = idEvaluador;
    }
}