using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[TypeIdentifier]
[Guid("D3A5683B-C9CA-3711-8F0C-DCB51C2B0DA3")]
[CompilerGenerated]
public interface ICpfcModelDescriptor
{
	void _VtblGap1_1();

	[DispId(1610743809)]
	[return: MarshalAs(UnmanagedType.Interface)]
	IpfcModelDescriptor CreateFromFileName([In][MarshalAs(UnmanagedType.BStr)] string _FileName);
}
