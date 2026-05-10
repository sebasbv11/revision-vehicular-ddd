namespace Dominio.Compartido;

public sealed record Placa
{
    public string Valor { get; }

    public Placa(string valor)
    {
        if (string.IsNullOrWhiteSpace(valor))
        {
            throw new ArgumentException("La placa no puede estar vacía.");
        }

        if (valor.Length < 6)
        {
            throw new ArgumentException("La placa no tiene un formato válido.");
        }

        Valor = valor;
    }

    public override string ToString()
    {
        return Valor;
    }
}
