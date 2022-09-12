using System;
using System.Collections.Generic;

namespace Gecko;

public class PrintSettings : nsIPrintSettings
{
	private Dictionary<int, bool> m_printOptions = new Dictionary<int, bool>();

	private int m_printOptionsBits;

	private double m_effectivePageWidth;

	private double m_effectivePageHeight;

	private nsIPrintSession m_printSession;

	private int m_startPageRange;

	private int m_endPageRange;

	private double m_edgeTop;

	private double m_edgeLeft;

	private double m_edgeBottom;

	private double m_edgeRight;

	private double m_marginTop;

	private double m_marginLeft;

	private double m_marginBottom;

	private double m_marginRight;

	private double m_unwriteableMarginTop;

	private double m_unwriteableMarginLeft;

	private double m_unwriteableMarginBottom;

	private double m_unwriteableMarginRight;

	private double m_scaling;

	private bool m_printBGColors;

	private bool m_printBGImages;

	private short m_printRange;

	private string m_title;

	private string m_docURL;

	private string m_headerStrLeft;

	private string m_headerStrCenter;

	private string m_headerStrRight;

	private string m_footerStrLeft;

	private string m_footerStrCenter;

	private string m_footerStrRight;

	private short m_howToEnableFrameUI;

	private bool m_IsCancelled;

	private short m_printFrameTypeUsage;

	private short m_printFrameType;

	private bool m_printSilent;

	private bool m_shrinkToFit;

	private bool m_showPrintProgress;

	private string m_paperName;

	private short m_paperSizeType;

	private short m_paperData;

	private double m_paperWidth;

	private double m_paperHeight;

	private short m_paperSizeUnit;

	private string m_plexName;

	private string m_colorspace;

	private string m_resolutionName;

	private bool m_downloadFonts;

	private bool m_printReversed;

	private bool m_printInColor;

	private int m_orientation;

	private string m_printCommand;

	private int m_numCopies;

	private string m_printerName;

	private bool m_printToFile;

	private string m_toFileName;

	private short m_outputFormat;

	private int m_printPageDelay;

	private bool m_isInitializedFromPrinter;

	private bool m_isInitializedFromPrefs;

	public void SetPrintOptionsBits(int printOptionsBits)
	{
		m_printOptionsBits = printOptionsBits;
	}

	public void SetEffectivePageSize(double aWidth, double aHeight)
	{
		m_effectivePageWidth = aWidth;
		m_effectivePageHeight = aHeight;
	}

	public void SetPrintOptions(int aType, bool aTurnOnOff)
	{
		m_printOptions[aType] = aTurnOnOff;
	}

	public bool GetPrintOptions(int aType)
	{
		if (!m_printOptions.ContainsKey(aType))
		{
			return false;
		}
		return m_printOptions[aType];
	}

	public int GetPrintOptionsBits()
	{
		return m_printOptionsBits;
	}

	public void GetEffectivePageSize(ref double aWidth, ref double aHeight)
	{
		aWidth = m_effectivePageWidth;
		aHeight = m_effectivePageHeight;
	}

	public nsIPrintSettings Clone()
	{
		return (PrintSettings)MemberwiseClone();
	}

	public void Assign(nsIPrintSettings aPS)
	{
		throw new NotImplementedException();
	}

	public nsIPrintSession GetPrintSessionAttribute()
	{
		return m_printSession;
	}

	public void SetPrintSessionAttribute(nsIPrintSession aPrintSession)
	{
		m_printSession = aPrintSession;
	}

	public int GetStartPageRangeAttribute()
	{
		return m_startPageRange;
	}

	public void SetStartPageRangeAttribute(int aStartPageRange)
	{
		m_startPageRange = aStartPageRange;
	}

	public int GetEndPageRangeAttribute()
	{
		return m_endPageRange;
	}

	public void SetEndPageRangeAttribute(int aEndPageRange)
	{
		m_endPageRange = aEndPageRange;
	}

	public double GetEdgeTopAttribute()
	{
		return m_edgeTop;
	}

	public void SetEdgeTopAttribute(double aEdgeTop)
	{
		m_edgeTop = aEdgeTop;
	}

	public double GetEdgeLeftAttribute()
	{
		return m_edgeLeft;
	}

	public void SetEdgeLeftAttribute(double aEdgeLeft)
	{
		m_edgeLeft = aEdgeLeft;
	}

	public double GetEdgeBottomAttribute()
	{
		return m_edgeBottom;
	}

	public void SetEdgeBottomAttribute(double aEdgeBottom)
	{
		m_edgeBottom = aEdgeBottom;
	}

	public double GetEdgeRightAttribute()
	{
		return m_edgeRight;
	}

	public void SetEdgeRightAttribute(double aEdgeRight)
	{
		m_edgeRight = aEdgeRight;
	}

	public double GetMarginTopAttribute()
	{
		return m_marginTop;
	}

	public void SetMarginTopAttribute(double aMarginTop)
	{
		m_marginTop = aMarginTop;
	}

	public double GetMarginLeftAttribute()
	{
		return m_marginLeft;
	}

	public void SetMarginLeftAttribute(double aMarginLeft)
	{
		m_marginLeft = aMarginLeft;
	}

	public double GetMarginBottomAttribute()
	{
		return m_marginBottom;
	}

	public void SetMarginBottomAttribute(double aMarginBottom)
	{
		m_marginBottom = aMarginBottom;
	}

	public double GetMarginRightAttribute()
	{
		return m_marginRight;
	}

	public void SetMarginRightAttribute(double aMarginRight)
	{
		m_marginRight = aMarginRight;
	}

	public double GetUnwriteableMarginTopAttribute()
	{
		return m_unwriteableMarginTop;
	}

	public void SetUnwriteableMarginTopAttribute(double aUnwriteableMarginTop)
	{
		m_unwriteableMarginTop = aUnwriteableMarginTop;
	}

	public double GetUnwriteableMarginLeftAttribute()
	{
		return m_unwriteableMarginLeft;
	}

	public void SetUnwriteableMarginLeftAttribute(double aUnwriteableMarginLeft)
	{
		m_unwriteableMarginLeft = aUnwriteableMarginLeft;
	}

	public double GetUnwriteableMarginBottomAttribute()
	{
		return m_unwriteableMarginBottom;
	}

	public void SetUnwriteableMarginBottomAttribute(double aUnwriteableMarginBottom)
	{
		m_unwriteableMarginBottom = aUnwriteableMarginBottom;
	}

	public double GetUnwriteableMarginRightAttribute()
	{
		return m_unwriteableMarginRight;
	}

	public void SetUnwriteableMarginRightAttribute(double aUnwriteableMarginRight)
	{
		m_unwriteableMarginRight = aUnwriteableMarginRight;
	}

	public double GetScalingAttribute()
	{
		return m_scaling;
	}

	public void SetScalingAttribute(double aScaling)
	{
		m_scaling = aScaling;
	}

	public bool GetPrintBGColorsAttribute()
	{
		return m_printBGColors;
	}

	public void SetPrintBGColorsAttribute(bool aPrintBGColors)
	{
		m_printBGColors = aPrintBGColors;
	}

	public bool GetPrintBGImagesAttribute()
	{
		return m_printBGImages;
	}

	public void SetPrintBGImagesAttribute(bool aPrintBGImages)
	{
		m_printBGImages = aPrintBGImages;
	}

	public short GetPrintRangeAttribute()
	{
		return m_printRange;
	}

	public void SetPrintRangeAttribute(short aPrintRange)
	{
		m_printRange = aPrintRange;
	}

	public string GetTitleAttribute()
	{
		return m_title;
	}

	public void SetTitleAttribute(string aTitle)
	{
		m_title = aTitle;
	}

	public string GetDocURLAttribute()
	{
		return m_docURL;
	}

	public void SetDocURLAttribute(string aDocURL)
	{
		m_docURL = aDocURL;
	}

	public string GetHeaderStrLeftAttribute()
	{
		return m_headerStrLeft;
	}

	public void SetHeaderStrLeftAttribute(string aHeaderStrLeft)
	{
		m_headerStrLeft = aHeaderStrLeft;
	}

	public string GetHeaderStrCenterAttribute()
	{
		return m_headerStrCenter;
	}

	public void SetHeaderStrCenterAttribute(string aHeaderStrCenter)
	{
		m_headerStrCenter = aHeaderStrCenter;
	}

	public string GetHeaderStrRightAttribute()
	{
		return m_headerStrRight;
	}

	public void SetHeaderStrRightAttribute(string aHeaderStrRight)
	{
		m_headerStrRight = aHeaderStrRight;
	}

	public string GetFooterStrLeftAttribute()
	{
		return m_footerStrLeft;
	}

	public void SetFooterStrLeftAttribute(string aFooterStrLeft)
	{
		m_footerStrLeft = aFooterStrLeft;
	}

	public string GetFooterStrCenterAttribute()
	{
		return m_footerStrCenter;
	}

	public void SetFooterStrCenterAttribute(string aFooterStrCenter)
	{
		m_footerStrCenter = aFooterStrCenter;
	}

	public string GetFooterStrRightAttribute()
	{
		return m_footerStrRight;
	}

	public void SetFooterStrRightAttribute(string aFooterStrRight)
	{
		m_footerStrRight = aFooterStrRight;
	}

	public short GetHowToEnableFrameUIAttribute()
	{
		return m_howToEnableFrameUI;
	}

	public void SetHowToEnableFrameUIAttribute(short aHowToEnableFrameUI)
	{
		m_howToEnableFrameUI = aHowToEnableFrameUI;
	}

	public bool GetIsCancelledAttribute()
	{
		return m_IsCancelled;
	}

	public void SetIsCancelledAttribute(bool aIsCancelled)
	{
		m_IsCancelled = aIsCancelled;
	}

	public short GetPrintFrameTypeUsageAttribute()
	{
		return m_printFrameTypeUsage;
	}

	public void SetPrintFrameTypeUsageAttribute(short aPrintFrameTypeUsage)
	{
		m_printFrameTypeUsage = aPrintFrameTypeUsage;
	}

	public short GetPrintFrameTypeAttribute()
	{
		return m_printFrameType;
	}

	public void SetPrintFrameTypeAttribute(short aPrintFrameType)
	{
		m_printFrameType = aPrintFrameType;
	}

	public bool GetPrintSilentAttribute()
	{
		return m_printSilent;
	}

	public void SetPrintSilentAttribute(bool aPrintSilent)
	{
		m_printSilent = aPrintSilent;
	}

	public bool GetShrinkToFitAttribute()
	{
		return m_shrinkToFit;
	}

	public void SetShrinkToFitAttribute(bool aShrinkToFit)
	{
		m_shrinkToFit = aShrinkToFit;
	}

	public bool GetShowPrintProgressAttribute()
	{
		return m_showPrintProgress;
	}

	public void SetShowPrintProgressAttribute(bool aShowPrintProgress)
	{
		m_showPrintProgress = aShowPrintProgress;
	}

	public string GetPaperNameAttribute()
	{
		return m_paperName;
	}

	public void SetPaperNameAttribute(string aPaperName)
	{
		m_paperName = aPaperName;
	}

	public short GetPaperSizeTypeAttribute()
	{
		return m_paperSizeType;
	}

	public void SetPaperSizeTypeAttribute(short aPaperSizeType)
	{
		m_paperSizeType = aPaperSizeType;
	}

	public short GetPaperDataAttribute()
	{
		return m_paperData;
	}

	public void SetPaperDataAttribute(short aPaperData)
	{
		m_paperData = aPaperData;
	}

	public double GetPaperWidthAttribute()
	{
		return m_paperWidth;
	}

	public void SetPaperWidthAttribute(double aPaperWidth)
	{
		m_paperWidth = aPaperWidth;
	}

	public double GetPaperHeightAttribute()
	{
		return m_paperHeight;
	}

	public void SetPaperHeightAttribute(double aPaperHeight)
	{
		m_paperHeight = aPaperHeight;
	}

	public short GetPaperSizeUnitAttribute()
	{
		return m_paperSizeUnit;
	}

	public void SetPaperSizeUnitAttribute(short aPaperSizeUnit)
	{
		m_paperSizeUnit = aPaperSizeUnit;
	}

	public string GetPlexNameAttribute()
	{
		return m_plexName;
	}

	public void SetPlexNameAttribute(string aPlexName)
	{
		m_plexName = aPlexName;
	}

	public string GetColorspaceAttribute()
	{
		return m_colorspace;
	}

	public void SetColorspaceAttribute(string aColorspace)
	{
		m_colorspace = aColorspace;
	}

	public string GetResolutionNameAttribute()
	{
		return m_resolutionName;
	}

	public void SetResolutionNameAttribute(string aResolutionName)
	{
		m_resolutionName = aResolutionName;
	}

	public bool GetDownloadFontsAttribute()
	{
		return m_downloadFonts;
	}

	public void SetDownloadFontsAttribute(bool aDownloadFonts)
	{
		m_downloadFonts = aDownloadFonts;
	}

	public bool GetPrintReversedAttribute()
	{
		return m_printReversed;
	}

	public void SetPrintReversedAttribute(bool aPrintReversed)
	{
		m_printReversed = aPrintReversed;
	}

	public bool GetPrintInColorAttribute()
	{
		return m_printInColor;
	}

	public void SetPrintInColorAttribute(bool aPrintInColor)
	{
		m_printInColor = aPrintInColor;
	}

	public int GetOrientationAttribute()
	{
		return m_orientation;
	}

	public void SetOrientationAttribute(int aOrientation)
	{
		m_orientation = aOrientation;
	}

	public string GetPrintCommandAttribute()
	{
		return m_printCommand;
	}

	public void SetPrintCommandAttribute(string aPrintCommand)
	{
		m_printCommand = aPrintCommand;
	}

	public int GetNumCopiesAttribute()
	{
		return m_numCopies;
	}

	public void SetNumCopiesAttribute(int aNumCopies)
	{
		m_numCopies = aNumCopies;
	}

	public string GetPrinterNameAttribute()
	{
		return m_printerName;
	}

	public void SetPrinterNameAttribute(string aPrinterName)
	{
		m_printerName = aPrinterName;
	}

	public bool GetPrintToFileAttribute()
	{
		return m_printToFile;
	}

	public void SetPrintToFileAttribute(bool aPrintToFile)
	{
		m_printToFile = aPrintToFile;
	}

	public string GetToFileNameAttribute()
	{
		return m_toFileName;
	}

	public void SetToFileNameAttribute(string aToFileName)
	{
		m_toFileName = aToFileName;
	}

	public short GetOutputFormatAttribute()
	{
		return m_outputFormat;
	}

	public void SetOutputFormatAttribute(short aOutputFormat)
	{
		m_outputFormat = aOutputFormat;
	}

	public int GetPrintPageDelayAttribute()
	{
		return m_printPageDelay;
	}

	public void SetPrintPageDelayAttribute(int aPrintPageDelay)
	{
		m_printPageDelay = aPrintPageDelay;
	}

	public int GetResolutionAttribute()
	{
		throw new NotImplementedException();
	}

	public void SetResolutionAttribute(int aResolution)
	{
		throw new NotImplementedException();
	}

	public int GetDuplexAttribute()
	{
		throw new NotImplementedException();
	}

	public void SetDuplexAttribute(int aDuplex)
	{
		throw new NotImplementedException();
	}

	public bool GetIsInitializedFromPrinterAttribute()
	{
		return m_isInitializedFromPrinter;
	}

	public void SetIsInitializedFromPrinterAttribute(bool aIsInitializedFromPrinter)
	{
		m_isInitializedFromPrinter = aIsInitializedFromPrinter;
	}

	public bool GetIsInitializedFromPrefsAttribute()
	{
		return m_isInitializedFromPrefs;
	}

	public void SetIsInitializedFromPrefsAttribute(bool aIsInitializedFromPrefs)
	{
		m_isInitializedFromPrefs = aIsInitializedFromPrefs;
	}

	public void SetMarginInTwips(IntPtr aMargin)
	{
	}

	public void SetEdgeInTwips(IntPtr aEdge)
	{
	}

	public void GetMarginInTwips(IntPtr aMargin)
	{
	}

	public void GetEdgeInTwips(IntPtr aEdge)
	{
	}

	public void SetupSilentPrinting()
	{
	}

	public void SetUnwriteableMarginInTwips(IntPtr aEdge)
	{
		throw new NotImplementedException();
	}

	public void GetUnwriteableMarginInTwips(IntPtr aEdge)
	{
		throw new NotImplementedException();
	}

	public void GetPageRanges(IntPtr aPages)
	{
	}

	public bool GetPersistMarginBoxSettingsAttribute()
	{
		throw new NotImplementedException();
	}

	public void SetPersistMarginBoxSettingsAttribute(bool aPersistMarginBoxSettings)
	{
		throw new NotImplementedException();
	}
}
