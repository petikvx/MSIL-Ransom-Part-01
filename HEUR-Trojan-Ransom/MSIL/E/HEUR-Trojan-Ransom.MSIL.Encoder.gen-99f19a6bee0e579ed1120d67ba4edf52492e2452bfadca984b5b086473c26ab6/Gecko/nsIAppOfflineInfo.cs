using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4ac296a0-ca1b-44f4-8787-117a88cb70fb")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAppOfflineInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetAppIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetModeAttribute();
}
