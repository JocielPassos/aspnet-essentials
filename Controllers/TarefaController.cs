using Microsoft.AspNetCore.Mvc;

namespace GerenciaTarefa.Controllers; //Namespace é como se fosse uma biblioteca

public class TarefaController:Controller{

    //View = Página Web (Site)
    //funções
    public ActionResult Index(){

        ViewData["Cabeçalho"] = "Tarefa Diaria";
        ViewData["Titulo"]    = "Planeja Aula Senai";
        ViewData["Descrição"] = "Criar nova PEUC";

        return View();
    }
}