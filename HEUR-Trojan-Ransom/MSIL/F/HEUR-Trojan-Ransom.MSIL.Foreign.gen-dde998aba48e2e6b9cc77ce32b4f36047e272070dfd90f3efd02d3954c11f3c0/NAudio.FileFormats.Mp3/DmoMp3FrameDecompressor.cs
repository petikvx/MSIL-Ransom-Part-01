using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Dmo;
using NAudio.Wave;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.FileFormats.Mp3;

public sealed class DmoMp3FrameDecompressor : IDisposable, IMp3FrameDecompressor
{
	private WindowsMediaMp3Decoder mp3Decoder;

	private WaveFormat pcmFormat;

	private MediaBuffer inputMediaBuffer;

	private DmoOutputDataBuffer outputBuffer;

	private bool reposition;

	[NonSerialized]
	internal static GetString _0088;

	public WaveFormat OutputFormat => pcmFormat;

	public DmoMp3FrameDecompressor(WaveFormat sourceFormat)
	{
		mp3Decoder = new WindowsMediaMp3Decoder();
		if (!mp3Decoder.MediaObject.SupportsInputWaveFormat(0, sourceFormat))
		{
			throw new ArgumentException(_0088(107405416));
		}
		mp3Decoder.MediaObject.SetInputWaveFormat(0, sourceFormat);
		pcmFormat = new WaveFormat(sourceFormat.SampleRate, sourceFormat.Channels);
		if (!mp3Decoder.MediaObject.SupportsOutputWaveFormat(0, pcmFormat))
		{
			throw new ArgumentException(string.Format(_0088(107405351), pcmFormat));
		}
		mp3Decoder.MediaObject.SetOutputWaveFormat(0, pcmFormat);
		inputMediaBuffer = new MediaBuffer(sourceFormat.AverageBytesPerSecond);
		outputBuffer = new DmoOutputDataBuffer(pcmFormat.AverageBytesPerSecond);
	}

	public int DecompressFrame(Mp3Frame frame, byte[] dest, int destOffset)
	{
		inputMediaBuffer.LoadData(frame.RawData, frame.FrameLength);
		if (reposition)
		{
			mp3Decoder.MediaObject.Flush();
			reposition = false;
		}
		mp3Decoder.MediaObject.ProcessInput(0, inputMediaBuffer, DmoInputDataBufferFlags.None, 0L, 0L);
		outputBuffer.MediaBuffer.SetLength(0);
		outputBuffer.StatusFlags = DmoOutputDataBufferFlags.None;
		mp3Decoder.MediaObject.ProcessOutput(DmoProcessOutputFlags.None, 1, new DmoOutputDataBuffer[1] { outputBuffer });
		if (outputBuffer.Length == 0)
		{
			return 0;
		}
		outputBuffer.RetrieveData(dest, destOffset);
		return outputBuffer.Length;
	}

	public void Reset()
	{
		reposition = true;
	}

	public void Dispose()
	{
		if (inputMediaBuffer != null)
		{
			inputMediaBuffer.Dispose();
			inputMediaBuffer = null;
		}
		outputBuffer.Dispose();
		if (mp3Decoder != null)
		{
			mp3Decoder.Dispose();
			mp3Decoder = null;
		}
	}

	static DmoMp3FrameDecompressor()
	{
		Strings.CreateGetStringDelegate(typeof(DmoMp3FrameDecompressor));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0088(107399913), _0088(107399876)), _0088(107399871), _0088(107399866)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0088(107399893)))
		{
			return;
		}
		throw new SecurityException(_0088(107399836));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
