using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace UPNPLib;

[ComImport]
[TypeLibType(256)]
[Guid("0405AF4F-8B5C-447C-80F2-B75984A31F3C")]
[InterfaceType(1)]
public interface IUPnPHttpHeaderControl
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void AddRequestHeaders([In][MarshalAs(UnmanagedType.BStr)] string string_0);
}
