using Api.Repository.Patterns;
using Model.Dto.Produtos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repository.Produtos
{
    public class IncluirProdutoUnitOfWork : UnitOfWork
    {
        public IProdutosRepository Produtos { get; private set; }

        public IAnexosRepository Anexos { get; private set; }

        public IBinariosRepository Binarios { get; private set; }

        public IncluirProdutoUnitOfWork(DbContext context) : base(context)
        {
            Produtos = new ProdutosRepository(context);
            Anexos = new AnexosRepository(context);
            Binarios = new BinariosRepository(context);
        }

        public void IncluirProduto(IncluirProdutoDto produto)
        {
            try
            {
                BeginTransaction();

                var anexo = new Model.Anexos()
                {
                    NOME_ARQUIVO = produto.Nome_Arquivo,
                    EXTENSAO = produto.Extensao_Arquivo
                };
                Anexos.Add(anexo);
                Anexos.Save();

                var bin = new Model.Binarios()
                {
                    BASE64STRING = produto.Base64String,
                    DT_INCLUSAO = DateTime.Now,
                    ID_ANEXO = anexo.ID
                };
                Binarios.Add(bin);
                Binarios.Save();

                var prd = new Model.Produtos()
                {
                    NOME = produto.Nome_Produto,
                    DT_INCLUSAO = DateTime.Now,
                    ID_FOTO = anexo.ID
                };
                Produtos.Add(prd);
                Produtos.Save();

                Commit();
            }
            catch (Exception)
            {
                Rollback();
                throw;
            }
        }
    }
}
