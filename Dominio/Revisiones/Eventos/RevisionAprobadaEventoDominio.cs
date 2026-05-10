using Dominio.Abstracciones;

namespace Dominio.Revisiones.Events;

public sealed class RevisionAprobadaEventoDominio
    : IEventoDominio
{
    public Guid RevisionId { get; }

    public RevisionAprobadaEventoDominio(Guid revisionId)
    {
        RevisionId = revisionId;
    }
}