using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("22b56ffc-3149-43c5-b5a9-b3a6b678de93")]
public interface nsIBrowserProfileMigrator
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Migrate(ushort aItems, [MarshalAs(UnmanagedType.Interface)] nsIProfileStartup aStartup, ref JsVal aProfile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetMigrateData(ref JsVal aProfile, [MarshalAs(UnmanagedType.U1)] bool aDoingStartup);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSourceExistsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetSourceProfilesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetSourceHomePageURLAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aSourceHomePageURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetSourceLockedAttribute();
}
