using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI_Task.Models
{
    public class CidadesDTO
    {
        public int Id { get; private set; }
        public int Seq { get; private set; }
        public string Nome { get; private set; }
        public string Codigo_IBGE { get; private set; }

        public CidadesDTO(string nome, string codigo_IBGE)
        {
            var counter = CidadesTable.Counter++;
            Id = counter;
            Seq = counter;
            Nome = nome;
            Codigo_IBGE = codigo_IBGE;
        }
    }


}