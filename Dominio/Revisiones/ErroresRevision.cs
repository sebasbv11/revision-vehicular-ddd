namespace Dominio.Revisiones;

public static class ErroresRevision
{
    public static readonly string RevisionYaAprobada = "La revisión ya fue aprobada.";

    public static readonly string RevisionYaRechazada = "La revisión ya fue rechazada.";

    public static readonly string RevisionNoPuedeAprobarse =
        "La revisión no puede aprobarse porque existen pruebas fallidas.";

    public static readonly string RevisionSinInspector =
        "La revisión debe tener un inspector asignado.";
}
