using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("28bfb2a2-5ea6-4738-918b-049dc4d51f0b")]
public interface nsIStackFrame
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLanguageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLanguageNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aLanguageName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFilenameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFilename);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLineNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetColumnNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSourceLineAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSourceLine);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetAsyncCauseAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aAsyncCause);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStackFrame GetAsyncCallerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStackFrame GetCallerAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFormattedStackAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFormattedStack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetNativeSavedFrameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
