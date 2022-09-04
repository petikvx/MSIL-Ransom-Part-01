using System;
using System.Runtime.CompilerServices;
using System.Security;

namespace ns0;

internal sealed class EventArgs2 : EventArgs
{
	private SecurityException securityException_0;

	private string string_0 = string.Empty;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2 = true;

	public EventArgs2(SecurityException CO_)
	{
		securityException_0 = CO_;
	}

	public EventArgs2(SecurityException CO_, bool CO_)
		: this(CO_)
	{
		bool_2 = CO_;
	}

	public EventArgs2(string CO_, bool CO_)
		: this(new SecurityException(CO_), CO_)
	{
		string_0 = CO_;
	}

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
	public void method_4(bool CO_)
	{
		bool_0 = CO_;
	}

	[SpecialName]
	public bool method_5()
	{
		return bool_1;
	}
}
