namespace Org.BouncyCastle.Tls;

public abstract class NameType
{
	public const short host_name = 0;

	public static string GetName(short nameType)
	{
		if (nameType == 0)
		{
			return "host_name";
		}
		return "UNKNOWN";
	}

	public static string GetText(short nameType)
	{
		return GetName(nameType) + "(" + nameType + ")";
	}

	public static bool IsRecognized(short nameType)
	{
		return nameType == 0;
	}

	public static bool IsValid(short nameType)
	{
		return TlsUtilities.IsValidUint8(nameType);
	}
}
