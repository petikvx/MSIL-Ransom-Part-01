using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.MediaFoundation;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

public sealed class StreamMediaFoundationReader : MediaFoundationReader
{
	private readonly Stream stream;

	[NonSerialized]
	internal static GetString _0083;

	public StreamMediaFoundationReader(Stream stream, MediaFoundationReaderSettings settings = null)
	{
		this.stream = stream;
		Init(settings);
	}

	protected override IMFSourceReader CreateReader(MediaFoundationReaderSettings settings)
	{
		IMFSourceReader iMFSourceReader = MediaFoundationApi.CreateSourceReaderFromByteStream(MediaFoundationApi.CreateByteStream(new ComStream(stream)));
		iMFSourceReader.SetStreamSelection(-2, pSelected: false);
		iMFSourceReader.SetStreamSelection(-3, pSelected: true);
		iMFSourceReader.SetCurrentMediaType(-3, IntPtr.Zero, new MediaType
		{
			MajorType = MediaTypes.MFMediaType_Audio,
			SubType = (settings.RequestFloatOutput ? AudioSubtypes.MFAudioFormat_Float : AudioSubtypes.MFAudioFormat_PCM)
		}.MediaFoundationObject);
		return iMFSourceReader;
	}

	static StreamMediaFoundationReader()
	{
		Strings.CreateGetStringDelegate(typeof(StreamMediaFoundationReader));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0083(107398493), _0083(107398456)), _0083(107398451), _0083(107398446)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0083(107398473)))
		{
			return;
		}
		throw new SecurityException(_0083(107398416));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
