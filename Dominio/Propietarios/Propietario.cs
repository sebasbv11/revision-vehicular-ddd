namespace Dominio.Propietarios;

public sealed class Propietario
{
    public Guid Id { get; private set; }

    public string Nombre { get; private set; }

    public string Cedula { get; private set; }

    public string Correo { get; private set; }

    public string Telefono { get; private set; }

    public Propietario(Guid id, string nombre, string cedula, string correo, string telefono)
    {
        Id = id;
        Nombre = nombre;
        Cedula = cedula;
        Correo = correo;
        Telefono = telefono;
    }
}
