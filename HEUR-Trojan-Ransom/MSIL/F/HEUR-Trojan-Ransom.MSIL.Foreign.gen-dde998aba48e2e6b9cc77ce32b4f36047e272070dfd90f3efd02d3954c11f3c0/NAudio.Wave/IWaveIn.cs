using System;

namespace NAudio.Wave;

public interface IWaveIn : IDisposable
{
	WaveFormat WaveFormat { get; set; }

	event EventHandler<WaveInEventArgs> DataAvailable;

	event EventHandler<StoppedEventArgs> RecordingStopped;

	void StartRecording();

	void StopRecording();
}
