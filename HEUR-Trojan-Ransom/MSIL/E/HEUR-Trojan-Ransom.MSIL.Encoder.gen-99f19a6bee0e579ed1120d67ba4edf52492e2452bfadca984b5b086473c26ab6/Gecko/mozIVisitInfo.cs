using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("41e4ccc9-f0c8-4cd7-9753-7a38514b8488")]
public interface mozIVisitInfo
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetVisitIdAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetVisitDateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetTransitionTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI GetReferrerURIAttribute();
}
