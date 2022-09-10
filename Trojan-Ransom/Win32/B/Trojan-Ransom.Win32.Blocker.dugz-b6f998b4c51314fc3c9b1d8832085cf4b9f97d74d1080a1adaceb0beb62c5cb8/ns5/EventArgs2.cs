using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace ns5;

internal sealed class EventArgs2 : EventArgs
{
	private SecurityException securityException_0;

	private string string_0 = string.Empty;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2 = true;

	[SpecialName]
	public bool method_0()
	{
		return bool_0;
	}

	[SpecialName]
	public bool method_1()
	{
		return bool_1;
	}

	[SpecialName]
	public void method_2(bool bool_3)
	{
		bool_1 = bool_3;
	}

	public EventArgs2(SecurityException securityException_1)
	{
		securityException_0 = securityException_1;
	}
}
