using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public partial class Livro
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string? Autor { get; set; }
        [DataType(DataType.Date)]
        public DateTime? DataDePublicacao { get; set; }


        public string? ISBN { get; set; }
    }
}
