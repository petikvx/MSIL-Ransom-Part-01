using System.ComponentModel;

namespace Gecko.WebIDL;

public enum BinaryType
{
	[Description("blob")]
	blob,
	[Description("arraybuffer")]
	arraybuffer
}
