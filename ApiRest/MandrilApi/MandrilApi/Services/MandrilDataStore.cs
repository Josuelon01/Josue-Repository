using MandrilApi.Models; // se trae la carperta Models del proyecto MandrilApi porque vamos a utilizar una lista con los datos de los mandriles en la linea de codigo 7

namespace MandrilApi.Services; // esta es la base de datos almacenada en una memoria

public class MandrilDataStore
{
    public List<Mandril> Mandriles { get; set; } // se trae de la carpeta models la clase mandril porque se va a crear una lista llamada mandriles y no se pone ? porque no vamos aceptar valores null

    public static MandrilDataStore Current { get; } = new MandrilDataStore(); // Patron Singleton, Solo Lectura

    public MandrilDataStore()
    {
        Mandriles = new List<Mandril>()
        {
            new Mandril()
            {
                Id = 1,
                Name = "Mini Mandril",
                Apellido = "Fernandez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Saltar",
                        Potencia = Habilidad.EPotencia.Suave
                    }
                }
            },
            new Mandril()
            {
                Id = 2,
                Name = "Yo JosueMandril",
                Apellido = "Martinez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Ejercitar",
                        Potencia = Habilidad.EPotencia.RePotente
                    }
                }
            },
            new Mandril()
            {
                Id = 3,
                Name = "Supermandril",
                Apellido = "Rodriguez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Saltar",
                        Potencia = Habilidad.EPotencia.Moderado
                    },
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Caminar",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad()
                    {
                        Id = 3,
                        Nombre = "Gritar",
                        Potencia = Habilidad.EPotencia.RePotente
                    }
                }
            },
            new Mandril()
            {
                Id = 4,
                Name = "MandrilRápido",
                Apellido = "Gonzalez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Correr",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Escalar",
                        Potencia = Habilidad.EPotencia.Moderado
                    },
                    new Habilidad()
                    {
                        Id = 3,
                        Nombre = "Agarrar",
                        Potencia = Habilidad.EPotencia.Intenso
                    }
                }
            },
            new Mandril()
            {
                Id = 5,
                Name = "MandrilFeroz",
                Apellido = "Duran",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Morder",
                        Potencia = Habilidad.EPotencia.Extremo
                    },
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Rasguñar",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad()
                    {
                        Id = 3,
                        Nombre = "Cargar",
                        Potencia = Habilidad.EPotencia.Moderado
                    }
                }
            },
            new Mandril()
            {
                Id = 6,
                Name = "MandrilSilencioso",
                Apellido = "Lopez",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Esquivar",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Acechar",
                        Potencia = Habilidad.EPotencia.RePotente
                    },
                    new Habilidad()
                    {
                        Id = 3,
                        Nombre = "Atacar Rapido",
                        Potencia = Habilidad.EPotencia.Extremo
                    }
                }
            },
            new Mandril()
            {
                Id = 7,
                Name = "MandrilPoderoso",
                Apellido = "Castillo",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Golpear",
                        Potencia = Habilidad.EPotencia.Extremo
                    },
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Empujar",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad()
                    {
                        Id = 3,
                        Nombre = "Correr",
                        Potencia = Habilidad.EPotencia.Intenso
                    }
                }
            },
            new Mandril()
            {
                Id = 8,
                Name = "MandrilMagico",
                Apellido = "Reyes",
                Habilidades = new List<Habilidad>()
                {
                    new Habilidad()
                    {
                        Id = 1,
                        Nombre = "Hechizar",
                        Potencia = Habilidad.EPotencia.Extremo
                    },
                    new Habilidad()
                    {
                        Id = 2,
                        Nombre = "Poder",
                        Potencia = Habilidad.EPotencia.Intenso
                    },
                    new Habilidad()
                    {
                        Id = 3,
                        Nombre = "Trepar",
                        Potencia = Habilidad.EPotencia.Suave
                    }
                }
            }
        };
    }
}
