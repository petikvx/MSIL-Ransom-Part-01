namespace Gecko;

public class nsIPrintSettingsConsts
{
	public const ulong kInitSaveOddEvenPages = 1uL;

	public const ulong kInitSaveHeaderLeft = 2uL;

	public const ulong kInitSaveHeaderCenter = 4uL;

	public const ulong kInitSaveHeaderRight = 8uL;

	public const ulong kInitSaveFooterLeft = 16uL;

	public const ulong kInitSaveFooterCenter = 32uL;

	public const ulong kInitSaveFooterRight = 64uL;

	public const ulong kInitSaveBGColors = 128uL;

	public const ulong kInitSaveBGImages = 256uL;

	public const ulong kInitSavePaperSize = 512uL;

	public const ulong kInitSaveResolution = 1024uL;

	public const ulong kInitSaveDuplex = 2048uL;

	public const ulong kInitSavePaperData = 8192uL;

	public const ulong kInitSaveUnwriteableMargins = 16384uL;

	public const ulong kInitSaveEdges = 32768uL;

	public const ulong kInitSaveReversed = 65536uL;

	public const ulong kInitSaveInColor = 131072uL;

	public const ulong kInitSaveOrientation = 262144uL;

	public const ulong kInitSavePrinterName = 1048576uL;

	public const ulong kInitSavePrintToFile = 2097152uL;

	public const ulong kInitSaveToFileName = 4194304uL;

	public const ulong kInitSavePageDelay = 8388608uL;

	public const ulong kInitSaveMargins = 16777216uL;

	public const ulong kInitSaveNativeData = 33554432uL;

	public const ulong kInitSaveShrinkToFit = 134217728uL;

	public const ulong kInitSaveScaling = 268435456uL;

	public const ulong kInitSaveAll = 4294967295uL;

	public const long kPrintOddPages = 1L;

	public const long kPrintEvenPages = 2L;

	public const long kEnableSelectionRB = 4L;

	public const long kRangeAllPages = 0L;

	public const long kRangeSpecifiedPageRange = 1L;

	public const long kRangeSelection = 2L;

	public const long kRangeFocusFrame = 3L;

	public const long kJustLeft = 0L;

	public const long kJustCenter = 1L;

	public const long kJustRight = 2L;

	public const short kUseInternalDefault = 0;

	public const short kUseSettingWhenPossible = 1;

	public const short kPaperSizeNativeData = 0;

	public const short kPaperSizeDefined = 1;

	public const short kPaperSizeInches = 0;

	public const short kPaperSizeMillimeters = 1;

	public const short kPortraitOrientation = 0;

	public const short kLandscapeOrientation = 1;

	public const short kNoFrames = 0;

	public const short kFramesAsIs = 1;

	public const short kSelectedFrame = 2;

	public const short kEachFrameSep = 3;

	public const short kFrameEnableNone = 0;

	public const short kFrameEnableAll = 1;

	public const short kFrameEnableAsIsAndEach = 2;

	public const short kOutputFormatNative = 0;

	public const short kOutputFormatPS = 1;

	public const short kOutputFormatPDF = 2;
}
