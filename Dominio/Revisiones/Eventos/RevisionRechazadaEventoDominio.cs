using Dominio.Abstracciones;

namespace Dominio.Revisiones.Eventos;

public sealed class RevisionRechazadaEventoDominio : IEventoDominio
{
    public Guid RevisionId { get; }

    public RevisionRechazadaEventoDominio(Guid revisionId)
    {
        RevisionId = revisionId;
    }
}
