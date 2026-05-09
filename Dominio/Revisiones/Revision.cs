namespace Dominio.Revisiones;

public sealed class Revision
{
    public Guid Id { get; private set; }

    public Guid VehiculoId { get; private set; }

    public DateTime FechaRevision { get; private set; }

    public EstadoRevision Estado { get; private set; }

    public bool ResultadoGases { get; private set; }

    public bool ResultadoFrenos { get; private set; }

    public bool ResultadoLuces { get; private set; }

    public Guid InspectorId { get; private set; }

    public Revision(Guid id, Guid vehiculoId, DateTime fechaRevision, Guid inspectorId)
    {
        Id = id;
        VehiculoId = vehiculoId;
        FechaRevision = fechaRevision;
        InspectorId = inspectorId;

        Estado = EstadoRevision.NoRevisado;
    }

    public void IniciarRevision()
    {
        Estado = EstadoRevision.EsperandoRevision;
    }

    public void Aprobar()
    {
        if (!ResultadoGases || !ResultadoFrenos || !ResultadoLuces)
        {
            throw new Exception("La revisión no puede aprobarse.");
        }

        Estado = EstadoRevision.RevisionAprobada;
    }

    public void Rechazar()
    {
        Estado = EstadoRevision.RevisionNoAprobada;
    }
}
