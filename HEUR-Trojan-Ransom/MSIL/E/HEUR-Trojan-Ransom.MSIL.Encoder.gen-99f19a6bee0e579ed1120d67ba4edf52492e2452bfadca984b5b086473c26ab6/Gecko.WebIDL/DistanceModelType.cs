using System.ComponentModel;

namespace Gecko.WebIDL;

public enum DistanceModelType
{
	[Description("linear")]
	linear,
	[Description("inverse")]
	inverse,
	[Description("exponential")]
	exponential
}
