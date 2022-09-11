using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Wave;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.MediaFoundation;

public static class MediaFoundationInterop
{
	public const int MF_SOURCE_READER_ALL_STREAMS = -2;

	public const int MF_SOURCE_READER_FIRST_AUDIO_STREAM = -3;

	public const int MF_SOURCE_READER_FIRST_VIDEO_STREAM = -4;

	public const int MF_SOURCE_READER_MEDIASOURCE = -1;

	public const int MF_SDK_VERSION = 2;

	public const int MF_API_VERSION = 112;

	public const int MF_VERSION = 131184;

	[NonSerialized]
	internal static GetString _009B;

	[DllImport("mfplat.dll", ExactSpelling = true, PreserveSig = false)]
	public static extern void MFStartup(int version, int dwFlags = 0);

	[DllImport("mfplat.dll", ExactSpelling = true, PreserveSig = false)]
	public static extern void MFShutdown();

	[DllImport("mfplat.dll", ExactSpelling = true, PreserveSig = false)]
	internal static extern void MFCreateMediaType(out IMFMediaType ppMFType);

	[DllImport("mfplat.dll", ExactSpelling = true, PreserveSig = false)]
	internal static extern void MFInitMediaTypeFromWaveFormatEx([In] IMFMediaType pMFType, [In] WaveFormat pWaveFormat, [In] int cbBufSize);

	[DllImport("mfplat.dll", ExactSpelling = true, PreserveSig = false)]
	internal static extern void MFCreateWaveFormatExFromMFMediaType(IMFMediaType pMFType, ref IntPtr ppWF, ref int pcbSize, int flags = 0);

	[DllImport("mfreadwrite.dll", ExactSpelling = true, PreserveSig = false)]
	public static extern void MFCreateSourceReaderFromURL([In][MarshalAs(UnmanagedType.LPWStr)] string pwszURL, [In] IMFAttributes pAttributes, [MarshalAs(UnmanagedType.Interface)] out IMFSourceReader ppSourceReader);

	[DllImport("mfreadwrite.dll", ExactSpelling = true, PreserveSig = false)]
	public static extern void MFCreateSourceReaderFromByteStream([In] IMFByteStream pByteStream, [In] IMFAttributes pAttributes, [MarshalAs(UnmanagedType.Interface)] out IMFSourceReader ppSourceReader);

	[DllImport("mfreadwrite.dll", ExactSpelling = true, PreserveSig = false)]
	public static extern void MFCreateSinkWriterFromURL([In][MarshalAs(UnmanagedType.LPWStr)] string pwszOutputURL, [In] IMFByteStream pByteStream, [In] IMFAttributes pAttributes, out IMFSinkWriter ppSinkWriter);

	[DllImport("mfplat.dll", ExactSpelling = true, PreserveSig = false)]
	public static extern void MFCreateMFByteStreamOnStreamEx([MarshalAs(UnmanagedType.IUnknown)] object punkStream, out IMFByteStream ppByteStream);

	[DllImport("mfplat.dll", ExactSpelling = true, PreserveSig = false)]
	public static extern void MFTEnumEx([In] Guid guidCategory, [In] _MFT_ENUM_FLAG flags, [In] MFT_REGISTER_TYPE_INFO pInputType, [In] MFT_REGISTER_TYPE_INFO pOutputType, out IntPtr pppMFTActivate, out int pcMFTActivate);

	[DllImport("mfplat.dll", ExactSpelling = true, PreserveSig = false)]
	internal static extern void MFCreateSample(out IMFSample ppIMFSample);

	[DllImport("mfplat.dll", ExactSpelling = true, PreserveSig = false)]
	internal static extern void MFCreateMemoryBuffer(int cbMaxLength, out IMFMediaBuffer ppBuffer);

	[DllImport("mfplat.dll", ExactSpelling = true, PreserveSig = false)]
	internal static extern void MFCreateAttributes([MarshalAs(UnmanagedType.Interface)] out IMFAttributes ppMFAttributes, [In] int cInitialSize);

	[DllImport("mf.dll", ExactSpelling = true, PreserveSig = false)]
	public static extern void MFTranscodeGetAudioOutputAvailableTypes([In][MarshalAs(UnmanagedType.LPStruct)] Guid guidSubType, [In] _MFT_ENUM_FLAG dwMFTFlags, [In] IMFAttributes pCodecConfig, [MarshalAs(UnmanagedType.Interface)] out IMFCollection ppAvailableTypes);

	static MediaFoundationInterop()
	{
		Strings.CreateGetStringDelegate(typeof(MediaFoundationInterop));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009B(107399790), _009B(107399753)), _009B(107399748), _009B(107399743)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009B(107399770)))
		{
			return;
		}
		throw new SecurityException(_009B(107399713));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
