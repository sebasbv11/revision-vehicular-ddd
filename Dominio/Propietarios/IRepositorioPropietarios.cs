namespace Dominio.Propietarios;

public interface IRepositorioPropietarios
{
    Task<Propietario?> ObtenerPorId(Guid id);

    Task Agregar(Propietario propietario);
}
