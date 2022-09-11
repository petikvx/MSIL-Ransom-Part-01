using System.IO;
using System.Runtime.InteropServices;

namespace NAudio.Wave;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public sealed class TrueSpeechWaveFormat : WaveFormat
{
	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	private short[] unknown;

	public TrueSpeechWaveFormat()
	{
		waveFormatTag = WaveFormatEncoding.DspGroupTrueSpeech;
		channels = 1;
		averageBytesPerSecond = 1067;
		bitsPerSample = 1;
		blockAlign = 32;
		sampleRate = 8000;
		extraSize = 32;
		unknown = new short[16];
		unknown[0] = 1;
		unknown[1] = 240;
	}

	public override void Serialize(BinaryWriter writer)
	{
		base.Serialize(writer);
		short[] array = unknown;
		foreach (short value in array)
		{
			writer.Write(value);
		}
	}
}
