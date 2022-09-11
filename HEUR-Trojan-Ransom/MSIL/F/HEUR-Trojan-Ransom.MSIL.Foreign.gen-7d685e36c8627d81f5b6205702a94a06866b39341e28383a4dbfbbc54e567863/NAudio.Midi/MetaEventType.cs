namespace NAudio.Midi;

public enum MetaEventType : byte
{
	TrackSequenceNumber = 0,
	TextEvent = 1,
	Copyright = 2,
	SequenceTrackName = 3,
	TrackInstrumentName = 4,
	Lyric = 5,
	Marker = 6,
	CuePoint = 7,
	ProgramName = 8,
	DeviceName = 9,
	MidiChannel = 32,
	MidiPort = 33,
	EndTrack = 47,
	SetTempo = 81,
	SmpteOffset = 84,
	TimeSignature = 88,
	KeySignature = 89,
	SequencerSpecific = 127
}
