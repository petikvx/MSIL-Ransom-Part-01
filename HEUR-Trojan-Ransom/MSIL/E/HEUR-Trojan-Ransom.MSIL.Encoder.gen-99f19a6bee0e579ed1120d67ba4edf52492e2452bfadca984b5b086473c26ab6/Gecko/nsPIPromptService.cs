using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("C60A1955-6CB3-4827-8EF8-4F5C668AF0B3")]
public interface nsPIPromptService
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoDialog([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aParent, [MarshalAs(UnmanagedType.Interface)] nsIDialogParamBlock aParamBlock, [MarshalAs(UnmanagedType.LPStr)] string aChromeURL);
}
