using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Atv3._1.Models
{
    public class Contato
    {
        public int id {get;set;}
        public string nome {get; set;}
        public string phone {get; set;}
        public string email {get; set;}
        public string servico {get; set;}
        public string mensagem {get;set;}

        public bool Respondido {get; set;}
    }
}