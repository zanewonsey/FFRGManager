using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommonUtil;
using FFRGManagerService.Database;

namespace FFRGManagerService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {

        private DBAccess DBControl;
        [HttpGet("/api/[controller]/List/")]
        public IActionResult AllOrders()
        {
            List<Order> l_sp = DBAccess.OrdersList();
            return Ok(l_sp);
        }

        // TODO
        [HttpGet("/api/[controller]/Single/")]
        public IActionResult AnOrder(Order order)
        {
            Order l_sp = new Order("16159 Mercury Dr.", "Grand Haven", "Michigan", "49417", 0);
            return Ok(l_sp);
        }

        [HttpPut("/api/[controller]/Create/")]
        public IActionResult CreateOrder(Order order)
        {
            IActionResult res = Ok();
            if (!DBAccess.AddOrder(order)) res = NotFound(DBAccess.errormeme);
            return res;
        }

        [HttpPost("/api/[controller]/Update/")]
        public IActionResult UpdateOrder(Order order)
        {
            DBAccess.UpdateOrder(order);
            return Ok();
        }

        [HttpDelete("/api/[controller]/Delete/")]
        public IActionResult DeleteOrder(Order order)
        {
            DBAccess.DeleteOrder(order);
            return Ok();
        }

        [HttpGet("/api/[controller]/test/")]
        public IActionResult TestOrder(Order order)
        {
            //DBAccess.ConnectionTest();
            return Ok(DBAccess.ConnectionTest());
        }
    }
}
