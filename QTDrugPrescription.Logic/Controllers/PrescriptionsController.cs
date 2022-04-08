using QTDrugPrescription.Logic.Entities.app;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTDrugPrescription.Logic.Controllers
{
    public class PrescriptionsController : GenericController<Prescription>
    {
        public PrescriptionsController()
        {
        }

        public PrescriptionsController(ControllerObject other) : base(other)
        {
        }

        public override Task<Prescription> InsertAsync(Prescription entity)
        {
            entity.Date = ConvertDateDay(entity.Date);
            return base.InsertAsync(entity);
        }

        public override Task<IEnumerable<Prescription>> InsertAsync(IEnumerable<Prescription> entities)
        {
            foreach (var item in entities)
            {
                item.Date = ConvertDateDay(item.Date);
            }
            return base.InsertAsync(entities);
        }

        public override Task<Prescription> UpdateAsync(Prescription entity)
        {
            entity.Date = ConvertDateDay(entity.Date);
            return base.UpdateAsync(entity);
        }

        public override Task<IEnumerable<Prescription>> UpdateAsync(IEnumerable<Prescription> entities)
        {
            foreach (var item in entities)
            {
                item.Date = ConvertDateDay(item.Date);
            }
            return base.UpdateAsync(entities);
        }

        private static DateTime ConvertDateDay(DateTime date)
        {
            return new DateTime(date.Year, date.Month, date.Day);
        }
    }
}
