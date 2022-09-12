using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("33234b99-9588-4c7d-9da6-86b8b7cba565")]
public interface nsIScriptChannel
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetExecutionPolicyAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExecutionPolicyAttribute(uint aExecutionPolicy);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetExecuteAsyncAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetExecuteAsyncAttribute([MarshalAs(UnmanagedType.U1)] bool aExecuteAsync);
}
