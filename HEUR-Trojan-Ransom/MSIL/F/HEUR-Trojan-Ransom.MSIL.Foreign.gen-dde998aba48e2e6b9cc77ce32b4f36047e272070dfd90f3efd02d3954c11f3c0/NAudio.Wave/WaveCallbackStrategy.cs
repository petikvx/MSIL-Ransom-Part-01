namespace NAudio.Wave;

public enum WaveCallbackStrategy
{
	FunctionCallback,
	NewWindow,
	ExistingWindow,
	Event
}
