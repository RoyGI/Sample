// --------------------------------------------------------------------------------------------------------------------
// <copyright file=" EditProduct.cs" company="EPIC Software">
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

namespace Epic.Sample.Application.Commands
{
    using System;

    using MediatR;

    /// <summary>
    /// Class EditProduct.
    /// Implements the <see cref="MediatR.IRequest" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest" />
    /// <autogeneratedoc />
    public class EditProduct : IRequest
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        /// <autogeneratedoc />
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>The price.</value>
        /// <autogeneratedoc />
        public float Price { get; set; }

        /// <summary>
        /// Gets or sets the product identifier.
        /// </summary>
        /// <value>The product identifier.</value>
        /// <autogeneratedoc />
        public Guid ProductId { get; set; }

        /// <summary>
        /// Gets or sets the units.
        /// </summary>
        /// <value>The units.</value>
        /// <autogeneratedoc />
        public float Units { get; set; }
    }
}