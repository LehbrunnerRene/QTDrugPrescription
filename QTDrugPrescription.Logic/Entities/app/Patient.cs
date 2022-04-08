using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Entities.app
{
    [Table("Patients", Schema = "App")]
    [Index(nameof(SSN), IsUnique = true)]
    public class Patient : VersionEntity
    {
        /*[NotMapped]
        TODO public DateTime Birthday { get; }*/
        [Required]
        public DateTime Birthday { get; set; }
        [Required, MaxLength(10)]
        public string SSN { get; set; } = string.Empty;
        [Required, MaxLength(64)]
        public string FirstName { get; set; } = string.Empty;
        [Required, MaxLength(64)]
        public string LastName { get; set; } = string.Empty;
    }
}
