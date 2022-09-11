using System;
using System.IO;
using System.Runtime.InteropServices;
using NAudio.Dmo;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public sealed class WaveFormatExtensible : WaveFormat
{
	private short wValidBitsPerSample;

	private int dwChannelMask;

	private Guid subFormat;

	[NonSerialized]
	internal static GetString _0090;

	public Guid SubFormat => subFormat;

	private WaveFormatExtensible()
	{
	}

	public WaveFormatExtensible(int rate, int bits, int channels)
		: base(rate, bits, channels)
	{
		waveFormatTag = WaveFormatEncoding.Extensible;
		extraSize = 22;
		wValidBitsPerSample = (short)bits;
		for (int i = 0; i < channels; i++)
		{
			dwChannelMask |= 1 << i;
		}
		if (bits == 32)
		{
			subFormat = AudioMediaSubtypes.MEDIASUBTYPE_IEEE_FLOAT;
		}
		else
		{
			subFormat = AudioMediaSubtypes.MEDIASUBTYPE_PCM;
		}
	}

	public WaveFormat ToStandardWaveFormat()
	{
		if (subFormat == AudioMediaSubtypes.MEDIASUBTYPE_IEEE_FLOAT && bitsPerSample == 32)
		{
			return WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channels);
		}
		if (subFormat == AudioMediaSubtypes.MEDIASUBTYPE_PCM)
		{
			return new WaveFormat(sampleRate, bitsPerSample, channels);
		}
		return this;
	}

	public override void Serialize(BinaryWriter writer)
	{
		base.Serialize(writer);
		writer.Write(wValidBitsPerSample);
		writer.Write(dwChannelMask);
		byte[] array = subFormat.ToByteArray();
		writer.Write(array, 0, array.Length);
	}

	public override string ToString()
	{
		return string.Format(_0090(107389790), base.ToString(), wValidBitsPerSample, dwChannelMask, subFormat, extraSize);
	}

	static WaveFormatExtensible()
	{
		Strings.CreateGetStringDelegate(typeof(WaveFormatExtensible));
	}
}
