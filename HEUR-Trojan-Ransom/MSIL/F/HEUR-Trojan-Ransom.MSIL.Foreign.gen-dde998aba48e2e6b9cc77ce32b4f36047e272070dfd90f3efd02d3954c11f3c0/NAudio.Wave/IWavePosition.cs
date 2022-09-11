namespace NAudio.Wave;

public interface IWavePosition
{
	WaveFormat OutputWaveFormat { get; }

	long GetPosition();
}
