using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("D4214E90-FB94-11D2-BDD8-00104BDE6048")]
public interface nsIRDFContainer
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFDataSource GetDataSourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFResource GetResourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIRDFDataSource aDataSource, [MarshalAs(UnmanagedType.Interface)] nsIRDFResource aContainer);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCount();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISimpleEnumerator GetElements();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void AppendElement([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aElement);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemoveElement([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aElement, [MarshalAs(UnmanagedType.U1)] bool aRenumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InsertElementAt([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aElement, int aIndex, [MarshalAs(UnmanagedType.U1)] bool aRenumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFNode RemoveElementAt(int aIndex, [MarshalAs(UnmanagedType.U1)] bool aRenumber);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int IndexOf([MarshalAs(UnmanagedType.Interface)] nsIRDFNode aElement);
}
