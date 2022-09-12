using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("D4214E91-FB94-11D2-BDD8-00104BDE6048")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIRDFContainerUtils
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsOrdinalProperty([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aProperty);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFResource IndexToOrdinalResource(int aIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int OrdinalResourceToIndex([MarshalAs(UnmanagedType.Interface)] nsIRDFResource aOrdinal);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsContainer([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsEmpty([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsBag([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsSeq([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool IsAlt([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFContainer MakeBag([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFContainer MakeSeq([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFContainer MakeAlt([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aResource);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int IndexOf([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aContainer, [MarshalAs(UnmanagedType.Interface)] nsIRDFNode aElement);
}
