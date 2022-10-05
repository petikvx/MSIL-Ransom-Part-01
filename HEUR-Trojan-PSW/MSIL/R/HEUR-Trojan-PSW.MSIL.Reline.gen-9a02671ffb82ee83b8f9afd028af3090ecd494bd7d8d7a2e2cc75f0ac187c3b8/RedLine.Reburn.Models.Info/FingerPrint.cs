using System.Runtime.Serialization;

namespace RedLine.Reburn.Models.Info;

[DataContract(Name = "FingerPrint", Namespace = "v1/Models")]
public struct FingerPrint
{
	[DataMember(Name = "UserAgent")]
	public string UserAgent { get; set; }
}
