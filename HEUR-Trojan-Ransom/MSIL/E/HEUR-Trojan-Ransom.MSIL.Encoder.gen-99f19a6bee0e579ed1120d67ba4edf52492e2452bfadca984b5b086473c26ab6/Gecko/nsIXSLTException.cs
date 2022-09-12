using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("e06dfaea-92d5-47f7-a800-c5f5404d8771")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXSLTException : nsIException
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
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetStyleNodeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMNode GetSourceNodeAttribute();
}
