using Microsoft.AspNetCore.Mvc;
using QTDrugPrescription.Logic.Controllers;
using QTDrugPrescription.Logic.Entities.app;

namespace QTDrugPrescription.WebApi.Controllers
{
    public class PatientsController : GenericController<Logic.Entities.app.Patient, Models.app.Patient,Models.app.Patient>
    {
        public PatientsController(GenericController<Patient> controller) : base(controller)
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
