using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

internal sealed class Mono16SampleChunkConverter : ISampleChunkConverter
{
	private int sourceSample;

	private byte[] sourceBuffer;

	private WaveBuffer sourceWaveBuffer;

	private int sourceSamples;

	[NonSerialized]
	internal static GetString _0091;

	public bool Supports(WaveFormat waveFormat)
	{
		if (waveFormat.Encoding == WaveFormatEncoding.Pcm && waveFormat.BitsPerSample == 16)
		{
			return waveFormat.Channels == 1;
		}
		return false;
	}

	public void LoadNextChunk(IWaveProvider source, int samplePairsRequired)
	{
		int num = samplePairsRequired * 2;
		sourceSample = 0;
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, num);
		sourceWaveBuffer = new WaveBuffer(sourceBuffer);
		sourceSamples = source.Read(sourceBuffer, 0, num) / 2;
	}

	public bool GetNextSample(out float sampleLeft, out float sampleRight)
	{
		if (sourceSample < sourceSamples)
		{
			sampleLeft = (float)sourceWaveBuffer.ShortBuffer[sourceSample++] / 32768f;
			sampleRight = sampleLeft;
			return true;
		}
		sampleLeft = 0f;
		sampleRight = 0f;
		return false;
	}

	static Mono16SampleChunkConverter()
	{
		Strings.CreateGetStringDelegate(typeof(Mono16SampleChunkConverter));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0091(107398671), _0091(107398634)), _0091(107398629), _0091(107398624)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0091(107398651)))
		{
			return;
		}
		throw new SecurityException(_0091(107398594));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
