using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[TypeLibType(4176)]
[Guid("E572D3C9-37BE-4AE2-825D-D521763E3108")]
public interface IShellNameSpace : IShellFavoritesNameSpace
{
	[DispId(10)]
	new bool SubscriptionsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10)]
		get;
	}

	[DispId(14)]
	int EnumOptions
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(14)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(14)]
		[param: In]
		set;
	}

	[DispId(15)]
	object SelectedItem
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(15)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(15)]
		[param: In]
		[param: MarshalAs(UnmanagedType.IDispatch)]
		set;
	}

	[DispId(16)]
	object Root
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(16)]
		[return: MarshalAs(UnmanagedType.Struct)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(16)]
		[param: In]
		[param: MarshalAs(UnmanagedType.Struct)]
		set;
	}

	[DispId(17)]
	int Depth
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(17)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(17)]
		[param: In]
		set;
	}

	[DispId(18)]
	uint Mode
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(18)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(18)]
		[param: In]
		set;
	}

	[DispId(19)]
	uint Flags
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(19)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(19)]
		[param: In]
		set;
	}

	[DispId(20)]
	uint TVFlags
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(20)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(20)]
		[param: In]
		set;
	}

	[DispId(21)]
	string Columns
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(21)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(21)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(22)]
	int CountViewTypes
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(22)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	new void MoveSelectionUp();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	new void MoveSelectionDown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(3)]
	new void ResetSort();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	new void NewFolder();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(5)]
	new void Synchronize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(6)]
	new void Import();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(7)]
	new void Export();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(8)]
	new void InvokeContextMenuCommand([In][MarshalAs(UnmanagedType.BStr)] string strCommand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(9)]
	new void MoveSelectionTo();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(11)]
	new bool CreateSubscriptionForSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(12)]
	new bool DeleteSubscriptionForSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(13)]
	new void SetRoot([In][MarshalAs(UnmanagedType.BStr)] string bstrFullPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(23)]
	void SetViewType([In] int iType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(24)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object SelectedItems();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(25)]
	void Expand([In][MarshalAs(UnmanagedType.Struct)] object var, int iDepth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(26)]
	void UnselectAll();
}
