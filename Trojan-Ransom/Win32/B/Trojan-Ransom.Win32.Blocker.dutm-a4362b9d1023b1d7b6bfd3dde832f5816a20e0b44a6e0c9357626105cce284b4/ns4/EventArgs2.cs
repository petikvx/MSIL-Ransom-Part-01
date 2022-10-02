using System;
using System.Security;

namespace ns4;

internal sealed class EventArgs2 : EventArgs
{
	internal SecurityException securityException_0;

	internal string string_0 = string.Empty;

	internal bool bool_0;

	internal bool bool_1;

	internal bool bool_2 = true;

	public EventArgs2(SecurityException securityException_1)
	{
		securityException_0 = securityException_1;
	}

	public EventArgs2(SecurityException securityException_1, bool bool_3)
		: this(securityException_1)
	{
		bool_2 = bool_3;
	}

	public EventArgs2(string string_1, bool bool_3)
		: this(new SecurityException(string_1), bool_3)
	{
		string_0 = string_1;
	}
}
