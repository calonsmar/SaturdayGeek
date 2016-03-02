using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ventas.Models;

namespace Ventas.Contracts
{
    public interface IClientesService
    {
        List<Cliente> getClientes();
    }
}
