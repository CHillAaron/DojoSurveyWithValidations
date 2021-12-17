using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DojoSurveyWithValidations.Models
{
    public class Dojo
    {
        [Required]
        [MinLength(2, ErrorMessage = "Name must be longer than 2 Characters")]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }
        [Required]
        public string Language { get; set; }
        [MinLength(20, ErrorMessage = "Comment must be longer than 20 chars")]
        public string Comment { get; set; }
    }
}
