using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4ad136fa-83af-4a22-a76e-503642c0f4a8")]
public interface nsIResumableChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void ResumeAt(ulong startPos, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase entityID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEntityIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aEntityID);
}
