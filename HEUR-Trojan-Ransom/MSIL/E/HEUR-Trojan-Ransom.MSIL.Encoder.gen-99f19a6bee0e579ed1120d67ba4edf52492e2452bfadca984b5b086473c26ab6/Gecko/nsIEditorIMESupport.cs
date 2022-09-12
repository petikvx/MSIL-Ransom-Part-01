using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("0ba7f490-afb8-46dd-87fc-bc6137fbc899")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIEditorIMESupport
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ForceCompositionEnd();

	[MethodImpl(MethodImplOptions.InternalCall)]
	IntPtr GetPreferredIMEState();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetComposingAttribute();
}
