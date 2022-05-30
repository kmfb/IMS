using IMS.CoreBusiness;
using IMS.UseCase.PluginInterfaces;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        public List<Inventory> _inventories;

        public InventoryRepository()
        {
            _inventories = new List<Inventory>()
            {
                new Inventory{ InventoryId = 1, InventoryName = "Bike Seat", Quantity = 10, Price = 2 },
                new Inventory{ InventoryId = 2, InventoryName = "Bike Body", Quantity = 20, Price = 20 },
                new Inventory{ InventoryId = 3, InventoryName = "Bike Wheels", Quantity = 30, Price = 30 },
            };
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {

            if (string.IsNullOrWhiteSpace(name)) {
                return await Task.FromResult(_inventories);
            }

            List<Inventory> res = _inventories.Where((inv) => inv.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            return await Task.FromResult(res);

            
        }
    }
}