

using System.ComponentModel.DataAnnotations;

namespace MvcBasic.Models
{
    public enum VendorType
    {
        [Display(Name ="Pessoa Fisica")]
        PhysicalPerson = 1,
        [Display(Name = "Pessoa Juridica")]
        LegalPearson = 2
    }
}
