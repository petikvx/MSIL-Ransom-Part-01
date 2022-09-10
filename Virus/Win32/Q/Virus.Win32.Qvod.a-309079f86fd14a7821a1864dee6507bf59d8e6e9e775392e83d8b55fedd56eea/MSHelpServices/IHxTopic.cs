using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[TypeLibType(4288)]
[Guid("31411196-A502-11D2-BBCA-00C04F8EC294")]
public interface IHxTopic
{
	[DispId(68097)]
	string this[HxTopicGetTitleType optType, HxTopicGetTitleDefVal optDef]
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(68097)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(68098)]
	string URL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(68098)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(68099)]
	string Location
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(68099)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(68100)]
	int Rank
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(68100)]
		get;
	}

	[DispId(68101)]
	IHxAttributeList Attributes
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(68101)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(68102)]
	void GetInfo([MarshalAs(UnmanagedType.BStr)] out string pTitle, [MarshalAs(UnmanagedType.BStr)] out string pURL, [MarshalAs(UnmanagedType.BStr)] out string pLocation, out int pRank);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(68103)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxTopicPropId propid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(68104)]
	void SetProperty([In] HxTopicPropId propid, [In][MarshalAs(UnmanagedType.Struct)] object var);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(68105)]
	bool HasAttribute([In][MarshalAs(UnmanagedType.BStr)] string Name, [In][MarshalAs(UnmanagedType.BStr)] string Value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(68106)]
	bool HasAttrName([In][MarshalAs(UnmanagedType.BStr)] string Name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(68107)]
	void HighlightDocument([In][MarshalAs(UnmanagedType.IDispatch)] object pIDispatch);
}
