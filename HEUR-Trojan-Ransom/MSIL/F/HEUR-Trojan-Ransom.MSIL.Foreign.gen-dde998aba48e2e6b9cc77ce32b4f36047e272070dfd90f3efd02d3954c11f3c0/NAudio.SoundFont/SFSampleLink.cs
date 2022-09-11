namespace NAudio.SoundFont;

public enum SFSampleLink : ushort
{
	MonoSample = 1,
	RightSample = 2,
	LeftSample = 4,
	LinkedSample = 8,
	RomMonoSample = 32769,
	RomRightSample = 32770,
	RomLeftSample = 32772,
	RomLinkedSample = 32776
}
