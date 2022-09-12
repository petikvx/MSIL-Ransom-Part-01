using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("d007ceff-c978-486a-b697-384ca01997be")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITransactionList
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetNumItemsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool ItemIsBatch(int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITransaction GetItem(int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetData(int aIndex, ref uint aLength, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] ref nsISupports[] aData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetNumChildrenForItem(int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsITransactionList GetChildListForItem(int aIndex);
}
