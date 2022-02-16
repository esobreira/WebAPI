using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository.Patterns
{
    public interface IUnitOfWork 
    {
        /// <summary>
        /// Inicia uma transação
        /// </summary>
        void BeginTransaction();

        /// <summary>
        /// Completa a transação e retorna a quantidade de registros salvos.
        /// </summary>
        /// <returns></returns>
        int Save();

        /// <summary>
        /// Completa a transação.
        /// </summary>
        void Commit();

        /// <summary>
        /// Desfaz a transação.
        /// </summary>
        void Rollback();
    }
}
