using System;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GuniThesisApp.Web.Models
{
    public class MyIdentityUser : IdentityUser<Guid> 
    {
        [Display(Name ="Display Name")]
        [Required(ErrorMessage ="{0} cannot be empty.")]
        [MinLength(10,ErrorMessage ="{0} should have at least {1} characters.")]
        [StringLength(60,ErrorMessage ="{0} cannot have more than {1} characters.")]
        public string DisplayName { get; set; }

        [Display(Name ="Date of Birth")]
        [Required]
        [Column(TypeName = "smalldatetime")]
        [PersonalData]                                                      //For GDPR Compliance
        public DateTime DateOfBirth { get; set; }

        [Display(Name ="Is Admin User?")]
        [Required]
        public bool IsAdminUser { get; set; }


    }
}
