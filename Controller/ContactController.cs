using Microsoft.AspNetCore.Mvc;

namespace ShoeStoreApp.Controller;

public class ContactController: Microsoft.AspNetCore.Mvc.Controller

{
    public IActionResult Index()
    {
        return View();
    }
    
}