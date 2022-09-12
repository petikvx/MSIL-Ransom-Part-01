using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Gecko;

[ComImport]
[Guid("04dd3a01-a74e-44aa-8d49-2c30478fd7b8")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface nsIPrintSettings
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintOptions(int aType, [MarshalAs(UnmanagedType.U1)] bool aTurnOnOff);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPrintOptions(int aType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPrintOptionsBits();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintOptionsBits(int bits);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEffectivePageSize(ref double aWidth, ref double aHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrintSettings Clone();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void Assign([MarshalAs(UnmanagedType.Interface)] nsIPrintSettings aPS);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.Interface)]
	nsIPrintSession GetPrintSessionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintSessionAttribute([MarshalAs(UnmanagedType.Interface)] nsIPrintSession aPrintSession);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetStartPageRangeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetStartPageRangeAttribute(int aStartPageRange);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetEndPageRangeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEndPageRangeAttribute(int aEndPageRange);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetEdgeTopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEdgeTopAttribute(double aEdgeTop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetEdgeLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEdgeLeftAttribute(double aEdgeLeft);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetEdgeBottomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEdgeBottomAttribute(double aEdgeBottom);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetEdgeRightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEdgeRightAttribute(double aEdgeRight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetMarginTopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMarginTopAttribute(double aMarginTop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetMarginLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMarginLeftAttribute(double aMarginLeft);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetMarginBottomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMarginBottomAttribute(double aMarginBottom);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetMarginRightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMarginRightAttribute(double aMarginRight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetUnwriteableMarginTopAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUnwriteableMarginTopAttribute(double aUnwriteableMarginTop);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetUnwriteableMarginLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUnwriteableMarginLeftAttribute(double aUnwriteableMarginLeft);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetUnwriteableMarginBottomAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUnwriteableMarginBottomAttribute(double aUnwriteableMarginBottom);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetUnwriteableMarginRightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUnwriteableMarginRightAttribute(double aUnwriteableMarginRight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetScalingAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetScalingAttribute(double aScaling);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPrintBGColorsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintBGColorsAttribute([MarshalAs(UnmanagedType.U1)] bool aPrintBGColors);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPrintBGImagesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintBGImagesAttribute([MarshalAs(UnmanagedType.U1)] bool aPrintBGImages);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetPrintRangeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintRangeAttribute(short aPrintRange);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetTitleAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetTitleAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aTitle);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetDocURLAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDocURLAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aDocURL);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetHeaderStrLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeaderStrLeftAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aHeaderStrLeft);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetHeaderStrCenterAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeaderStrCenterAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aHeaderStrCenter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetHeaderStrRightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHeaderStrRightAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aHeaderStrRight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetFooterStrLeftAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFooterStrLeftAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aFooterStrLeft);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetFooterStrCenterAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFooterStrCenterAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aFooterStrCenter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetFooterStrRightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetFooterStrRightAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aFooterStrRight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetHowToEnableFrameUIAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetHowToEnableFrameUIAttribute(short aHowToEnableFrameUI);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsCancelledAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsCancelledAttribute([MarshalAs(UnmanagedType.U1)] bool aIsCancelled);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetPrintFrameTypeUsageAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintFrameTypeUsageAttribute(short aPrintFrameTypeUsage);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetPrintFrameTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintFrameTypeAttribute(short aPrintFrameType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPrintSilentAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintSilentAttribute([MarshalAs(UnmanagedType.U1)] bool aPrintSilent);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShrinkToFitAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShrinkToFitAttribute([MarshalAs(UnmanagedType.U1)] bool aShrinkToFit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetShowPrintProgressAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetShowPrintProgressAttribute([MarshalAs(UnmanagedType.U1)] bool aShowPrintProgress);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetPaperNameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPaperNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPaperName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetPaperSizeTypeAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPaperSizeTypeAttribute(short aPaperSizeType);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetPaperDataAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPaperDataAttribute(short aPaperData);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetPaperWidthAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPaperWidthAttribute(double aPaperWidth);

	[MethodImpl(MethodImplOptions.InternalCall)]
	double GetPaperHeightAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPaperHeightAttribute(double aPaperHeight);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetPaperSizeUnitAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPaperSizeUnitAttribute(short aPaperSizeUnit);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPrintReversedAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintReversedAttribute([MarshalAs(UnmanagedType.U1)] bool aPrintReversed);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPrintInColorAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintInColorAttribute([MarshalAs(UnmanagedType.U1)] bool aPrintInColor);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetOrientationAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOrientationAttribute(int aOrientation);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetNumCopiesAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetNumCopiesAttribute(int aNumCopies);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetPrinterNameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrinterNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aPrinterName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPrintToFileAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintToFileAttribute([MarshalAs(UnmanagedType.U1)] bool aPrintToFile);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")]
	string GetToFileNameAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetToFileNameAttribute([MarshalAs(UnmanagedType.CustomMarshaler, MarshalType = "Gecko.CustomMarshalers.WStringMarshaler")] string aToFileName);

	[MethodImpl(MethodImplOptions.InternalCall)]
	short GetOutputFormatAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetOutputFormatAttribute(short aOutputFormat);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetPrintPageDelayAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPrintPageDelayAttribute(int aPrintPageDelay);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetResolutionAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetResolutionAttribute(int aResolution);

	[MethodImpl(MethodImplOptions.InternalCall)]
	int GetDuplexAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetDuplexAttribute(int aDuplex);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInitializedFromPrinterAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsInitializedFromPrinterAttribute([MarshalAs(UnmanagedType.U1)] bool aIsInitializedFromPrinter);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetIsInitializedFromPrefsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetIsInitializedFromPrefsAttribute([MarshalAs(UnmanagedType.U1)] bool aIsInitializedFromPrefs);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[return: MarshalAs(UnmanagedType.U1)]
	bool GetPersistMarginBoxSettingsAttribute();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetPersistMarginBoxSettingsAttribute([MarshalAs(UnmanagedType.U1)] bool aPersistMarginBoxSettings);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetMarginInTwips(IntPtr aMargin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetEdgeInTwips(IntPtr aEdge);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetMarginInTwips(IntPtr aMargin);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetEdgeInTwips(IntPtr aEdge);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetupSilentPrinting();

	[MethodImpl(MethodImplOptions.InternalCall)]
	void SetUnwriteableMarginInTwips(IntPtr aEdge);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetUnwriteableMarginInTwips(IntPtr aEdge);

	[MethodImpl(MethodImplOptions.InternalCall)]
	void GetPageRanges(IntPtr aPages);
}
