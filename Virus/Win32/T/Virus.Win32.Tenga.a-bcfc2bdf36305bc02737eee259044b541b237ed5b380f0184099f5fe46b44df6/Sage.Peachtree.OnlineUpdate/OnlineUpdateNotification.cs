using System.Runtime.InteropServices;
using System.Web.Services.Protocols;

namespace Sage.Peachtree.OnlineUpdate;

[Guid("2B5D502E-C9E7-409f-88FF-7FEC9D48A997")]
public class OnlineUpdateNotification : IOnlineUpdateNotification
{
	private const string NotificationDataVersion1 = "1.0";

	private const string SuccessString = "Update Succeeded";

	private static readonly string NotificationDataCurrentVersion = "1.0";

	public bool ProductUpdateNotification(string Product, string Flavor, string BuildNumber, string UpdateProgram, DeploymentEvent Event)
	{
		try
		{
			Notification notification = new Notification();
			NotificationData notificationData = new NotificationData();
			notificationData.NotificationEvent = Event;
			notificationData.ProductName = Product;
			notificationData.Flavor = Flavor;
			notificationData.BuildNumber = BuildNumber;
			notificationData.UpdateProgram = UpdateProgram;
			notificationData.Version = NotificationDataCurrentVersion;
			string text = notification.ProductUpdateNotification(notificationData);
			return text.IndexOf("Update Succeeded") >= 0;
		}
		catch (SoapException)
		{
			return false;
		}
	}
}
