using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapProduto.ViewModel
{
    public class MarcaVM
    {
        [Key]
        public int MarcaId { get; set; }

        [Required(ErrorMessage = "Categoria Obrigatória")]
        [MaxLength(40, ErrorMessage = "Marca deve ter até 40 caracteres")]
        [MinLength(2, ErrorMessage = "Marca deve ter no mínimo 2 caracteres")]
        public String NomeMarca { get; set; }
    }
}
