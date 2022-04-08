using QTDrugPrescription.WebApi.Models;
using System.ComponentModel.DataAnnotations;

namespace QTDrugPrescription.WebApi.Models.app
{
    public class Prescription : VersionModel
    {
        public int PatientId { get; set; }
        public int DrugId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required, MaxLength(1024)]
        public string Dosing { get; set; } = string.Empty;

    }
}
