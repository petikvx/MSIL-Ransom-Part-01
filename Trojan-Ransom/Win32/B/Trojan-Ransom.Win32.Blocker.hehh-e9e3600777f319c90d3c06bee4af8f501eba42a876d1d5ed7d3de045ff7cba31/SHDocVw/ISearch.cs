using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("BA9239A4-3DD5-11D2-BF8B-00C04FB93661")]
[TypeLibType(4176)]
public interface ISearch
{
	[DispId(1610743808)]
	string Title
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743808)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743809)]
	string Id
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743809)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1610743810)]
	string URL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1610743810)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}
}
