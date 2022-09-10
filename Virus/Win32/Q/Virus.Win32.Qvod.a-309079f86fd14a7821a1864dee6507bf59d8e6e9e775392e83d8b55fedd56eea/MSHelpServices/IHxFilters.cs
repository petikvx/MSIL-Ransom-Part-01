using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("314111E3-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxFilters
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66048)]
	int Count();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66049)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFilter([In] int iIndex, [MarshalAs(UnmanagedType.BStr)] out string pbstrName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66054)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFilterName([In] int iIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66055)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFilterQuery([In] int iIndex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66050)]
	void RegisterFilter([In][MarshalAs(UnmanagedType.BStr)] string bstrName, [In][MarshalAs(UnmanagedType.BStr)] string bstrQuery);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66051)]
	void RemoveFilter([In][MarshalAs(UnmanagedType.BStr)] string bstrName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66052)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string FindFilter([In][MarshalAs(UnmanagedType.BStr)] string bstrName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66053)]
	void SetNamespace([In][MarshalAs(UnmanagedType.BStr)] string bstrName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66057)]
	void SetCollectionFiltersFlag([In] bool vb);
}
