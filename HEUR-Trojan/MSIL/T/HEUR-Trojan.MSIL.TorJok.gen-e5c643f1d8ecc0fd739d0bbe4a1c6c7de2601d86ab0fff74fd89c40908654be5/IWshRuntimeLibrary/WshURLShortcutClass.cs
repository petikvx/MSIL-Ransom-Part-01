using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[ClassInterface(0)]
[DefaultMember("FullName")]
[Guid("50E13488-6F1E-4450-96B0-873755403955")]
public sealed class WshURLShortcutClass : IWshURLShortcut, WshURLShortcut
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
	internal extern WshURLShortcutClass();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2000)]
	[TypeLibFunc(64)]
	public virtual extern void Load([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2001)]
	public virtual extern void Save();
}
