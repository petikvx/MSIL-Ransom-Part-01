using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("06b31b15-ebf5-4e74-a0e2-6bc0a18a3969")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXULTreeBuilder
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFResource GetResourceAtIndex(int aRowIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetIndexOfResource([MarshalAs(UnmanagedType.Interface)] nsIRDFResource resource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddObserver([MarshalAs(UnmanagedType.Interface)] nsIXULTreeBuilderObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveObserver([MarshalAs(UnmanagedType.Interface)] nsIXULTreeBuilderObserver aObserver);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Sort([MarshalAs(UnmanagedType.Interface)] nsIDOMElement aColumnElement);
}
