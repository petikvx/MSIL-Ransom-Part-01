namespace pal.EventLog;

internal class Globals
{
	public static int MetadataSize => 56;

	public static int HeaderSize => 48;

	public static int FooterSize => 40;

	public static int NullCharSize => UnicodeCharSize;

	public static int UnicodeCharSize => 2;
}
