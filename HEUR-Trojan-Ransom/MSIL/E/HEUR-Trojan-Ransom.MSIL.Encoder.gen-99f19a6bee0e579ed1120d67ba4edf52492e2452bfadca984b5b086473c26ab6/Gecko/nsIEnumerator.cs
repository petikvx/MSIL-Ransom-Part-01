using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("ad385286-cbc4-11d2-8cca-0060b0fc14a3")]
public interface nsIEnumerator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void First();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Next();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports CurrentItem();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void IsDone();
}
