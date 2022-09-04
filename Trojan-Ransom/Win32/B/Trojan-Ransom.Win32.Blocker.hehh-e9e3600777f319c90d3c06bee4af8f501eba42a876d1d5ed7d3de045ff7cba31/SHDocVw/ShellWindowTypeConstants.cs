using System.Runtime.InteropServices;

namespace SHDocVw;

[Guid("F41E6981-28E5-11D0-82B4-00A0C90C29C5")]
public enum ShellWindowTypeConstants
{
	SWC_EXPLORER = 0,
	SWC_BROWSER = 1,
	SWC_3RDPARTY = 2,
	SWC_CALLBACK = 4
}
