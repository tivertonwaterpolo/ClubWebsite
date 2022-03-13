using TWPC.ClubWebsite.Resources.Services;

namespace TWPC.ClubWebsite.Resources.Managers
{
    public class ResourceManager
    {
        private IResourceGroupService _resourceGroupService;


        public ResourceManager(IResourceGroupService resourceGroupService)
        {
            _resourceGroupService = resourceGroupService;
        }

        public void CreateResources()
        {
            var resourceGroup = _resourceGroupService.NewResourceGroup("TWPC-ClubWebsite", "UK South");
        }
    }
}
