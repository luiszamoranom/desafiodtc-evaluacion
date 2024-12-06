using Microsoft.AspNetCore.Mvc.RazorPages;

namespace desafiodtc_backend.Pages.Prototipo;

public class Index : PageModel
{
    public String idEvaluador {get; set;}
    
    public void OnGet(String idEvaluador)
    {
        this.idEvaluador = idEvaluador;
    }
}