using System;
using System.Runtime.InteropServices;

namespace NAudio.Midi;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
public struct MidiOutCapabilities
{
	[Flags]
	private enum MidiOutCapabilityFlags
	{
		Volume = 1,
		LeftRightVolume = 2,
		PatchCaching = 4,
		Stream = 8
	}

	private short manufacturerId;

	private short productId;

	private int driverVersion;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
	private string productName;

	private short wTechnology;

	private short wVoices;

	private short wNotes;

	private ushort wChannelMask;

	private MidiOutCapabilityFlags dwSupport;

	private const int MaxProductNameLength = 32;

	public Manufacturers Manufacturer => (Manufacturers)manufacturerId;

	public short ProductId => productId;

	public string ProductName => productName;

	public int Voices => wVoices;

	public int Notes => wNotes;

	public bool SupportsAllChannels => wChannelMask == ushort.MaxValue;

	public bool SupportsPatchCaching => (dwSupport & MidiOutCapabilityFlags.PatchCaching) != 0;

	public bool SupportsSeparateLeftAndRightVolume => (dwSupport & MidiOutCapabilityFlags.LeftRightVolume) != 0;

	public bool SupportsMidiStreamOut => (dwSupport & MidiOutCapabilityFlags.Stream) != 0;

	public bool SupportsVolumeControl => (dwSupport & MidiOutCapabilityFlags.Volume) != 0;

	public MidiOutTechnology Technology => (MidiOutTechnology)wTechnology;

	public bool SupportsChannel(int channel)
	{
		return (wChannelMask & (1 << channel - 1)) > 0;
	}
}
