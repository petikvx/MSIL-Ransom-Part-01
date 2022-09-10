using System.Xml.Serialization;

namespace Sage.Peachtree.OnlineUpdate;

[XmlType(Namespace = "http://tempuri.org/")]
public enum DeploymentEvent
{
	None,
	SuccessfulDownload,
	FailedDownload,
	SuccessfulInstall,
	FailedInstall
}
