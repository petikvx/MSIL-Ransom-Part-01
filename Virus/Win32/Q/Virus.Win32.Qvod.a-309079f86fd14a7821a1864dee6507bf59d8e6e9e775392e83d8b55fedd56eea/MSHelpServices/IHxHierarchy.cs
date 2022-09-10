using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace MSHelpServices;

[ComImport]
[Guid("314111B2-A502-11D2-BBCA-00C04F8EC294")]
[TypeLibType(4288)]
public interface IHxHierarchy
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66561)]
	int GetRoot();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66562)]
	int GetParent([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66563)]
	int GetSibling([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66564)]
	int GetFirstChild([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66565)]
	int GetNextFromUrl([In][MarshalAs(UnmanagedType.BStr)] string pURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66566)]
	int GetPrevFromUrl([In][MarshalAs(UnmanagedType.BStr)] string pURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66567)]
	HxHierarchyNodeType GetType([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66568)]
	bool IsNew([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66569)]
	bool HasChild([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66570)]
	[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)]
	object[] GetSyncInfo([In][MarshalAs(UnmanagedType.BStr)] string pURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66571)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetTitle([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66572)]
	int GetImageIndexes([In] int hNode, out int pOpen);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66573)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string GetURL([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66574)]
	bool OnNavigation([In][MarshalAs(UnmanagedType.BStr)] string pbstrURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66575)]
	void OnHierarchyNavigation([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66576)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object GetProperty([In] HxHierarchyPropId propid, [In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66577)]
	int GetNextFromNode([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66578)]
	int GetPrevFromNode([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66579)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IHxTopic GetTopic([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66580)]
	int GetOpenImageIndex([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66581)]
	int GetClosedImageIndex([In] int hNode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(66582)]
	void PrintNode([In] int hwnd, [In] int hNode, [In] HxHierarchy_PrintNode_Options options);
}
