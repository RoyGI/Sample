// --------------------------------------------------------------------------------------------------------------------
// <copyright file=" UnitOfWork.cs" company="EPIC Software">
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

namespace Epic.Sample.Infrastructure
{
    using System;
    using System.Collections.Generic;

    using Epic.Sample.Domain.Repository;

    using LiteDB;

    /// <summary>
    /// Class UnitOfWork.
    /// Implements the <see cref="Epic.Sample.Domain.Repository.IUnitOfWork" />
    /// </summary>
    /// <seealso cref="Epic.Sample.Domain.Repository.IUnitOfWork" />
    /// <autogeneratedoc />
    public class UnitOfWork : IUnitOfWork
    {
        /// <summary>
        /// The db
        /// </summary>
        /// <autogeneratedoc />
        private readonly LiteDatabase db;

        /// <summary>
        /// The repositories
        /// </summary>
        /// <autogeneratedoc />
        private readonly Dictionary<Type, Type> repositories;

        /// <summary>
        /// Initializes a new instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <autogeneratedoc />
        public UnitOfWork()
        {
            this.repositories = new Dictionary<Type, Type>
                                    {
                                        { typeof(IProductRepository), typeof(ProductRepository) }
                                    };
            this.db = new LiteDatabase("local");
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="UnitOfWork"/> class.
        /// </summary>
        /// <autogeneratedoc />
        ~UnitOfWork()
        {
            this.Dispose(false);
        }

        /// <summary>
        /// Commits this instance.
        /// </summary>
        /// <autogeneratedoc />
        public void Commit()
        {
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <autogeneratedoc />
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Repositories this instance.
        /// </summary>
        /// <typeparam name="T">The type of the repository</typeparam>
        /// <returns>The repository type T.</returns>
        /// <autogeneratedoc />
        public T Repository<T>()
        {
            var repositoryType = this.repositories[typeof(T)];
            return (T)Activator.CreateInstance(repositoryType);
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources; <c>false</c> to release only unmanaged resources.</param>
        /// <autogeneratedoc />
        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                this.db?.Dispose();
            }
        }
    }
}