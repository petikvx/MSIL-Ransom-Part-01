using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a8285dae-f125-454f-9d1b-089e3f01b2c4")]
public interface nsIAssociatedContentSecurity
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCountSubRequestsBrokenSecurityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCountSubRequestsBrokenSecurityAttribute(int aCountSubRequestsBrokenSecurity);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetCountSubRequestsNoSecurityAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCountSubRequestsNoSecurityAttribute(int aCountSubRequestsNoSecurity);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Flush();
}
