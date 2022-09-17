public interface GInterface5
{
	string Source { get; }

	int FramesReceived { get; }

	long BytesReceived { get; }

	bool IsRunning { get; }

	event GDelegate7 Event_0;

	event GDelegate8 Event_1;

	event GDelegate9 Event_2;

	void Start();

	void SignalToStop();

	void WaitForStop();

	void Stop();
}