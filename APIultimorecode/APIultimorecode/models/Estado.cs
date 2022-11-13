
using System.ComponentModel.DataAnnotations;

namespace APIultimorecode.models
    
{
    public class Estado
    {
        [Key]
        public int id { get; set; }

        public int preco { get; set; }

        public string embarque { get; set; }

        public string desembarque { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "O campo nome deve ter entre 3 e 200 caracteres")]
        public string Nome { get; set; }
    }
}
