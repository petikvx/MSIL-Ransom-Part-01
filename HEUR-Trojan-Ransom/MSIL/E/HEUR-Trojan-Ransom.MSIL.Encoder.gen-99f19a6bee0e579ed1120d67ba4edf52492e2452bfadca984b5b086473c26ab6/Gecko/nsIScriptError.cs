using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("18bdefde-e57b-11e4-832a-000c29a57fff")]
public interface nsIScriptError : nsIConsoleMessage
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetLogLevelAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new long GetTimeStampAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	new string GetMessageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ToString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetErrorMessageAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aErrorMessage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSourceNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSourceName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSourceLineAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aSourceLine);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLineNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetColumnNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetFlagsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetCategoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetOuterWindowIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	ulong GetInnerWindowIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsFromPrivateWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetStackAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStackAttribute(JsVal aStack);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase message, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceLine, uint lineNumber, uint columnNumber, uint flags, [MarshalAs(UnmanagedType.LPStr)] string category);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InitWithWindowID([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase message, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase sourceLine, uint lineNumber, uint columnNumber, uint flags, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase category, ulong innerWindowID);
}
