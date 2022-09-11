using System;

namespace NAudio.Midi;

public sealed class MidiInMessageEventArgs : EventArgs
{
	public int RawMessage { get; private set; }

	public MidiEvent MidiEvent { get; private set; }

	public int Timestamp { get; private set; }

	public MidiInMessageEventArgs(int message, int timestamp)
	{
		RawMessage = message;
		Timestamp = timestamp;
		try
		{
			MidiEvent = MidiEvent.FromRawMessage(message);
		}
		catch (Exception)
		{
		}
	}
}
