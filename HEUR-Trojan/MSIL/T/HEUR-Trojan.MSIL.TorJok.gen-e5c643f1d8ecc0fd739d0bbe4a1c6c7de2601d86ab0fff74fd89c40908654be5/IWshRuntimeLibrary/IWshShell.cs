using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace IWshRuntimeLibrary;

[ComImport]
[TypeLibType(4176)]
[Guid("F935DC21-1CF0-11D0-ADB9-00C04FD58A0B")]
public interface IWshShell
{
	[DispId(100)]
	IWshCollection SpecialFolders
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(100)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[DispId(200)]
	IWshEnvironment Environment
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(200)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1000)]
	int Run([In][MarshalAs(UnmanagedType.BStr)] string Command, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object WindowStyle, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object WaitOnReturn);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1001)]
	int Popup([In][MarshalAs(UnmanagedType.BStr)] string Text, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object SecondsToWait, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Title, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1002)]
	[return: MarshalAs(UnmanagedType.IDispatch)]
	object CreateShortcut([In][MarshalAs(UnmanagedType.BStr)] string PathLink);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1006)]
	[return: MarshalAs(UnmanagedType.BStr)]
	string ExpandEnvironmentStrings([In][MarshalAs(UnmanagedType.BStr)] string Src);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2000)]
	[return: MarshalAs(UnmanagedType.Struct)]
	object RegRead([In][MarshalAs(UnmanagedType.BStr)] string Name);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2001)]
	void RegWrite([In][MarshalAs(UnmanagedType.BStr)] string Name, [In][MarshalAs(UnmanagedType.Struct)] ref object Value, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Type);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(2002)]
	void RegDelete([In][MarshalAs(UnmanagedType.BStr)] string Name);
}
