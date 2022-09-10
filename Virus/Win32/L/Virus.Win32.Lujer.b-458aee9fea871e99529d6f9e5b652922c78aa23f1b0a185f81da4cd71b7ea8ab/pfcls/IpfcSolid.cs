using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace pfcls;

[ComImport]
[TypeIdentifier]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("8A84D15F-A4C1-3685-B698-886696B06024")]
[CompilerGenerated]
public interface IpfcSolid
{
	void _VtblGap1_5();

	void Regenerate([In][MarshalAs(UnmanagedType.Struct)] object _Instrs);
}
