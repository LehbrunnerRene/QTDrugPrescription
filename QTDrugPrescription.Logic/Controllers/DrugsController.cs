using QTDrugPrescription.Logic.Entities.app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Controllers
{
    public class DrugsController : GenericController<Drug>
    {
        public DrugsController()
        {
        }

        public DrugsController(ControllerObject other) : base(other)
        {
        }

        public override Task<Drug> InsertAsync(Drug entity)
        {
            CheckDrug(entity);
            return base.InsertAsync(entity);
        }

        public override Task<IEnumerable<Drug>> InsertAsync(IEnumerable<Drug> entities)
        {
            foreach (var item in entities)
            {
                CheckDrug(item);
            }
            return base.InsertAsync(entities);
        }

        public override Task<Drug> UpdateAsync(Drug entity)
        {
            CheckDrug(entity);
            return base.UpdateAsync(entity);
        }

        public override Task<IEnumerable<Drug>> UpdateAsync(IEnumerable<Drug> entities)
        {
            foreach (var item in entities)
            {
                CheckDrug(item);
            }
            return base.UpdateAsync(entities);
        }
        private static void CheckDrug(Drug entity)
        {
            if (!DrugExtensions.CheckNumber(entity.Number))
                throw new Exception("Ziffer ist falsch!");
        }




    }
}
