// --------------------------------------------------------------------------------------------------------------------
// <copyright file=" DeleteProduct.cs" company="EPIC Software">
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
    /// Class DeleteProduct.
    /// Implements the <see cref="MediatR.IRequest" />
    /// </summary>
    /// <seealso cref="MediatR.IRequest" />
    /// <autogeneratedoc />
    /// <autogeneratedoc />
    public class DeleteProduct : IRequest
    {
        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <autogeneratedoc />
        public Guid Id { get; set; }
    }
}