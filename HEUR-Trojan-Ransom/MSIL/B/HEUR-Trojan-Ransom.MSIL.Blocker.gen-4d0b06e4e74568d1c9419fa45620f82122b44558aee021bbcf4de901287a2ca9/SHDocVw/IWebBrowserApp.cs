using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SHDocVw;

[ComImport]
[Guid("0002DF05-0000-0000-C000-000000000046")]
[CompilerGenerated]
[TypeIdentifier]
[DefaultMember("Name")]
public interface IWebBrowserApp : IWebBrowser
{
	[DispId(0)]
	string Name
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
	}

	void _VtblGap1_29();
}
