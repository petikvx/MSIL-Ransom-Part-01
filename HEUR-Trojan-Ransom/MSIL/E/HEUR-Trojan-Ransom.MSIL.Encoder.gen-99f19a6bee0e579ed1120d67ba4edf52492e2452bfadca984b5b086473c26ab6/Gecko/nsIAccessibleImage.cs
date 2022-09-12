using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("09086623-0f09-4310-ac56-c2cda7c29648")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAccessibleImage
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetImagePosition(uint coordType, ref int x, ref int y);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetImageSize(ref int width, ref int height);
}
