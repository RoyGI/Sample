// --------------------------------------------------------------------------------------------------------------------
// <copyright file=" IProductRepository.cs" company="EPIC Software">
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

namespace Epic.Sample.Domain.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    using Epic.Sample.Domain.Entities;

    /// <summary>
    /// Interface IProductRepository
    /// </summary>
    /// <autogeneratedoc />
    public interface IProductRepository
    {
        /// <summary>
        /// Deletes the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <autogeneratedoc />
        void Delete(Guid id);

        /// <summary>
        /// Finds the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>Product.</returns>
        /// <autogeneratedoc />
        Product Find(Expression<Func<Product, bool>> query);

        /// <summary>
        /// Finds all.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>IEnumerable Product .</returns>
        /// <autogeneratedoc />
        IEnumerable<Product> FindAll(Expression<Func<Product, bool>> query);

        /// <summary>
        /// Finds all.
        /// </summary>
        /// <returns>IEnumerable Product.</returns>
        /// <autogeneratedoc />
        IEnumerable<Product> FindAll();

        /// <summary>
        /// Saves the specified product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <autogeneratedoc />
        void Save(Product product);

        /// <summary>
        /// Updates the specified product.
        /// </summary>
        /// <param name="product">The product.</param>
        /// <autogeneratedoc />
        void Update(Product product);
    }
}