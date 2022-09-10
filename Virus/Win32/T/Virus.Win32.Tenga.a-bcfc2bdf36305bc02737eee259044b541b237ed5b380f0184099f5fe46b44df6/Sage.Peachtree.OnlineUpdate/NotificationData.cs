using System.Xml.Serialization;

namespace Sage.Peachtree.OnlineUpdate;

[XmlType(Namespace = "http://tempuri.org/")]
public class NotificationData
{
	public string Version;

	public string ProductName;

	public string Flavor;

	public string BuildNumber;

	public string UpdateProgram;

	public DeploymentEvent NotificationEvent;
}
