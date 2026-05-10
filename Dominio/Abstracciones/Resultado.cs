namespace Dominio.Abstracciones;

public class Resultado
{
    public bool EsExitoso { get; }

    public Error Error { get; }

    protected Resultado(bool esExitoso, Error error)
    {
        EsExitoso = esExitoso;
        Error = error;
    }

    public static Resultado Exito()
    {
        return new Resultado(true, Error.Ninguno);
    }

    public static Resultado Fallo(Error error)
    {
        return new Resultado(false, error);
    }
}
