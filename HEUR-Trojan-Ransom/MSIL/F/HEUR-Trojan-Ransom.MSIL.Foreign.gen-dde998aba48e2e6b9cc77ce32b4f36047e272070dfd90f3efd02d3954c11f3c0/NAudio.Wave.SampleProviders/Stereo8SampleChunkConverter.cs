using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

internal sealed class Stereo8SampleChunkConverter : ISampleChunkConverter
{
	private int offset;

	private byte[] sourceBuffer;

	private int sourceBytes;

	[NonSerialized]
	internal static GetString _009F;

	public bool Supports(WaveFormat waveFormat)
	{
		if (waveFormat.Encoding == WaveFormatEncoding.Pcm && waveFormat.BitsPerSample == 8)
		{
			return waveFormat.Channels == 2;
		}
		return false;
	}

	public void LoadNextChunk(IWaveProvider source, int samplePairsRequired)
	{
		int num = samplePairsRequired * 2;
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, num);
		sourceBytes = source.Read(sourceBuffer, 0, num);
		offset = 0;
	}

	public bool GetNextSample(out float sampleLeft, out float sampleRight)
	{
		if (offset < sourceBytes)
		{
			sampleLeft = (float)(int)sourceBuffer[offset++] / 256f;
			sampleRight = (float)(int)sourceBuffer[offset++] / 256f;
			return true;
		}
		sampleLeft = 0f;
		sampleRight = 0f;
		return false;
	}

	static Stereo8SampleChunkConverter()
	{
		Strings.CreateGetStringDelegate(typeof(Stereo8SampleChunkConverter));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _009F(107398694), _009F(107398657)), _009F(107398652), _009F(107398647)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _009F(107398674)))
		{
			return;
		}
		throw new SecurityException(_009F(107398617));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
