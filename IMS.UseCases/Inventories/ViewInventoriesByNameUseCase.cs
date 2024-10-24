namespace IMS.UseCases.Inventories {

  public class ViewInventoriesByNameUseCase {

    private readonly IInventoryRepository inventoryRepository;
    public ViewInventoriesByNameUseCase(IInventoryRepository inventoryRepository) {
      this.inventoryRepository = inventoryRepository;
    }
    public async Task IEnumberable<Inventory> ExecuteAsync(string name="") {
      return await inventoryRepository.GetInventoriesByName(name);
    }
  }
}