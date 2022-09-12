using System;
using rmwatdtha.My.Resources;

namespace rmwatdtha;

public class Class1
{
	public byte[] getWind()
	{
		string text = Environment.OSVersion.ToString();
		if (text.Contains("6.2") | text.Contains("6.3"))
		{
			return Resources.valthasrvin8;
		}
		return Resources.valthasrvin7;
	}
}
