using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[Guid("ecabb0c8-7f19-11d2-978e-0000f8757e2a")]
internal class CServiceConfig
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public extern CServiceConfig();
}
