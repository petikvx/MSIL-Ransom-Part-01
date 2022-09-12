using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("4CAFE116-581B-4194-B0DE-7F02378FC51D")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIDOMMozBrowserFrame
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMozbrowserAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMozbrowserAttribute([MarshalAs(UnmanagedType.U1)] bool aMozbrowser);
}
