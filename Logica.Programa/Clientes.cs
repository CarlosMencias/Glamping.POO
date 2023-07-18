namespace Logica.Programa
{
    public abstract class Clientes
    {
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }

        public string? Correo { get; set; }
        public int Celular { get; set; }
        public int Huespedes { get; set; }

        public override string ToString()
        {
            return $"Nombre.............:{Nombre}\n" +
                   $"Apellido...........:{Apellido}" +
                   $"Correo.............:{Correo}" +
                   $"Celular............:{Celular}" +
                   $"Huespedes..........:{Huespedes}";
        }

        public abstract decimal GetValueToPay();
    }

    
}