using IMS.CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCase.Inventories.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        public Task<IEnumerable<Inventory>> ExecuteAsnc(string name = "");
    }
}
