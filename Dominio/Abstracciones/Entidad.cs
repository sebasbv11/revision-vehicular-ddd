namespace Dominio.Abstracciones;

public abstract class Entidad
{
    private readonly List<object> _eventosDominio = [];

    public Guid Id { get; protected set; }

    public IReadOnlyCollection<object> EventosDominio =>
        _eventosDominio.AsReadOnly();

    protected void AgregarEventoDominio(object eventoDominio)
    {
        _eventosDominio.Add(eventoDominio);
    }

    public void LimpiarEventosDominio()
    {
        _eventosDominio.Clear();
    }
}