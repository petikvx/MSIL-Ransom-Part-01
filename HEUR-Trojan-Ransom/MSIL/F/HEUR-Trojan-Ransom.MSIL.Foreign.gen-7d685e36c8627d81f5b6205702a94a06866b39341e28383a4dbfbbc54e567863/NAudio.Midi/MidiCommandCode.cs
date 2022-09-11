namespace NAudio.Midi;

public enum MidiCommandCode : byte
{
	NoteOff = 128,
	NoteOn = 144,
	KeyAfterTouch = 160,
	ControlChange = 176,
	PatchChange = 192,
	ChannelAfterTouch = 208,
	PitchWheelChange = 224,
	Sysex = 240,
	Eox = 247,
	TimingClock = 248,
	StartSequence = 250,
	ContinueSequence = 251,
	StopSequence = 252,
	AutoSensing = 254,
	MetaEvent = byte.MaxValue
}
