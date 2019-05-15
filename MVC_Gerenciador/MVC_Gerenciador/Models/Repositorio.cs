using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_Gerenciador.Models {
    public class Repositorio {
        /*
         * Nome, descrição, linguagem, última atualização, dono do repositório
         * Abaixo disso, todos os contribuidores.
         */

        public string nome { get; set; }
        public string descricao { get; set; }
        public string linguagem { get; set; }
        public string ultimaAtualizacao { get; set; }
        public string donoRepositorio { get; set; }
        public List<string> contribuintes = new List<string>();

    }
}