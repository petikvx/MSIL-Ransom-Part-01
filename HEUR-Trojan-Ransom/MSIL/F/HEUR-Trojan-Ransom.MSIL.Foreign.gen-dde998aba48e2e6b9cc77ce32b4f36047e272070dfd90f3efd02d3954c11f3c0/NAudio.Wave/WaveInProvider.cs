namespace NAudio.Wave;

public sealed class WaveInProvider : IWaveProvider
{
	private IWaveIn waveIn;

	private BufferedWaveProvider bufferedWaveProvider;

	public WaveFormat WaveFormat => waveIn.WaveFormat;

	public WaveInProvider(IWaveIn waveIn)
	{
		this.waveIn = waveIn;
		waveIn.DataAvailable += waveIn_DataAvailable;
		bufferedWaveProvider = new BufferedWaveProvider(WaveFormat);
	}

	private void waveIn_DataAvailable(object sender, WaveInEventArgs e)
	{
		bufferedWaveProvider.AddSamples(e.Buffer, 0, e.BytesRecorded);
	}

	public int Read(byte[] buffer, int offset, int count)
	{
		return bufferedWaveProvider.Read(buffer, 0, count);
	}
}
