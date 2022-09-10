using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111DA-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4160)]
public interface IHxPlugIn
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66304)]
	void RegisterHelpPlugIn([MarshalAs(UnmanagedType.BStr)] string bstrProductNamespace, [MarshalAs(UnmanagedType.BStr)] string bstrProductHxt, [MarshalAs(UnmanagedType.BStr)] string bstrNamespace, [MarshalAs(UnmanagedType.BStr)] string bstrHxt, [MarshalAs(UnmanagedType.BStr)] string bstrHxa, int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66305)]
	void RemoveHelpPlugIn([MarshalAs(UnmanagedType.BStr)] string bstrProductNamespace, [MarshalAs(UnmanagedType.BStr)] string bstrProductHxt, [MarshalAs(UnmanagedType.BStr)] string bstrNamespace, [MarshalAs(UnmanagedType.BStr)] string bstrHxt, [MarshalAs(UnmanagedType.BStr)] string bstrHxa);
}
