public class Cliente
{
    public string Nombre { get; set; }
    public string DNI { get; set; }
    public string Estado { get; set; }
    public string Origen { get; set; }
    public string Destino { get; set; }
    public string TipoDeViaje { get; set; }

    public Cliente(string nombre, string dni, string estado, string origen, string destino, string tipoDeViaje)
    {
        Nombre = nombre;
        DNI = dni;
        Estado = estado;
        Origen = origen;
        Destino = destino;
        TipoDeViaje = tipoDeViaje;
    }

public override string ToString()
        {
            return $"{Nombre} - {Estado}";
        }
    }

