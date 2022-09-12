using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("78ec5811-78ee-4239-a554-3303f823dbbc")]
public interface nsIAndroidBrowserApp
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIBrowserTab GetSelectedTabAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIBrowserTab GetBrowserTab(int tabId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPreferences(int requestId, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] prefNames, uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ObservePreferences(int requestId, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] IntPtr[] prefNames, uint count);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RemovePreferenceObservers(int requestId);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIUITelemetryObserver GetUITelemetryObserver();
}
