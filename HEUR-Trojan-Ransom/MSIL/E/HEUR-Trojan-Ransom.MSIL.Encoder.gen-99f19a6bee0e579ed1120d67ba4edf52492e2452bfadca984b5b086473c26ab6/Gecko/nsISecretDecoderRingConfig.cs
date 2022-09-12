using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("01D8C0F0-0CCC-11d4-9FDD-000064657374")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsISecretDecoderRingConfig
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetWindow([MarshalAs(UnmanagedType.Interface)] nsISupports w);
}
