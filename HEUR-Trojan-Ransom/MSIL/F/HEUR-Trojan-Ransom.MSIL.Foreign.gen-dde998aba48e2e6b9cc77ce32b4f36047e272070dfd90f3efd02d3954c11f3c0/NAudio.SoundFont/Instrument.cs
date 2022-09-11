namespace NAudio.SoundFont;

public sealed class Instrument
{
	private string name;

	internal ushort startInstrumentZoneIndex;

	internal ushort endInstrumentZoneIndex;

	private Zone[] zones;

	public string Name
	{
		get
		{
			return name;
		}
		set
		{
			name = value;
		}
	}

	public Zone[] Zones
	{
		get
		{
			return zones;
		}
		set
		{
			zones = value;
		}
	}

	public override string ToString()
	{
		return name;
	}
}
