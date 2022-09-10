using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace OpenNETCF.Desktop.Communication;

[ComImport]
[Guid("499C0C20-A766-11cf-8011-00A0C90A8F78")]
internal class DccMan
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern DccMan();
}
