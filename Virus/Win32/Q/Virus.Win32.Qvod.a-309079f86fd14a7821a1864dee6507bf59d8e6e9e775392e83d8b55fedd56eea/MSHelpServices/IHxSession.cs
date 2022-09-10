using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("31411192-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4304)]
public interface IHxSession
{
	[DispId(65799)]
	IHxCollection Collection
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(65799)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(65803)]
	short LangId
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(65803)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(65803)]
		[param: In]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(65792)]
	void Initialize([In][MarshalAs(UnmanagedType.BStr)] string NameSpace, [In] int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(65793)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxTopicList Query([In][MarshalAs(UnmanagedType.BStr)] string keywords, [In][MarshalAs(UnmanagedType.BStr)] string NavDataMoniker, [In] int options, [In][MarshalAs(UnmanagedType.BStr)] string FilterMoniker);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(65794)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxTopic QueryForTopic([In][MarshalAs(UnmanagedType.BStr)] string keywords, [In][MarshalAs(UnmanagedType.BStr)] string NavDataMoniker, [In] int options, [In][MarshalAs(UnmanagedType.BStr)] string FilterMoniker);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(65795)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string QueryForUrl([In][MarshalAs(UnmanagedType.BStr)] string keywords, [In][MarshalAs(UnmanagedType.BStr)] string NavDataMoniker, [In] int options, [In][MarshalAs(UnmanagedType.BStr)] string FilterMoniker);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(65796)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object GetNavigationInterface([In][MarshalAs(UnmanagedType.BStr)] string NavDataMoniker, [In][MarshalAs(UnmanagedType.BStr)] string FilterMoniker, [In] ref Guid refiid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(65797)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object GetNavigationObject([In][MarshalAs(UnmanagedType.BStr)] string NavDataMoniker, [In][MarshalAs(UnmanagedType.BStr)] string FilterMoniker);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(65798)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxQuery GetQueryObject([In][MarshalAs(UnmanagedType.BStr)] string NavDataMoniker, [In][MarshalAs(UnmanagedType.BStr)] string FilterMoniker);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(65805)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxRegFilterList GetFilterList();
}
