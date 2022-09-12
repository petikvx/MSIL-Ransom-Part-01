using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("5743f870-958e-4f02-aef2-c0afeef67f05")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPKCS11
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void DeleteModule([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase moduleName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddModule([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase moduleName, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase libraryFullPath, int cryptoMechanismFlags, int cipherFlags);
}
