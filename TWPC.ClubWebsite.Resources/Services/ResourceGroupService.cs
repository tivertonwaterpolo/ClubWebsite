using Pulumi.AzureNative.Resources;

namespace TWPC.ClubWebsite.Resources.Services
{
    public class ResourceGroupService : IResourceGroupService
    {
        public ResourceGroup NewResourceGroup(string resourceGroupName, string location)
        {
            return new ResourceGroup(resourceGroupName, new ResourceGroupArgs
            {
                ResourceGroupName = resourceGroupName,
                Location = location
            });
        }

    }
}
