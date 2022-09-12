using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("75f158a0-cadd-11d2-8cca-0060b0fc14a3")]
public interface nsIBidirectionalEnumerator : nsIEnumerator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	new void First();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void Next();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	new nsISupports CurrentItem();

	[MethodImpl(MethodImplOptions.InternalCall)]
	new void IsDone();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Last();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Prev();
}
