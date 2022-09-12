using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("3CC75360-484A-11D2-BC16-00805F912FE7")]
public interface nsIRDFObserver
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnAssert([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnUnassert([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnChange([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aOldTarget, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aNewTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnMove([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aOldSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aNewSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aTarget);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnBeginUpdateBatch([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnEndUpdateBatch([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource);
}
