using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("1f266877-2859-418b-a11b-ec3ae4f4f93d")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface mozIVisitInfoCallback
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleError(int aResultCode, mozIPlaceInfo aPlaceInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleResult(mozIPlaceInfo aPlaceInfo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleCompletion();
}
