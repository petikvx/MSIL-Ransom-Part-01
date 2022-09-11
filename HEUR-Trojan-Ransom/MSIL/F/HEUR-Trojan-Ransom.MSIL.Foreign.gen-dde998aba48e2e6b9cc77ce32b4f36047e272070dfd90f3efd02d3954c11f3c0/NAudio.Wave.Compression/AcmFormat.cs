using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.Compression;

public sealed class AcmFormat
{
	private readonly AcmFormatDetails formatDetails;

	private readonly WaveFormat waveFormat;

	[NonSerialized]
	internal static GetString _0017;

	public int FormatIndex => formatDetails.formatIndex;

	public WaveFormatEncoding FormatTag => (WaveFormatEncoding)formatDetails.formatTag;

	public AcmDriverDetailsSupportFlags SupportFlags => formatDetails.supportFlags;

	public WaveFormat WaveFormat => waveFormat;

	public int WaveFormatByteSize => formatDetails.waveFormatByteSize;

	public string FormatDescription => formatDetails.formatDescription;

	internal AcmFormat(AcmFormatDetails formatDetails)
	{
		this.formatDetails = formatDetails;
		waveFormat = WaveFormat.MarshalFromPtr(formatDetails.waveFormatPointer);
	}

	static AcmFormat()
	{
		Strings.CreateGetStringDelegate(typeof(AcmFormat));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0017(107398797), _0017(107398760)), _0017(107398755), _0017(107398750)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0017(107398777)))
		{
			return;
		}
		throw new SecurityException(_0017(107398720));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
