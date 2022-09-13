using System.Collections.Generic;

namespace youknowcaliber.Chromium;

internal sealed class History
{
	public static extern List<Site> Get(string sHistory);

	public extern History();
}
