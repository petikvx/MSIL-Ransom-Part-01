using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111BC-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxRegister
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66817)]
	void RegisterNamespace([In][MarshalAs(UnmanagedType.BStr)] string bstrNamespace, [In][MarshalAs(UnmanagedType.BStr)] string bstrCollection, [In][MarshalAs(UnmanagedType.BStr)] string bstrDescription);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66818)]
	bool IsNamespace([In][MarshalAs(UnmanagedType.BStr)] string bstrNamespace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66830)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetCollection([In][MarshalAs(UnmanagedType.BStr)] string bstrNamespace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66829)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetDescription([In][MarshalAs(UnmanagedType.BStr)] string bstrNamespace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66819)]
	void RemoveNamespace([In][MarshalAs(UnmanagedType.BStr)] string bstrNamespace);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66822)]
	void RegisterHelpFile([In][MarshalAs(UnmanagedType.BStr)] string bstrNamespace, [In][MarshalAs(UnmanagedType.BStr)] string bstrId, [In] int LangId, [In][MarshalAs(UnmanagedType.BStr)] string bstrHelpFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66823)]
	int RegisterMedia([In][MarshalAs(UnmanagedType.BStr)] string bstrNamespace, [In][MarshalAs(UnmanagedType.BStr)] string bstrFriendly, [In][MarshalAs(UnmanagedType.BStr)] string bstrPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66825)]
	void RemoveHelpFile([In][MarshalAs(UnmanagedType.BStr)] string bstrNamespace, [In][MarshalAs(UnmanagedType.BStr)] string bstrId, [In] int LangId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66831)]
	void RegisterHelpFileSet([In][MarshalAs(UnmanagedType.BStr)] string bstrNamespace, [In][MarshalAs(UnmanagedType.BStr)] string bstrId, [In] int LangId, [In][MarshalAs(UnmanagedType.BStr)] string bstrHxs, [In][MarshalAs(UnmanagedType.BStr)] string bstrHxi, [In][MarshalAs(UnmanagedType.BStr)] string bstrHxq, [In][MarshalAs(UnmanagedType.BStr)] string bstrHxr, [In] int lHxsMediaId, [In] int lHxqMediaId, [In] int lHxrMediaId, [In] int lSampleMediaId);
}
