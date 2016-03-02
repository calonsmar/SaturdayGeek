using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Contracts;
using Ventas.Models;

namespace Ventas.Implementations
{
    public class ClientesService : IClientesService
    {
        public List<Models.Cliente> getClientes()
        {
            Cliente cliente;
            List<Cliente> clientes = new List<Cliente>();

            cliente = new Cliente { id = 100, nombre = "Pedro", apellido1 = "Pérez", apellido2 = "Gómez", telefono = "111111111" };
            clientes.Add(cliente);

            cliente = new Cliente { id = 101, nombre = "Ana", apellido1 = "García", apellido2 = "Prados", telefono = "222222222" };
            clientes.Add(cliente);

            cliente = new Cliente { id = 102, nombre = "María", apellido1 = "de la Fuente", apellido2 = "Vázquez", telefono = "333333333" };
            clientes.Add(cliente);

            cliente = new Cliente { id = 103, nombre = "Óscar", apellido1 = "García", apellido2 = "Torres", telefono = "333333333" };
            clientes.Add(cliente);

            cliente = new Cliente { id = 104, nombre = "Ana Belén", apellido1 = "Casas", apellido2 = "Miras", telefono = "333333333" };
            clientes.Add(cliente);

            return clientes;
        }
    }
}
