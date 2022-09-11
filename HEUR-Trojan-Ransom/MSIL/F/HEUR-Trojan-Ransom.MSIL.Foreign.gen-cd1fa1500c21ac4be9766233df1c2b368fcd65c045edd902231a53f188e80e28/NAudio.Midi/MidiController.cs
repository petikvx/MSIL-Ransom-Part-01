namespace NAudio.Midi;

public enum MidiController : byte
{
	BankSelect = 0,
	Modulation = 1,
	BreathController = 2,
	FootController = 4,
	MainVolume = 7,
	Pan = 10,
	Expression = 11,
	BankSelectLsb = 32,
	Sustain = 64,
	Portamento = 65,
	Sostenuto = 66,
	SoftPedal = 67,
	LegatoFootswitch = 68,
	ResetAllControllers = 121,
	AllNotesOff = 123
}
