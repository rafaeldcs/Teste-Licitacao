using Domain.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.ConstrainedExecution;

namespace ApiControle.Model
{
    public class LicitacaoModel
    {
        public Guid? Id { get; set; }
        public string? Numero { get; set; }
        public string? Descricao { get; set; }
        public string? DataAbertura { get; set; }
        public int? status { get; set; }
    }
}