using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Ventas.Contracts;
using Ventas.Controllers;
using Ventas.Implementations;

namespace Ventas.Program
{
    public class ControllerFactory : DefaultControllerFactory
    {
        public IClientesService _clientesService = new ClientesService();


        public override IController CreateController (System.Web.Routing.RequestContext requestContext, string controllerName)         
        {
            string controllername = requestContext.RouteData.Values["controller"].ToString();

            if (controllername.Equals("Inicio"))
            {
                IController controller = Activator.CreateInstance(typeof(InicioController)) as IController;
                return controller;
            }
            else if (controllername.Equals("Clientes"))
            {
                IController controller = Activator.CreateInstance(typeof(ClientesController), _clientesService) as IController;
                return controller;
            }

            return new InicioController();
        }

        public override void ReleaseController(IController controller)
        {
            IDisposable dispose = controller as IDisposable; if (dispose != null)
            {
                dispose.Dispose();
            }
        }
    }   
}
