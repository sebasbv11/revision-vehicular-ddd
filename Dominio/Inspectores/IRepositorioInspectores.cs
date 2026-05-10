namespace Dominio.Inspectores;

public interface IRepositorioInspectores
{
    Task<Inspector?> ObtenerPorId(Guid id);

    Task Agregar(Inspector inspector);
}