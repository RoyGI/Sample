// --------------------------------------------------------------------------------------------------------------------
// <copyright file=" ProductController.cs" company="EPIC Software">
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <https://www.gnu.org/licenses/>.
// </copyright>
// <summary>
//  Contributors: Roy Gonzalez
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace Epic.Sample.Server.Controllers
{
    using System;
    using System.Threading.Tasks;

    using Epic.Sample.Application.Commands;
    using Epic.Sample.Application.Queries;

    using MediatR;

    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// Class ProductController.
    /// Implements the <see cref="Microsoft.AspNetCore.Mvc.Controller" />
    /// </summary>
    /// <seealso cref="Microsoft.AspNetCore.Mvc.Controller" />
    /// <autogeneratedoc />
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        /// <summary>
        /// The mediator
        /// </summary>
        /// <autogeneratedoc />
        private readonly IMediator mediator;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductController" /> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Adds the specified productUpdate.
        /// </summary>
        /// <param name="product">The productUpdate.</param>
        /// <autogeneratedoc />
        [HttpPost("add")]
        public void Add([FromBody] NewProduct product)
        {
            this.mediator.Send(product);
        }

        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <autogeneratedoc />
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            this.mediator.Send(new DeleteProduct { Id = id });
        }

        /// <summary>
        /// Gets all.
        /// </summary>
        /// <returns>Task IActionResult;.</returns>
        /// <autogeneratedoc />
        [HttpGet("all")]
        public async Task<IActionResult> GetAll()
        {
            var result = await this.mediator.Send(
                             new QueryProduct { Query = "query{all_products{identity,name,quantity,price}}" });
            if (result.Errors?.Count > 0)
            {
                return this.BadRequest(result);
            }

            return this.Ok(result);
        }

        /// <summary>
        /// Puts the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <param name="productUpdate">The productUpdate.</param>
        /// <autogeneratedoc />
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] ProductUpdate productUpdate)
        {
            this.mediator.Send(
                new EditProduct { Price = productUpdate.Price, ProductId = Guid.Parse(id), Name = productUpdate.Name });
        }

        /// <summary>
        /// Queries the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>Task IActionResult</returns>
        /// <autogeneratedoc />
        [HttpGet("query")]
        public async Task<IActionResult> Query([FromQuery] QueryProduct query)
        {
            var result = await this.mediator.Send(query);
            if (result.Errors?.Count > 0)
            {
                return this.BadRequest(result);
            }

            return this.Ok(result);
        }
    }
}