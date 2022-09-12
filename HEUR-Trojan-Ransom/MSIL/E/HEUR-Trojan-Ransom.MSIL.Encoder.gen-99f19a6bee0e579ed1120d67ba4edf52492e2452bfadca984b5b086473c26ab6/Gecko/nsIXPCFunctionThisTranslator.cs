using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("f5f84b70-92eb-41f1-a1dd-2eaac0ed564c")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIXPCFunctionThisTranslator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsISupports TranslateThis([MarshalAs(UnmanagedType.Interface)] nsISupports aInitialThis);
}
