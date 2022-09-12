using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("0DDF9E1C-1DD2-11B2-A183-908A08AA75AE")]
public interface nsISelectionDisplay
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetSelectionFlags(short toggle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetSelectionFlags();
}
