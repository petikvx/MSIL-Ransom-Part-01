namespace Org.BouncyCastle.Tls;

public abstract class AlertLevel
{
	public const short warning = 1;

	public const short fatal = 2;

	public static string GetName(short alertDescription)
	{
		return alertDescription switch
		{
			2 => "fatal", 
			1 => "warning", 
			_ => "UNKNOWN", 
		};
	}

	public static string GetText(short alertDescription)
	{
		return GetName(alertDescription) + "(" + alertDescription + ")";
	}
}
