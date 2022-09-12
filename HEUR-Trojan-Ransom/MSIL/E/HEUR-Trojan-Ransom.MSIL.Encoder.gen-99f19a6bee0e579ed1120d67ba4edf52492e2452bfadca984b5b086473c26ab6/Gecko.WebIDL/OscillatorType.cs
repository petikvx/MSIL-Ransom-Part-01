using System.ComponentModel;

namespace Gecko.WebIDL;

public enum OscillatorType
{
	[Description("sine")]
	sine,
	[Description("square")]
	square,
	[Description("sawtooth")]
	sawtooth,
	[Description("triangle")]
	triangle,
	[Description("custom")]
	custom
}
