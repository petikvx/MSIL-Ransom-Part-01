using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("bc3173bd-aa46-46a0-9d25-d9867a9659b6")]
public interface nsICommandLine
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetArgument(int aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int FindFlag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFlag, [MarshalAs(UnmanagedType.U1)] bool aCaseSensitive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveArguments(int aStart, int aEnd);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HandleFlag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFlag, [MarshalAs(UnmanagedType.U1)] bool aCaseSensitive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void HandleFlagWithParam([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFlag, [MarshalAs(UnmanagedType.U1)] bool aCaseSensitive, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPreventDefaultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPreventDefaultAttribute([MarshalAs(UnmanagedType.U1)] bool aPreventDefault);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile GetWorkingDirectoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetWindowContextAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIFile ResolveFile([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aArgument);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIURI ResolveURI([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aArgument);
}
