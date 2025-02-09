namespace MandrilApi.Models;

public class Habilidad
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;

    public EPotencia Potencia { get; set; }

    public enum EPotencia // enum se utiliza para elaborar una lista de constantes o variables que su valor no cambia.
    {
        Suave,

        Moderado,

        Intenso,

        RePotente,

        Extremo
    }
}
