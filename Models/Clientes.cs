﻿using System.ComponentModel.DataAnnotations;

namespace RegistroCliente.Models
{
    public class Clientes
    {
        [Key]
        public int ClientesId { get; set; }
        public string Nombres { get; set; }

        public int Telefono { get; set; }
        public int Celular { get; set; }
        public int Rnc { get; set; }
        public string Gmail { get; set; }
        public string Direccion { get; set; }
    }
}
