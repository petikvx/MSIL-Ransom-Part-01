using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0xHIs5line;

namespace _0xHRegorge2;

[ComImport]
[TypeIdentifier]
[Guid("728AB303-217D-11DA-B2A4-000E7BBB2B09")]
[CompilerGenerated]
public interface IX500DistinguishedName
{
	void _VtblGap1_1();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610743809)]
	void Encode([In][MarshalAs(UnmanagedType.BStr)] string strName, [In] X500NameFlags NameFlags = X500NameFlags.XCN_CERT_NAME_STR_NONE);
}
