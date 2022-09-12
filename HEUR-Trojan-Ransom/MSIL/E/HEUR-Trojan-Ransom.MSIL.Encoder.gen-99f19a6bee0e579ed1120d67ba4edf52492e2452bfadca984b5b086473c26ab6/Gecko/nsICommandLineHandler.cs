using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("d4b123df-51ee-48b1-a663-002180e60d3b")]
public interface nsICommandLineHandler
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Handle([MarshalAs(UnmanagedType.Interface)] nsICommandLine aCommandLine);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetHelpInfoAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHelpInfo);
}
