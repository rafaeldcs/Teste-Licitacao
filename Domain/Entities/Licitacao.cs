using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Licitacao : BaseEntity
    {
        public string Numero { get; set; }
        public string Descricao { get; set; }
        public int status { get; set; }
        public DateTime? DataAbertura { get; set; }
    }
}
