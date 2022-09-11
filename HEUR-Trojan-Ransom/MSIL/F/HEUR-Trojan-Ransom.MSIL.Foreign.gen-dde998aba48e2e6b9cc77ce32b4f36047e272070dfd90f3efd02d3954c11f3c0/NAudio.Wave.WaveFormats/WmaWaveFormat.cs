using System.Runtime.InteropServices;

namespace NAudio.Wave.WaveFormats;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
internal sealed class WmaWaveFormat : WaveFormat
{
	private short wValidBitsPerSample;

	private int dwChannelMask;

	private int dwReserved1;

	private int dwReserved2;

	private short wEncodeOptions;

	private short wReserved3;

	public WmaWaveFormat(int sampleRate, int bitsPerSample, int channels)
		: base(sampleRate, bitsPerSample, channels)
	{
		wValidBitsPerSample = (short)bitsPerSample;
		switch (channels)
		{
		case 1:
			dwChannelMask = 1;
			break;
		case 2:
			dwChannelMask = 3;
			break;
		}
		waveFormatTag = WaveFormatEncoding.WindowsMediaAudio;
	}
}
