using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("4b968d4b-9c08-4635-a7e0-55084843f0fd")]
public interface nsILayoutDebuggingTools
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void Init([MarshalAs(UnmanagedType.Interface)] nsIDOMWindow win);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void NewURILoaded();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetVisualDebuggingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVisualDebuggingAttribute([MarshalAs(UnmanagedType.U1)] bool aVisualDebugging);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetVisualEventDebuggingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetVisualEventDebuggingAttribute([MarshalAs(UnmanagedType.U1)] bool aVisualEventDebugging);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPaintFlashingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPaintFlashingAttribute([MarshalAs(UnmanagedType.U1)] bool aPaintFlashing);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPaintDumpingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPaintDumpingAttribute([MarshalAs(UnmanagedType.U1)] bool aPaintDumping);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetInvalidateDumpingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetInvalidateDumpingAttribute([MarshalAs(UnmanagedType.U1)] bool aInvalidateDumping);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetEventDumpingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEventDumpingAttribute([MarshalAs(UnmanagedType.U1)] bool aEventDumping);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetMotionEventDumpingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMotionEventDumpingAttribute([MarshalAs(UnmanagedType.U1)] bool aMotionEventDumping);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetCrossingEventDumpingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetCrossingEventDumpingAttribute([MarshalAs(UnmanagedType.U1)] bool aCrossingEventDumping);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetReflowCountsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetReflowCountsAttribute([MarshalAs(UnmanagedType.U1)] bool aReflowCounts);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DumpWebShells();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DumpContent();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DumpFrames();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DumpViews();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DumpStyleSheets();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DumpStyleContexts();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void DumpReflowStats();
}
