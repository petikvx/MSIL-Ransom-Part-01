using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[TypeIdentifier]
[Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
[CompilerGenerated]
[DefaultMember("Name")]
public interface IWebBrowser2 : IWebBrowserApp
{
	[DispId(211)]
	string LocationURL
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(211)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(0)]
	new string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	[DispId(400)]
	string FullName
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(400)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	void _VtblGap1_23();

	void _VtblGap2_5();

	void _VtblGap3_1();
}
