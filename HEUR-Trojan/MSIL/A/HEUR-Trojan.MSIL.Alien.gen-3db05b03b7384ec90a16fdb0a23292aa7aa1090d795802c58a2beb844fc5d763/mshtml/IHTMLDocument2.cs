using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace mshtml;

[ComImport]
[Guid("332C4425-26CB-11D0-B483-00C04FD90119")]
[TypeIdentifier]
[CompilerGenerated]
public interface IHTMLDocument2 : IHTMLDocument
{
	IHTMLElement body
	{
		[DispId(1004)]
		[return: MarshalAs(UnmanagedType.Interface)]
		get;
	}

	void _VtblGap1_2();
}
