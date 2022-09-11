namespace NAudio.SoundFont;

public sealed class SFVersion
{
	private short major;

	private short minor;

	public short Major
	{
		get
		{
			return major;
		}
		set
		{
			major = value;
		}
	}

	public short Minor
	{
		get
		{
			return minor;
		}
		set
		{
			minor = value;
		}
	}
}
