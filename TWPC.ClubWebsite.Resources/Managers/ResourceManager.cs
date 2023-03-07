using Pulumi;
using System;
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
            var environment = Environment.GetEnvironmentVariable("twpc.environment");
            Log.Info(environment);

            var resourceGroupName = $"TWPC-ClubWebsite-{environment}";
            var resourceGroup = _resourceGroupService.NewResourceGroup(resourceGroupName, "UK South");
        }
    }
}
