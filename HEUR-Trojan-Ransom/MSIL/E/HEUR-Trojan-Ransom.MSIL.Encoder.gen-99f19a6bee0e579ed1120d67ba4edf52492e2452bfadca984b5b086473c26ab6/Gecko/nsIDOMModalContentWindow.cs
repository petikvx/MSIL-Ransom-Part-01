using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3f4cb2d0-5f7e-44a9-9f4f-370945f8db08")]
public interface nsIDOMModalContentWindow
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetDialogArgumentsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIVariant GetReturnValueAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReturnValueAttribute([MarshalAs(UnmanagedType.Interface)] nsIVariant aReturnValue);
}
