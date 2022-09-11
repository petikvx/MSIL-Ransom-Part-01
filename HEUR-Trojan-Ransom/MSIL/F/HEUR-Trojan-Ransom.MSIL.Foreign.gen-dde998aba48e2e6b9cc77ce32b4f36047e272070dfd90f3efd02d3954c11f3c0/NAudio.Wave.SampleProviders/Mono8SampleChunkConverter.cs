using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using NAudio.Utils;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave.SampleProviders;

internal sealed class Mono8SampleChunkConverter : ISampleChunkConverter
{
	private int offset;

	private byte[] sourceBuffer;

	private int sourceBytes;

	[NonSerialized]
	internal static GetString _0005;

	public bool Supports(WaveFormat waveFormat)
	{
		if (waveFormat.Encoding == WaveFormatEncoding.Pcm && waveFormat.BitsPerSample == 8)
		{
			return waveFormat.Channels == 1;
		}
		return false;
	}

	public void LoadNextChunk(IWaveProvider source, int samplePairsRequired)
	{
		sourceBuffer = BufferHelpers.Ensure(sourceBuffer, samplePairsRequired);
		sourceBytes = source.Read(sourceBuffer, 0, samplePairsRequired);
		offset = 0;
	}

	public bool GetNextSample(out float sampleLeft, out float sampleRight)
	{
		if (offset < sourceBytes)
		{
			sampleLeft = (float)(int)sourceBuffer[offset] / 256f;
			offset++;
			sampleRight = sampleLeft;
			return true;
		}
		sampleLeft = 0f;
		sampleRight = 0f;
		return false;
	}

	static Mono8SampleChunkConverter()
	{
		Strings.CreateGetStringDelegate(typeof(Mono8SampleChunkConverter));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _0005(107398678), _0005(107398641)), _0005(107398636), _0005(107398631)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _0005(107398658)))
		{
			return;
		}
		throw new SecurityException(_0005(107398601));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
