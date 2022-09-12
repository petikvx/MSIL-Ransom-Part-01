using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("6621f6d5-6c04-4a0e-9e74-447db221484e")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIAppStartup
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void CreateHiddenWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DestroyHiddenWindow();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Run();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnterLastWindowClosingSurvivalArea();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExitLastWindowClosingSurvivalArea();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetAutomaticSafeModeNecessaryAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void RestartInSafeMode(uint aQuitMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool TrackStartupCrashBegin();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void TrackStartupCrashEnd();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Quit(uint aMode);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShuttingDownAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetStartingUpAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DoneStartingUp();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetRestartingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetWasRestartedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	JsVal GetStartupInfo(IntPtr jsContext);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInterruptedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInterruptedAttribute([MarshalAs(UnmanagedType.U1)] bool aInterrupted);
}
