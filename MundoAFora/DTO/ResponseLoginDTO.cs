using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MundoAFora.DTO
{
    public class ResponseLoginDTO
    {
           public bool Sucesso { get; set; }
           public string Mensagem { get; set; } = string.Empty;
    }
}
