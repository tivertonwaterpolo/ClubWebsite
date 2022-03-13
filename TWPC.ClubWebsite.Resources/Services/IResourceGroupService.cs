using Pulumi.AzureNative.Resources;

namespace TWPC.ClubWebsite.Resources.Services
{
    public interface IResourceGroupService
    {
        ResourceGroup NewResourceGroup(string resourceGroupName, string location);
    }
}