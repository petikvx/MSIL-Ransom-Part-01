using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("44b78386-1dd2-11b2-9ad2-e4eee2ca1916")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsITooltipListener
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnShowTooltip(int aXCoords, int aYCoords, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTipText);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void OnHideTooltip();
}
