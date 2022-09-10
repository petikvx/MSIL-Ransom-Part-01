using System.Runtime.InteropServices;

namespace Sage.Peachtree.OnlineUpdate;

[Guid("9F5C094D-D8A3-408f-9C14-9821DCC620FD")]
public interface IOnlineUpdateNotification
{
	bool ProductUpdateNotification(string Product, string Flavor, string BuildNumber, string UpdateProgram, DeploymentEvent Event);
}
