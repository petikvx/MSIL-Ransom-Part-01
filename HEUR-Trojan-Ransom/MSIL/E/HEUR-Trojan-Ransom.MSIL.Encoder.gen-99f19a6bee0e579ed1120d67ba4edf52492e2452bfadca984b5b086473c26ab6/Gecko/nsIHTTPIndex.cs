using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6F2BDBD0-58C3-11d3-BE36-00104BDE6048")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIHTTPIndex
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetBaseURLAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIRDFDataSource GetDataSourceAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.LPStr)]
	string GetEncodingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEncodingAttribute([MarshalAs(UnmanagedType.LPStr)] string aEncoding);
}
