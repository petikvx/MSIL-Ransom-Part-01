using System;

namespace NAudio.Mixer;

[Flags]
public enum MixerFlags
{
	Handle = int.MinValue,
	Mixer = 0,
	MixerHandle = int.MinValue,
	WaveOut = 0x10000000,
	WaveOutHandle = -1879048192,
	WaveIn = 0x20000000,
	WaveInHandle = -1610612736,
	MidiOut = 0x30000000,
	MidiOutHandle = -1342177280,
	MidiIn = 0x40000000,
	MidiInHandle = -1073741824,
	Aux = 0x50000000,
	Value = 0,
	ListText = 1,
	QueryMask = 0xF,
	All = 0,
	OneById = 1,
	OneByType = 2,
	GetLineInfoOfDestination = 0,
	GetLineInfoOfSource = 1,
	GetLineInfoOfLineId = 2,
	GetLineInfoOfComponentType = 3,
	GetLineInfoOfTargetType = 4,
	GetLineInfoOfQueryMask = 0xF
}
