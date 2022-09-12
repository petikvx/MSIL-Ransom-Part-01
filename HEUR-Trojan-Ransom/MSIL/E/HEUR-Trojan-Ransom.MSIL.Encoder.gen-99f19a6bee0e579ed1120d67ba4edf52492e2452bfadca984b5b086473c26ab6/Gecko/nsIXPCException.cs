using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("875e6645-e762-4da6-9ec8-bf19ab0050df")]
public interface nsIXPCException : nsIException
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetMessageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMessage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new int GetResultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void GetFilenameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFilename);

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetLineNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new uint GetColumnNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsIStackFrame GetLocationAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISupports GetDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void ToString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Initialize([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMessage, int aResult, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName, [MarshalAs(UnmanagedType.Interface)] nsIStackFrame aLocation, [MarshalAs(UnmanagedType.Interface)] nsISupports aData);
}
