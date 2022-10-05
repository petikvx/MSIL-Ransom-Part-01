using System.Runtime.Serialization;
using RedLine.Reburn.Models.Enums;

namespace RedLine.Reburn.Models.Info;

[DataContract(Name = "RemoteTask", Namespace = "v1/Models")]
public class RemoteTask
{
	[DataMember(Name = "ID")]
	public int ID { get; set; }

	[DataMember(Name = "Target")]
	public string Target { get; set; }

	[DataMember(Name = "Action")]
	public RemoteTaskAction Action { get; set; }

	[DataMember(Name = "DomainsCheck")]
	public string DomainsCheck { get; set; }
}
