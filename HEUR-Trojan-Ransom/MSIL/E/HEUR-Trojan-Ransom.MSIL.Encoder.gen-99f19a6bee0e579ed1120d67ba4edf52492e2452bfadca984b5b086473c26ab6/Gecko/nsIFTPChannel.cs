using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("07f0d5cd-1fd5-4aa3-b6fc-665bdc5dbf9f")]
public interface nsIFTPChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetLastModifiedTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLastModifiedTimeAttribute(long aLastModifiedTime);
}
