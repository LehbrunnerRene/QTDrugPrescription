using QTDrugPrescription.Logic.Controllers;
using QTDrugPrescription.Logic.Entities.app;

namespace QTDrugPrescription.AspMvc.Controllers
{
    public class DrugsController : GenericController<Logic.Entities.app.Drug, Models.Drug>
    {
        public DrugsController(Logic.Controllers.DrugsController controller) : base(controller)
        {
        }
    }
}
