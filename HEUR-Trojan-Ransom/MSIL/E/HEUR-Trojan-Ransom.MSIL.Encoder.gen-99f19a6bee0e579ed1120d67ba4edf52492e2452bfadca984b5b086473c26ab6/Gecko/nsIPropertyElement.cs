using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("283EE646-1AEF-11D4-98B3-00C04fA0CE9A")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPropertyElement
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetKeyAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aKey);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetValueAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aValue);
}
