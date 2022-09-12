using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5E9072D7-FF95-455E-9466-8AF9841A72EC")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIMacUtils
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsUniversalBinaryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetArchitecturesInBinaryAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aArchitecturesInBinary);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsTranslatedAttribute();
}
