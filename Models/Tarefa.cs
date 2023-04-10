//Conjunto de Classes
namespace GerenciaTarefa.Models;
//Classes são um conjunto de objetos
public class Tarefa{
public int Id { get; set; } // int inteiro

public string? Cabeçalho { get; set; }
public string? Título { get; set; }
public string? Descricao { get; set; } // string texto
public bool TaCompleta { get; set; }

}