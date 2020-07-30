using System.ComponentModel.DataAnnotations;

namespace Dating1App.api.Dtos
{
    public class UserForRegisterDto 
    {
       [Required] 
        public string Username { get; set; }
        [Required]
        [StringLength(8,MinimumLength=4,ErrorMessage="specif 4-8 char")]

        public string Password { get; set; }
    }
}