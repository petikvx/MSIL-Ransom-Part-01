using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("c9f2996c-b25a-4d3d-821f-4cd0c4bc8afb")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsICommandLineRunner : nsICommandLine
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetLengthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetArgument(int aIndex, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int FindFlag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFlag, [MarshalAs(UnmanagedType.U1)] bool aCaseSensitive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void RemoveArguments(int aStart, int aEnd);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool HandleFlag([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFlag, [MarshalAs(UnmanagedType.U1)] bool aCaseSensitive);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void HandleFlagWithParam([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFlag, [MarshalAs(UnmanagedType.U1)] bool aCaseSensitive, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetStateAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	new bool GetPreventDefaultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void SetPreventDefaultAttribute([MarshalAs(UnmanagedType.U1)] bool aPreventDefault);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIFile GetWorkingDirectoryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIDOMWindow GetWindowContextAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIFile ResolveFile([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aArgument);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIURI ResolveURI([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aArgument);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init(int argc, IntPtr argv, [MarshalAs(UnmanagedType.Interface)] nsIFile workingDir, uint state);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWindowContext([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aWindow);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Run();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHelpTextAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHelpText);
}
