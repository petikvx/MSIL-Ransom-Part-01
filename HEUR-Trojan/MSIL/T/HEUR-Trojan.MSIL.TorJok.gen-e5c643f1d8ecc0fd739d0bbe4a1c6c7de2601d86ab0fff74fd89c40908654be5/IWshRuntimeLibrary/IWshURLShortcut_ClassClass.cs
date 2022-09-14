using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[Guid("F935DC2C-1CF0-11D0-ADB9-00C04FD58A0B")]
[ClassInterface(0)]
[TypeLibType(16)]
[DefaultMember("FullName")]
public sealed class IWshURLShortcut_ClassClass : IWshURLShortcut, IWshURLShortcut_Class
{
	[DispId(0)]
	public virtual extern string FullName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(1005)]
	public virtual extern string TargetPath
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1005)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(1005)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	internal extern IWshURLShortcut_ClassClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2000)]
	[TypeLibFunc(64)]
	public virtual extern void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2001)]
	public virtual extern void Save();
}
