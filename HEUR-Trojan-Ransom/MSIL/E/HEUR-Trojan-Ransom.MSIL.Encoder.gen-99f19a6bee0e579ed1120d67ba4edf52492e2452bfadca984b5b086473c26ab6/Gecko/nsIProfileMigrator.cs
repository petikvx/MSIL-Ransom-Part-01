using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("3df284a5-2258-4d46-a664-761ecdc04c22")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIProfileMigrator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Migrate([MarshalAs(UnmanagedType.Interface)] nsIProfileStartup aStartup, [MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aKey);
}
