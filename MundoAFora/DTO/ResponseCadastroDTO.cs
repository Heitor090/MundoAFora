using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAFora.DTO
{
    public class ResponseCadastroDTO
    {
        public bool Erro { get; set; }
        public string Mensagem { get; set; } = string.Empty;
    }
}
