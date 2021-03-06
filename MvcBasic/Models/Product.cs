using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcBasic.Models
{
    public class Product : Entity
    {
        public Guid VendorId { get; set; }

        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo do nome é obrigatório.")]       
        [StringLength(200,ErrorMessage = "o campo nome precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Name { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo do descrição é obrigatório.")]
        [StringLength(1000, ErrorMessage = "o campo descrição precisa ter entre {2} e {1} caracteres.", MinimumLength = 2)]
        public string Description { get; set; }

        [DisplayName("Imagem")]
        [Required(ErrorMessage = "O campo do imagem é obrigatório.")]
        [StringLength(1000, ErrorMessage = "o nome do arquivo precisa ter no maximo {1} caracteres.")]
        public string Image { get; set; }

        [DisplayName("Valor")]
        [Required(ErrorMessage = "O campo do valor é obrigatório.")]
        public decimal Value { get; set; }

        [DisplayName("Data Cadastro")]
        public DateTime DateRegister { get; set; }

        [DisplayName("Ativo")]
        public bool Active { get; set; }

        /* EF Relation */

        public Vendor Vendor { get; set; }

    }
}
