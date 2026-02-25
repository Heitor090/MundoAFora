using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MundoAFora.DTO
{
    public class RequestCadastroDTO
    {
        public required string NomeCompleto {get; set;}
        public required string CPF {get; set;}
        public required DateTime DataNascimento {get; set;}
        public required string Email {get; set;}
        public required string Senha {get; set;}

    }
}
