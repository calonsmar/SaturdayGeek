using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ventas.Contracts;
using Ventas.Models;

namespace Ventas.Controllers
{
    public class ClientesController : Controller
    {
        IClientesService _clientesService;

        public ClientesController(IClientesService clientesService)
        {
            _clientesService = clientesService;
        }

        public ActionResult ListarClientes()
        {
            ClientesViewModel clientesVM = new ClientesViewModel();
            cargarClientes(ref clientesVM);

            //clientesVM.clientes = _clientesService.getClientes();

            return View("Clientes", clientesVM);
        }

        public ActionResult GuardarClientes(ClientesViewModel clientesVM)
        {
            return View("Clientes", clientesVM);
        }


        private void cargarClientes(ref ClientesViewModel clientesVM)
        {
            Cliente cliente;

            cliente = new Cliente { id = 100, nombre = "Pedro", apellido1 = "Pérez", apellido2 = "Gómez", telefono = "111111111" };
            clientesVM.clientes.Add(cliente);

            cliente = new Cliente { id = 100, nombre = "Ana", apellido1 = "García", apellido2 = "Prados", telefono = "222222222" };
            clientesVM.clientes.Add(cliente);

            cliente = new Cliente { id = 100, nombre = "María", apellido1 = "de la Fuente", apellido2 = "Vázquez", telefono = "333333333" };
            clientesVM.clientes.Add(cliente);           
        }

    }
}
