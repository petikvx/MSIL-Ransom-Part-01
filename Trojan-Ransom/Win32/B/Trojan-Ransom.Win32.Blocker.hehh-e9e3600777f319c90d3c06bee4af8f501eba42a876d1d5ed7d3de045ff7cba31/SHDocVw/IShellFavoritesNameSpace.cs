using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[TypeLibType(4176)]
[Guid("55136804-B2DE-11D1-B9F2-00A0C98BC547")]
public interface IShellFavoritesNameSpace
{
	[DispId(10)]
	bool SubscriptionsEnabled
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1)]
	void MoveSelectionUp();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2)]
	void MoveSelectionDown();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(3)]
	void ResetSort();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(4)]
	void NewFolder();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(5)]
	void Synchronize();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(6)]
	void Import();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(7)]
	void Export();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(8)]
	void InvokeContextMenuCommand([In][MarshalAs(UnmanagedType.BStr)] string strCommand);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(9)]
	void MoveSelectionTo();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(11)]
	bool CreateSubscriptionForSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(12)]
	bool DeleteSubscriptionForSelection();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(13)]
	void SetRoot([In][MarshalAs(UnmanagedType.BStr)] string bstrFullPath);
}
