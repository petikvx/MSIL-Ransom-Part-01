using System;
using System.Security;

namespace ns4;

internal class EventArgs2 : EventArgs
{
	internal object object_0;

	internal string string_0;

	internal bool bool_0;

	internal bool bool_1;

	internal bool bool_2;

	public EventArgs2(SecurityException securityException_0)
	{
		Class42.hMqjKD0znI7T7();
		string_0 = string.Empty;
		bool_2 = true;
		base._002Ector();
		object_0 = securityException_0;
	}

	public EventArgs2(SecurityException securityException_0, bool bool_3)
	{
		Class42.hMqjKD0znI7T7();
		this._002Ector(securityException_0);
		bool_2 = bool_3;
	}

	public EventArgs2(string string_1, bool bool_3)
	{
		Class42.hMqjKD0znI7T7();
		this._002Ector(new SecurityException(string_1), bool_3);
		string_0 = string_1;
	}
}
