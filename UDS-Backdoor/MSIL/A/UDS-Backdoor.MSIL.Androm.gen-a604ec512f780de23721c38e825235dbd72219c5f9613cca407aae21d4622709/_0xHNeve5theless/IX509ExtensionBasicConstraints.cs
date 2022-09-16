using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using _0xHChebe4;

namespace _0xHNeve5theless;

[ComImport]
[TypeIdentifier]
[Guid("728AB316-217D-11DA-B2A4-000E7BBB2B09")]
[CompilerGenerated]
public interface IX509ExtensionBasicConstraints : IX509Extension
{
	void _VtblGap1_5();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[DispId(1610809344)]
	void InitializeEncode([In] bool IsCA, [In] int PathLenConstraint);
}
