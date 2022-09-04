using System;
using System.Runtime.CompilerServices;
using System.Security;

internal class EventArgs2 : EventArgs
{
	private SecurityException securityException_0;

	private string string_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

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

	public EventArgs2(SecurityException securityException_1)
	{
		Class52.KPUgGmhz2nAeI();
		string_0 = string.Empty;
		bool_2 = true;
		base._002Ector();
		securityException_0 = securityException_1;
	}

	public EventArgs2(SecurityException securityException_1, bool bool_3)
	{
		Class52.KPUgGmhz2nAeI();
		this._002Ector(securityException_1);
		bool_2 = bool_3;
	}

	public EventArgs2(string string_1, bool bool_3)
	{
		Class52.KPUgGmhz2nAeI();
		this._002Ector(new SecurityException(string_1), bool_3);
		string_0 = string_1;
	}
}
