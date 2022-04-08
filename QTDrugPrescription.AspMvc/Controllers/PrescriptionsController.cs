using QTDrugPrescription.Logic.Controllers;
using QTDrugPrescription.Logic.Entities.app;

namespace QTDrugPrescription.AspMvc.Controllers
{
    public class PrescriptionsController : GenericController<Logic.Entities.app.Prescription, Models.Prescription>
    {
        private Logic.Entities.app.Patient[]? patients = null;
        private Logic.Controllers.PatientsController? patientsController = null;

        private Logic.Entities.app.Drug[]? drugs = null;
        private Logic.Controllers.DrugsController? drugsController = null;
        public PrescriptionsController(Logic.Controllers.PrescriptionsController controller) : base(controller)
        {
        }

        protected Logic.Entities.app.Patient[] Patients
        {
            get
            {
                if (patients == null)
                {
                    Task.Run(async () => patients = await PatientsController.GetAllAsync()).Wait();
                }
                return patients ??= Array.Empty<Logic.Entities.app.Patient>();
            }
        }

        protected Logic.Entities.app.Drug[] Drugs
        {
            get
            {
                if (drugs == null)
                {
                    Task.Run(async () => drugs = await DrugsController.GetAllAsync()).Wait();
                }
                return drugs ??= Array.Empty<Logic.Entities.app.Drug>();
            }
        }

        private Logic.Controllers.DrugsController DrugsController
        {
            get => drugsController ??= new Logic.Controllers.DrugsController(Controller);
        }

        private Logic.Controllers.PatientsController PatientsController
        {
            get => patientsController ??= new Logic.Controllers.PatientsController(Controller);
        }
        protected override Models.Prescription ToModel(Logic.Entities.app.Prescription entity)
        {
            var result = base.ToModel(entity);
            var patient = Patients.FirstOrDefault(p => p.Id == result.PatientId);
            var drugs = Drugs.FirstOrDefault(p => p.Id == result.DrugId);

            result.Patients = Patients;
            result.Drugs = Drugs;


            if (drugs != null)
                result.DrugName = drugs.Designation;
            if (patient != null)
                result.PatientName = patient.FirstName;

            return result;
        }

        protected override void Dispose(bool disposing)
        {
            PatientsController?.Dispose();
            DrugsController?.Dispose();
            base.Dispose(disposing);
        }
    }
}
