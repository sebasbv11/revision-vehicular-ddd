namespace Dominio.Vehiculos;

public interface IRepositorioVehiculos
{
    Task<Vehiculo?> ObtenerPorId(Guid id);

    Task Agregar(Vehiculo vehiculo);
}
