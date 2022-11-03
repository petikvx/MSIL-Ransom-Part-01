namespace AForge.Video;

public interface IVideoSource
{
	string Source { get; }

	int FramesReceived { get; }

	long BytesReceived { get; }

	bool IsRunning { get; }

	event NewFrameEventHandler NewFrame;

	event VideoSourceErrorEventHandler VideoSourceError;

	event PlayingFinishedEventHandler PlayingFinished;

	void Start();

	void SignalToStop();

	void WaitForStop();

	void Stop();
}
