namespace Dominio.Revisiones;

public sealed class EstadoRevision
{
    public static readonly EstadoRevision NoRevisado = new("NoRevisado");

    public static readonly EstadoRevision EsperandoRevision = new("EsperandoRevision");

    public static readonly EstadoRevision RevisionAprobada = new("RevisionAprobada");

    public static readonly EstadoRevision RevisionNoAprobada = new("RevisionNoAprobada");

    public string Valor { get; }

    private EstadoRevision(string valor)
    {
        Valor = valor;
    }

    public override string ToString()
    {
        return Valor;
    }
}
