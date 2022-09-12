using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace chicken.src.Util;

[StandardModule]
public sealed class resChanger
{
	public struct DEVMODE
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmDeviceName;

		public short dmSpecVersion;

		public short dmDriverVersion;

		public short dmSize;

		public short dmDriverExtra;

		public int dmFields;

		public short dmOrientation;

		public short dmPaperSize;

		public short dmPaperLength;

		public short dmPaperWidth;

		public short dmScale;

		public short dmCopies;

		public short dmDefaultSource;

		public short dmPrintQuality;

		public short dmColor;

		public short dmDuplex;

		public short dmYResolution;

		public short dmTTOption;

		public short dmCollate;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
		public string dmFormName;

		public short dmUnusedPadding;

		public short dmBitsPerPel;

		public int dmPelsWidth;

		public int dmPelsHeight;

		public int dmDisplayFlags;

		public int dmDisplayFrequency;
	}

	private const int lbdVOQNKvimbjUyuOQuoUpvNbnlB = -1;

	private const int ufuUMQjqXgLNXXedaVhTLevFtHBK = 1;

	private const long PAhStTpCoQHqjBBpVRCTThJXhnsO = 2L;

	private const int CDRqfMQzxdhyFHlFGjRbdexKRxNr = 32;

	private const int oiatdHsoCOdFhHnjGCQBcGxrghiZ = 32;

	private const int FabCnLXoxsiKpREEEbjvccRskuzw = 0;

	private const int vadUGQnmCVxKCsetxFOByNsmPZZr = 1;

	private const int FMKPXWQvDyMdnKucUleNgJJmvIlQ = -1;

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int EnumDisplaySettingsA(int lpszDeviceName, int iModeNum, ref DEVMODE lpDevMode);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int ChangeDisplaySettingsA(ref DEVMODE DEVMODE, long flags);

	public static void changeRes(short bits)
	{
		DEVMODE lpDevMode = default(DEVMODE);
		lpDevMode.dmDeviceName = new string(new char[33]);
		lpDevMode.dmFormName = new string(new char[33]);
		lpDevMode.dmSize = checked((short)Marshal.SizeOf(typeof(DEVMODE)));
		if (EnumDisplaySettingsA(0, -1, ref lpDevMode) != 0)
		{
			lpDevMode.dmBitsPerPel = bits;
			ChangeDisplaySettingsA(ref lpDevMode, 2L);
			ChangeDisplaySettingsA(ref lpDevMode, 1L);
		}
	}
}
