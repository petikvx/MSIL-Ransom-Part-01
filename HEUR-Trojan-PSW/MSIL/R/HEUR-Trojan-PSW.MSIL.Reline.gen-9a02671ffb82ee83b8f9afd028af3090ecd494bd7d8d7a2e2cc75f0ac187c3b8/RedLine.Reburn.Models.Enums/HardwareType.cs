using System.Runtime.Serialization;

namespace RedLine.Reburn.Models.Enums;

[DataContract(Name = "HardwareType")]
public enum HardwareType
{
	[EnumMember]
	Processor,
	[EnumMember]
	Graphic
}
