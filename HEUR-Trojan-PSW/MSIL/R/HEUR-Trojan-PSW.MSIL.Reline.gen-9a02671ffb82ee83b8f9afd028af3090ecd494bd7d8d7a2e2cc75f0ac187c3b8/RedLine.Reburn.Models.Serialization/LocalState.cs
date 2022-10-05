using System.Runtime.Serialization;

namespace RedLine.Reburn.Models.Serialization;

[DataContract(Name = "LocalState")]
public class LocalState
{
	[DataMember(Name = "os_crypt")]
	public OsCrypt os_crypt { get; set; }
}
