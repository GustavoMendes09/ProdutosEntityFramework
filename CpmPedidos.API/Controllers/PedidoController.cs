using CpmPedido.Interface;
using CpmPedidos.Domain;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CpmPedidos.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PedidoController : AppBaseController
    {
        public PedidoController(IServiceProvider serviceProvider): base(serviceProvider)
        {
        }

        [HttpGet]
        [Route("ticket-maximo")]
        public decimal TicketMaximo()
        {
            var rep = (IPedidoRepository)ServiceProvider.GetService(typeof(IPedidoRepository));
            return rep.TicketMaximo();
        }

        [HttpGet]
        [Route("por-cliente")]
        public dynamic PedidosClientes()
        {
            var rep = (IPedidoRepository)ServiceProvider.GetService(typeof(IPedidoRepository));
            return rep.PedidosClientes();
        }

    }
}
