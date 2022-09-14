using System;

namespace NuGet.Common;

public class TtxQRa2Hng
{
	public static string NMmvgL2SHJ(TimeSpan O9T2VGtAIr)
	{
		double num = O9T2VGtAIr.TotalHours;
		string arg = "hr";
		if (O9T2VGtAIr.TotalSeconds < 1.0)
		{
			num = O9T2VGtAIr.TotalMilliseconds;
			arg = "ms";
		}
		else if (O9T2VGtAIr.TotalMinutes < 1.0)
		{
			num = O9T2VGtAIr.TotalSeconds;
			arg = "sec";
		}
		else if (O9T2VGtAIr.TotalHours < 1.0)
		{
			num = O9T2VGtAIr.TotalMinutes;
			arg = "min";
		}
		return $"{num:0.##} {arg}";
	}
}
