using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("7E225E5F-711C-11D7-9FAE-000393636592")]
public interface nsIFlavorDataProvider
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetFlavorData([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable, [MarshalAs(UnmanagedType.LPStr)] string aFlavor, [MarshalAs(UnmanagedType.Interface)] ref nsISupports aData, ref uint aDataLen);
}
