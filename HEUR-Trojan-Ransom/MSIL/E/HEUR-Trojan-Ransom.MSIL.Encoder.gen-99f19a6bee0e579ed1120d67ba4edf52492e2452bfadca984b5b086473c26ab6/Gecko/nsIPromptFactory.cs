using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("2532b748-75db-4732-9173-78d3bf34f694")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPromptFactory
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPrompt([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, ref Guid iid);
}
