// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var habitacion = new Habitaciones();

public class Habitaciones
{
    public int Id;
    public int Numero;
    public decimal Area;
    public DateTime Fecha_reserva;
}

public class Estados
{
    public int Id;
    public string? Estado;
    public List<Habitaciones>? Habitaciones;
}

public class Temas
{
    public int Id;
    public string? TipoTema;
    public List<Habitaciones>? Habitaciones;
}

public class Cliente
{
    public int Id;
    public string? Nombre;
    public int Documento;
}


