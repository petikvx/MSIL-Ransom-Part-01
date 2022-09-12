using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("7a307c6c-6cc9-11da-be43-001422106990")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISAXLocator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetColumnNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLineNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPublicIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aPublicId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSystemIdAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSystemId);
}
