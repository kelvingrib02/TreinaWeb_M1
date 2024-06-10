using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TWTodoList.Models;
using TWTodoList.ViewModels;

namespace TWTodoList.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        var todo = new Todo 
        {
            Title = "Estudar ASP .NET Core", 
            Description="Concluir o curso de ASP .NET Core da TreinaWeb"
        };
        ViewBag.Todo = todo;

        TempData["message"] = "Mensagem vinda da action Index";

        return View();
    }

    public IActionResult Message()
    {
        return View();
    }

    public IActionResult ViewModel()
    {
        var Todo = new Todo 
        {
            Title = "Estudar ASP .NET Core", 
            Description="Concluir o curso de ASP .NET Core da TreinaWeb"
        };

        var ViewModel = new DetailsTodoViewModel
        {
            Todo = Todo,
            PageTitle = "Detalhes da Tarefa"
        };
        return View(ViewModel);
    }
}