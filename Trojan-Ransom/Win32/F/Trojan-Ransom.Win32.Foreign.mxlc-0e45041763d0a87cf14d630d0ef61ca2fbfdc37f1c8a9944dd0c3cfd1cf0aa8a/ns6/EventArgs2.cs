using System;
using System.Security;

namespace ns6;

internal class EventArgs2 : EventArgs
{
	private SecurityException securityException_0;

	private string string_0 = string.Empty;

	internal bool bool_0;

	internal bool bool_1;

	private bool bool_2 = true;

	public EventArgs2(SecurityException securityException_1)
	{
		securityException_0 = securityException_1;
	}
}
