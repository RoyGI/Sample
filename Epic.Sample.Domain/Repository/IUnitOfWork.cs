// --------------------------------------------------------------------------------------------------------------------
// <copyright file=" IUnitOfWork.cs" company="EPIC Software">
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

    /// <summary>
    /// Interface IUnitOfWork
    /// Implements the <see cref="System.IDisposable" />
    /// </summary>
    /// <seealso cref="System.IDisposable" />
    /// <autogeneratedoc />
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Commits this instance.
        /// </summary>
        /// <autogeneratedoc />
        void Commit();

        /// <summary>
        /// Repositories this instance.
        /// </summary>
        /// <typeparam name="T">The type of the repository</typeparam>
        /// <returns>The repository type T.</returns>
        /// <autogeneratedoc />
        T Repository<T>();
    }
}