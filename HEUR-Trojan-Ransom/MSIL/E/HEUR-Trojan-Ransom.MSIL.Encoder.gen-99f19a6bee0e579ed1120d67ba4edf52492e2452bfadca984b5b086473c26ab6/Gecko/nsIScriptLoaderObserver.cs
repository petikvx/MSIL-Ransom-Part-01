using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("7b787204-76fb-4764-96f1-fb7a666db4f4")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIScriptLoaderObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScriptAvailable(int aResult, IntPtr aElement, [MarshalAs(UnmanagedType.U1)] bool aIsInline, [MarshalAs(UnmanagedType.Interface)] nsIURI aURI, int aLineNo);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ScriptEvaluated(int aResult, IntPtr aElement, [MarshalAs(UnmanagedType.U1)] bool aIsInline);
}
