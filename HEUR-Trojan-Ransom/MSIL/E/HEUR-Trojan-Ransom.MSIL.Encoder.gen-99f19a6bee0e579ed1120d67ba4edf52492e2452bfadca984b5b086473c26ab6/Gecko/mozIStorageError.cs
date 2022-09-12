using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("1f350f96-7023-434a-8864-40a1c493aac1")]
public interface mozIStorageError
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetResultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMessageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMessage);
}
