using Microsoft.AspNetCore.Mvc.RazorPages;

namespace desafiodtc_backend.Pages.Equipo;

public class EquipoIdModel : PageModel
{
    
    public string Id { get; set; }
    
    public void OnGet(string id)
    {
        Id = id;
    }
}