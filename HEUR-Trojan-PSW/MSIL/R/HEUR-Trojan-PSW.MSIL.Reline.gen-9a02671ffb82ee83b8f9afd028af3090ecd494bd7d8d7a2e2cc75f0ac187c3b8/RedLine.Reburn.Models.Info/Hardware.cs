using System.Runtime.Serialization;
using RedLine.Reburn.Models.Enums;

namespace RedLine.Reburn.Models.Info;

[DataContract(Name = "Hardware", Namespace = "v1/Models")]
public class Hardware
{
	[DataMember(Name = "Caption")]
	public string Caption { get; set; }

	[DataMember(Name = "Parameter")]
	public string Parameter { get; set; }

	[DataMember(Name = "HardType")]
	public HardwareType HardType { get; set; }

	public override string ToString()
	{
		return "Name: " + Caption + "," + ((HardType == HardwareType.Processor) ? (" " + Parameter + " Cores") : (" " + Parameter + " bytes"));
	}
}
