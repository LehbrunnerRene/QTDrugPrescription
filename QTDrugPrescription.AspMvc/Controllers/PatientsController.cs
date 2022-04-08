using QTDrugPrescription.Logic.Controllers;
using QTDrugPrescription.Logic.Entities.app;

namespace QTDrugPrescription.AspMvc.Controllers
{
    public class PatientsController : GenericController<Logic.Entities.app.Patient, Models.Patient>
    {
        public PatientsController(Logic.Controllers.PatientsController controller) : base(controller)
        {
        }
    }
}
