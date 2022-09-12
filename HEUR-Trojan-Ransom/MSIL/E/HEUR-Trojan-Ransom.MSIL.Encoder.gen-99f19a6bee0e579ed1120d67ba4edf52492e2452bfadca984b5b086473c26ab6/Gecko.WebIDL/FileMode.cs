using System.ComponentModel;

namespace Gecko.WebIDL;

public enum FileMode
{
	[Description("readonly")]
	@readonly,
	[Description("readwrite")]
	readwrite
}
