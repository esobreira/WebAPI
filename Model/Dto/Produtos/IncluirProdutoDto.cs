using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dto.Produtos
{
    public class IncluirProdutoDto
    {
        public string Nome_Produto { get; set; }
        public string Nome_Arquivo { get; set; }
        public string Extensao_Arquivo { get; set; }
        public string Base64String { get; set; }

        public IncluirProdutoDto(string nomeProduto, string nomeArquivo, string extensaoArquivo, string base64String)
        {
            Nome_Produto = nomeProduto;
            Nome_Arquivo = nomeArquivo;
            Extensao_Arquivo = extensaoArquivo;
            Base64String = base64String;
        }
    }
}
