using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
[Guid("9A7CA4B0-FBBA-11d4-A869-00105A183419")]
public interface nsIWebBrowserPrint
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrintSettings GetGlobalPrintSettingsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrintSettings GetCurrentPrintSettingsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIDOMWindow GetCurrentChildDOMWindowAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDoingPrintAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetDoingPrintPreviewAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsFramesetDocumentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsFramesetFrameSelectedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsIFrameSelectedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsRangeSelectionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPrintPreviewNumPagesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Print([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aThePrintSettings, [MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aWPListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PrintPreview([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aThePrintSettings, [MarshalAs(UnmanagedType.Interface)] nsIDOMWindow aChildDOMWin, [MarshalAs(UnmanagedType.Interface)] nsIWebProgressListener aWPListener);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void PrintPreviewNavigate(short aNavType, int aPageNum);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Cancel();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void EnumerateDocumentNames(ref uint aCount, [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] ref IntPtr[] aResult);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void ExitPrintPreview();
}
