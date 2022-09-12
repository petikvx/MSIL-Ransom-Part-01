using System.ComponentModel;

namespace Gecko.WebIDL;

public enum BiquadFilterType
{
	[Description("lowpass")]
	lowpass,
	[Description("highpass")]
	highpass,
	[Description("bandpass")]
	bandpass,
	[Description("lowshelf")]
	lowshelf,
	[Description("highshelf")]
	highshelf,
	[Description("peaking")]
	peaking,
	[Description("notch")]
	notch,
	[Description("allpass")]
	allpass
}
