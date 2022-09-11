using System.Runtime.InteropServices;

namespace NAudio.Wave;

[StructLayout(LayoutKind.Sequential, Pack = 2)]
public sealed class Mp3WaveFormat : WaveFormat
{
	public Mp3WaveFormatId id;

	public Mp3WaveFormatFlags flags;

	public ushort blockSize;

	public ushort framesPerBlock;

	public ushort codecDelay;

	private const short Mp3WaveFormatExtraBytes = 12;

	public Mp3WaveFormat(int sampleRate, int channels, int blockSize, int bitRate)
	{
		waveFormatTag = WaveFormatEncoding.MpegLayer3;
		base.channels = (short)channels;
		averageBytesPerSecond = bitRate / 8;
		bitsPerSample = 0;
		blockAlign = 1;
		base.sampleRate = sampleRate;
		extraSize = 12;
		id = Mp3WaveFormatId.Mpeg;
		flags = Mp3WaveFormatFlags.PaddingIso;
		this.blockSize = (ushort)blockSize;
		framesPerBlock = 1;
		codecDelay = 0;
	}
}
