using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("a1b2e167-b748-42bf-ba85-996ec39062b9")]
public interface nsIXULRuntime
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInSafeModeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetLogConsoleErrorsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetLogConsoleErrorsAttribute([MarshalAs(UnmanagedType.U1)] bool aLogConsoleErrors);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetOSAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aOS);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetXPCOMABIAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aXPCOMABI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetWidgetToolkitAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aWidgetToolkit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetProcessTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	uint GetProcessIDAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetBrowserTabsRemoteAutostartAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAccessibilityEnabledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIs64BitAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void InvalidateCachesOnRestart();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnsureContentProcess();

	[MethodImpl(MethodImplOptions.InternalCall)]
	long GetReplacedLockTimeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetLastRunCrashIDAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.AStringMarshaler")] nsAStringBase aLastRunCrashID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsReleaseBuildAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsOfficialBrandingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDefaultUpdateChannelAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDefaultUpdateChannel);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetDistributionIDAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aDistributionID);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsOfficialAttribute();
}
