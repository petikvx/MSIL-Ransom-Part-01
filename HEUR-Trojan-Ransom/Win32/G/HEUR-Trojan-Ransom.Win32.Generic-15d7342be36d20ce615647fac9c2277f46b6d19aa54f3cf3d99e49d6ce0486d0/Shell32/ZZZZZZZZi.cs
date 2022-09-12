using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Shell32;

[ComImport]
[DefaultMember("Title")]
[CompilerGenerated]
[TypeIdentifier]
[Guid("BBCBDE60-C3FF-11CE-8350-444553540000")]
public interface ZZZZZZZZi
{
	[DispId(0)]
	string ZZZZZZZZk
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	void _VtblGap1_4();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743813)]
	[return: MarshalAs(UnmanagedType.Interface)]
	ZZZZZZZZl ZZZZZZZZj([In][MarshalAs(UnmanagedType.BStr)] string string_0);
}
