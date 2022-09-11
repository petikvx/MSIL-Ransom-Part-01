namespace NAudio.Wave;

public interface ISampleProvider
{
	WaveFormat WaveFormat { get; }

	int Read(float[] buffer, int offset, int count);
}
