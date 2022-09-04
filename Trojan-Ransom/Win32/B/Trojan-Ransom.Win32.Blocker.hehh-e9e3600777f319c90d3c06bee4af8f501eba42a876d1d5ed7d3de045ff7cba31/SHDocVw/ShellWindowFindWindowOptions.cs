using System.Runtime.InteropServices;

namespace SHDocVw;

[TypeLibType(16)]
[Guid("7716A370-38CA-11D0-A48B-00A0C90A8F39")]
public enum ShellWindowFindWindowOptions
{
	SWFO_NEEDDISPATCH = 1,
	SWFO_INCLUDEPENDING = 2,
	SWFO_COOKIEPASSED = 4
}
