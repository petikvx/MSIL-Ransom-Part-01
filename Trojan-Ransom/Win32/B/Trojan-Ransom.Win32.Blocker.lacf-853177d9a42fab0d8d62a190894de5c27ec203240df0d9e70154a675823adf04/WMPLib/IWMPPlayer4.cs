using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace WMPLib;

[ComImport]
[CompilerGenerated]
[TypeIdentifier]
[Guid("6C497D62-8919-413C-82DB-E935FB3EC584")]
public interface IWMPPlayer4 : IWMPCore3
{
	[DispId(1)]
	string URL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[DispId(10)]
	WMPPlayState playState
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(10)]
		get;
	}

	[DispId(4)]
	IWMPControls controls
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(4)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(5)]
	IWMPSettings settings
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(5)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_1();

	void _VtblGap2_1();
}
