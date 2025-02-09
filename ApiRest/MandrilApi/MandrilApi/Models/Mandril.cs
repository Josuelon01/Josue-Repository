namespace MandrilApi.Models;

public class Mandril
{
    public int Id { get; set; } //id del mandril

    public string Name { get; set; } = string.Empty; // Nombre del mandril ( Se le pone string.Empty porque el nombre su valor empieza vacio.

    public string Apellido { get; set; } = string.Empty; // Apellido del mandril ( Se le pone string.Empty porque el nombre su valor empieza vacio.

    public List <Habilidad>? Habilidades { get; set; } = new List<Habilidad>(); // Se crea una clase list porque se va a instanciar de la clase habilidad una lista de propiedades de las habilidades del mandril
                                                                                // Se le pone "?" porque hay valores que su valor es null y esto permite que lo acepte.
                                                                                // se le agrega = new List<Habilidad>(); el tipi del tutorial dijo que es mejor asi
}
