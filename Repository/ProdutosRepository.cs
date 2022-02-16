using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository
{
    public class ProdutosRepository : Repository<Model.Produtos>, IProdutosRepository
    {
        public ProdutosRepository(DbContext context) : base(context)
        {
        }
    }

    public interface IProdutosRepository : IRepository<Model.Produtos>
    {
    }
}
