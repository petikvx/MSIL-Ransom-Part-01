using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace ns4;

internal sealed class EventArgs1 : EventArgs
{
	private SecurityException securityException_0;

	private string string_0 = string.Empty;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2 = true;

	[SpecialName]
	public SecurityException method_0()
	{
		return securityException_0;
	}

	[SpecialName]
	public string method_1()
	{
		return string_0;
	}

	[SpecialName]
	public bool method_2()
	{
		return bool_2;
	}

	[SpecialName]
	public bool method_3()
	{
		return bool_0;
	}

	[SpecialName]
	public void method_4(bool bool_3)
	{
		bool_0 = bool_3;
	}

	[SpecialName]
	public bool method_5()
	{
		return bool_1;
	}

	public EventArgs1(SecurityException securityException_1)
	{
		securityException_0 = securityException_1;
	}

	public EventArgs1(SecurityException securityException_1, bool bool_3)
		: this(securityException_1)
	{
		bool_2 = bool_3;
	}

	public EventArgs1(string string_1, bool bool_3)
		: this(new SecurityException(string_1), bool_3)
	{
		string_0 = string_1;
	}
}
