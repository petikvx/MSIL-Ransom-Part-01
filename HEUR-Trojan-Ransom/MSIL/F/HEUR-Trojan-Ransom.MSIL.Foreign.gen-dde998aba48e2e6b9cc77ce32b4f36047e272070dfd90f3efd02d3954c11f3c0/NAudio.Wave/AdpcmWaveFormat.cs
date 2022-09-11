using System;
using System.IO;
using System.Runtime.InteropServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace NAudio.Wave;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public sealed class AdpcmWaveFormat : WaveFormat
{
	private short samplesPerBlock;

	private short numCoeff;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
	private short[] coefficients;

	[NonSerialized]
	internal static GetString _0012;

	public int SamplesPerBlock => samplesPerBlock;

	public int NumCoefficients => numCoeff;

	public short[] Coefficients => coefficients;

	private AdpcmWaveFormat()
		: this(8000, 1)
	{
	}

	public AdpcmWaveFormat(int sampleRate, int channels)
		: base(sampleRate, 0, channels)
	{
		waveFormatTag = WaveFormatEncoding.Adpcm;
		extraSize = 32;
		switch (base.sampleRate)
		{
		case 8000:
		case 11025:
			blockAlign = 256;
			break;
		case 22050:
			blockAlign = 512;
			break;
		default:
			blockAlign = 1024;
			break;
		}
		bitsPerSample = 4;
		samplesPerBlock = (short)((blockAlign - 7 * channels) * 8 / (bitsPerSample * channels) + 2);
		averageBytesPerSecond = base.SampleRate * blockAlign / samplesPerBlock;
		numCoeff = 7;
		coefficients = new short[14]
		{
			256, 0, 512, -256, 0, 0, 192, 64, 240, 0,
			460, -208, 392, -232
		};
	}

	public override void Serialize(BinaryWriter writer)
	{
		base.Serialize(writer);
		writer.Write(samplesPerBlock);
		writer.Write(numCoeff);
		short[] array = coefficients;
		foreach (short value in array)
		{
			writer.Write(value);
		}
	}

	public override string ToString()
	{
		return string.Format(_0012(107389728), base.SampleRate, channels, bitsPerSample, samplesPerBlock);
	}

	static AdpcmWaveFormat()
	{
		Strings.CreateGetStringDelegate(typeof(AdpcmWaveFormat));
	}
}
