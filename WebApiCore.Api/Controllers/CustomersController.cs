using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WebApiCore.Data.Models;
using WebApiCore.Data.Repository;

namespace WebApiCore.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        public IRepository<Customer> contextCustomers { get; private set; }

        public CustomersController(IRepository<Customer> contextCustomers)
        {
            this.contextCustomers = contextCustomers;
        }

        /// <summary>
        /// Get All Customers
        /// </summary>
        /// <remarks>
        /// Sample request:
        /// 
        ///     GET: /api/customers    
        /// 
        /// </remarks>
        /// <returns>A list of existed customers</returns>
        /// <response code="200">Succes</response>
        /// <response code="400">If error occurs</response>
        /// <response code="404">If no customers in database</response>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            List<Customer> result;

            try
            {
                result = contextCustomers.All.ToList();
                if (result.Count == 0)
                {
                    return NotFound();
                }
            }
            catch
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<Customer> Get(int id)
        {
            return contextCustomers.FindById(id);
        }

        [HttpPost]
        public void Post([FromQuery]Customer value)
        {
            contextCustomers.Update(value);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Customer value)
        {
            contextCustomers.Add(value);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Customer entity = contextCustomers.FindById(id);
            contextCustomers.Delete(entity);
        }
    }
}
