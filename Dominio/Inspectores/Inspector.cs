namespace Dominio.Inspectores;

public sealed class Inspector
{
    public Guid Id { get; private set; }

    public string Nombre { get; private set; }

    public string CodigoEmpleado { get; private set; }

    public Inspector(Guid id, string nombre, string codigoEmpleado)
    {
        Id = id;
        Nombre = nombre;
        CodigoEmpleado = codigoEmpleado;
    }
}
