// --------------------------------------------------------------------------------------------------------------------
// <copyright file=" DeleteProductHandler.cs" company="EPIC Software">
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

namespace Epic.Sample.Application.Handlers
{
    using Epic.Sample.Application.Commands;
    using Epic.Sample.Domain.Repository;

    using MediatR;

    /// <summary>
    /// Class DeleteProductHandler.
    /// Implements the <see cref="MediatR.RequestHandler{Epic.Sample.Application.Commands.DeleteProduct}" />
    /// </summary>
    /// <seealso>
    ///     <cref>MediatR.RequestHandler{Epic.Sample.Application.Commands.DeleteProduct}</cref>
    /// </seealso>
    /// <autogeneratedoc />
    public class DeleteProductHandler : RequestHandler<DeleteProduct>
    {
        /// <summary>
        /// The repository
        /// </summary>
        /// <autogeneratedoc />
        private readonly IProductRepository repository;

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteProductHandler" /> class.
        /// </summary>
        /// <param name="uow">The uow.</param>
        /// <autogeneratedoc />
        public DeleteProductHandler(IUnitOfWork uow) => this.repository = uow.Repository<IProductRepository>();

        /// <summary>
        /// Handles the specified request.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <autogeneratedoc />
        protected override void Handle(DeleteProduct request) => this.repository.Delete(request.Id);
    }
}