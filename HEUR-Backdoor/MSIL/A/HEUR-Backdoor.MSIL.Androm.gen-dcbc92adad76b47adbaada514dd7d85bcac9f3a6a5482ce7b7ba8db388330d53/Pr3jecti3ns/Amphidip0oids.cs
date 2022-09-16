using System;

namespace Pr3jecti3ns;

public class Amphidip0oids
{
	public static string Pers8st8ng(TimeSpan Tube0oses)
	{
		double num = Tube0oses.TotalHours;
		string arg = "hr";
		if (Tube0oses.TotalSeconds < 1.0)
		{
			num = Tube0oses.TotalMilliseconds;
			arg = "ms";
		}
		else if (Tube0oses.TotalMinutes < 1.0)
		{
			num = Tube0oses.TotalSeconds;
			arg = "sec";
		}
		else if (Tube0oses.TotalHours < 1.0)
		{
			num = Tube0oses.TotalMinutes;
			arg = "min";
		}
		return $"{num:0.##} {arg}";
	}
}
