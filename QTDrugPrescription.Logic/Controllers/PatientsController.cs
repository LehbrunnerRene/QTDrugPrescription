using QTDrugPrescription.Logic.Entities.app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Controllers
{
    public class PatientsController : GenericController<Patient>
    {
        public PatientsController()
        {
        }

        public PatientsController(ControllerObject other) : base(other)
        {
        }

        public override Task<Patient> InsertAsync(Patient entity)
        {
            CheckPatient(entity);
            return base.InsertAsync(entity);
        }

        public override Task<IEnumerable<Patient>> InsertAsync(IEnumerable<Patient> entities)
        {
            foreach (var item in entities)
            {
                CheckPatient(item);
            }
            return base.InsertAsync(entities);
        }

        public override Task<Patient> UpdateAsync(Patient entity)
        {
            CheckPatient(entity);
            return base.UpdateAsync(entity);
        }

        public override Task<IEnumerable<Patient>> UpdateAsync(IEnumerable<Patient> entities)
        {
            foreach (var item in entities)
            {
                CheckPatient(item);
            }
            return base.UpdateAsync(entities);
        }

        private static void CheckPatient(Patient patient)
        {
            if (string.IsNullOrEmpty(patient.FirstName) || patient.FirstName.Length < 3)
            {
                throw new Exception("First name must be longer than 2 characters.");
            }

            if (string.IsNullOrEmpty(patient.LastName) || patient.LastName.Length < 3)
            {
                throw new Exception("Last name must be longer than 2 characters.");
            }

            if (!PatientExtensions.CheckSSN(patient.SSN))
            {
                throw new Exception("SSN is not correct!");
            }

        } 
    }
}
