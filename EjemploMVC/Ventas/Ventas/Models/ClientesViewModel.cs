using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ventas.Models
{
    public class ClientesViewModel
    {
        public ClientesViewModel()
        {
            clientes = new List<Cliente>();
        }

        public List<Cliente> clientes { get; set; }
    }
}
