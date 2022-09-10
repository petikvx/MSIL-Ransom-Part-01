using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111CC-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxIndex
{
	[DispId(67073)]
	int Count
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(67073)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67072)]
	[return: MarshalAs(UnmanagedType.Interface)]
	HxSession GetSession();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67074)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetStringFromSlot([In] int iSlot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67078)]
	int GetLevelFromSlot([In] int iSlot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67075)]
	int GetSlotFromString([In][MarshalAs(UnmanagedType.BStr)] string bszLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67076)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxTopicList GetTopicsFromSlot([In] int uiSlot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67077)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxTopicList GetTopicsFromString([In][MarshalAs(UnmanagedType.BStr)] string bszLink, [In] int options);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67079)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetInfoFromSlot([In] int iSlot, out int piLevel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67080)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxIndexPropId propid);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67081)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetCrossRef([In] int iSlot);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67082)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetFullStringFromSlot([In] int iSlot, [In][MarshalAs(UnmanagedType.BStr)] string sep);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(67083)]
	int GetCrossRefSlot([In] int iSlot);
}
