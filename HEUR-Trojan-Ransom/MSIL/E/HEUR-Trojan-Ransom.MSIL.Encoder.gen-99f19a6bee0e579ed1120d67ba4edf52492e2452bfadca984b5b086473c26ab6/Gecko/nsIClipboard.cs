using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("ceaa0047-647f-4b8e-ad1c-aff9fa62aa51")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIClipboard
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetData([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable, [MarshalAs(UnmanagedType.Interface)] nsIClipboardOwner anOwner, int aWhichClipboard);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetData([MarshalAs(UnmanagedType.Interface)] nsITransferable aTransferable, int aWhichClipboard);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EmptyClipboard(int aWhichClipboard);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool HasDataMatchingFlavors([MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] string[] aFlavorList, uint aLength, int aWhichClipboard);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SupportsSelectionClipboard();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool SupportsFindClipboard();
}
