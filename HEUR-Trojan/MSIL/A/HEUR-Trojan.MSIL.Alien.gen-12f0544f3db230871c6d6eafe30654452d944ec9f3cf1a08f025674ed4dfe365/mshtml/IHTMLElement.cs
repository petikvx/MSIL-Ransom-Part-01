using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml;

[ComImport]
[Guid("3050F1FF-98B5-11CF-BB82-00AA00BDCE0B")]
[CompilerGenerated]
[TypeIdentifier]
public interface IHTMLElement
{
	string innerHTML
	{
		[DispId(-2147417086)]
		[return: MarshalAs(UnmanagedType.BStr)]
		get;
		[DispId(-2147417086)]
		[param: In]
		[param: MarshalAs(UnmanagedType.BStr)]
		set;
	}

	void _VtblGap1_50();
}
