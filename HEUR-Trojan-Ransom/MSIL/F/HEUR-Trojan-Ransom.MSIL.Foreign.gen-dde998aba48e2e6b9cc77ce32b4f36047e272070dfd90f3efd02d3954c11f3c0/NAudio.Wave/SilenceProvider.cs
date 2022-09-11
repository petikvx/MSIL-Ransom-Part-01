namespace NAudio.Wave;

public sealed class SilenceProvider : IWaveProvider
{
	public WaveFormat WaveFormat { get; private set; }

	public SilenceProvider(WaveFormat wf)
	{
		WaveFormat = wf;
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		int num = offset + count;
		for (int i = offset; i < num; i++)
		{
			buffer[i] = 0;
		}
		return count;
	}
}
