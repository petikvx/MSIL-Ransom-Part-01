using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("2F2F1F96-2BC1-4B1C-BE28-EA3774F4676A")]
[TypeLibType(2)]
[ClassInterface(0)]
[ComSourceInterfaces("SHDocVw.DShellNameSpaceEvents\0")]
public class ShellShellNameSpaceClass : IShellNameSpace, DShellNameSpaceEvents_Event, ShellShellNameSpace
{
	[DispId(10)]
	public virtual extern bool SubscriptionsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10)]
		get;
	}

	[DispId(14)]
	public virtual extern int EnumOptions
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
	public virtual extern object SelectedItem
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
	public virtual extern object Root
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
	public virtual extern int Depth
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
	public virtual extern uint Mode
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
	public virtual extern uint Flags
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
	public virtual extern uint TVFlags
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
	public virtual extern string Columns
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
	public virtual extern int CountViewTypes
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(22)]
		get;
	}

	public virtual extern event DShellNameSpaceEvents_FavoritesSelectionChangeEventHandler FavoritesSelectionChange;

	public virtual extern event DShellNameSpaceEvents_SelectionChangeEventHandler SelectionChange;

	public virtual extern event DShellNameSpaceEvents_DoubleClickEventHandler DoubleClick;

	public virtual extern event DShellNameSpaceEvents_InitializedEventHandler Initialized;

	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern ShellShellNameSpaceClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	public virtual extern void MoveSelectionUp();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	public virtual extern void MoveSelectionDown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(3)]
	public virtual extern void ResetSort();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	public virtual extern void NewFolder();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(5)]
	public virtual extern void Synchronize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(6)]
	public virtual extern void Import();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(7)]
	public virtual extern void Export();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(8)]
	public virtual extern void InvokeContextMenuCommand([In][MarshalAs(UnmanagedType.BStr)] string strCommand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(9)]
	public virtual extern void MoveSelectionTo();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(11)]
	public virtual extern bool CreateSubscriptionForSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(12)]
	public virtual extern bool DeleteSubscriptionForSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(13)]
	public virtual extern void SetRoot([In][MarshalAs(UnmanagedType.BStr)] string bstrFullPath);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(23)]
	public virtual extern void SetViewType([In] int iType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(24)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	public virtual extern object SelectedItems();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(25)]
	public virtual extern void Expand([In][MarshalAs(UnmanagedType.Struct)] object var, int iDepth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(26)]
	public virtual extern void UnselectAll();
}
