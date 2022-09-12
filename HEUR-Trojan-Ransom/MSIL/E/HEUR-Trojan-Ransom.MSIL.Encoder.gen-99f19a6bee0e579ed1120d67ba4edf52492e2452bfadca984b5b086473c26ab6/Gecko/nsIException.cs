using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4371b5bf-6845-487f-8d9d-3f1e4a9badd2")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIException
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMessageAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aMessage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetResultAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetNameAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFilenameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aFilename);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetLineNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetColumnNumberAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIStackFrame GetLocationAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports GetDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ToString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
}
