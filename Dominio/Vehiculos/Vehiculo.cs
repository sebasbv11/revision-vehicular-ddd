using Dominio.Compartido;

namespace Dominio.Vehiculos;

public sealed class Vehiculo
{
    public Guid Id { get; private set; }

    public Placa Placa { get; private set; }

    public string Marca { get; private set; }

    public string Modelo { get; private set; }

    public int Anio { get; private set; }

    public Guid PropietarioId { get; private set; }

    public Vehiculo(Guid id, Placa placa, string marca, string modelo, int anio, Guid propietarioId)
    {
        Id = id;
        Placa = placa;
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
        PropietarioId = propietarioId;
    }
}
