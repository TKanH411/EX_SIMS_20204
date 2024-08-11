using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;

namespace SIMS_SE06205.Models
{
    public class StudentModel
    {
        public List<StudentViewModel> StudentLists { get; set; }
    }
    public class StudentViewModel
    {
        [Key]
        public string? Id { get; set; }
        [Required(ErrorMessage = "First Name's can be not emty")]

        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name can be not emty")]

        public string LastName { get; set; }
       
        public string Code {  get; set; }

        [Required(ErrorMessage = "Email's Student can be not emty")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Phone's Student can be not emty")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Address's Student can be not emty")]
        public string Address { get; set; }
       
        [AllowNull]
        public string? Gender { get; set; }
        [AllowNull]
        public string? BirthDay { get; set; }



    }
}
