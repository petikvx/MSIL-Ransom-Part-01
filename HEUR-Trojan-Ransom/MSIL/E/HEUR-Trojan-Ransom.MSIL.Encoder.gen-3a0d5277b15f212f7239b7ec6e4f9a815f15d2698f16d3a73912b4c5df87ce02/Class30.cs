using System;
using System.Security.Principal;

internal class Class30
{
	public static string string_0;

	public static string string_1;

	public static string string_2;

	public static string string_3;

	public static string smethod_0()
	{
		_003CModule_003E.Class0.smethod_0();
		return WindowsIdentity.GetCurrent().User!.Value;
	}

	public static string smethod_1()
	{
		_003CModule_003E.Class0.smethod_0();
		return DateTime.Now.ToString("hh:mm tt MM/dd/yyyy");
	}

	public Class30()
	{
		_003CModule_003E.Class0.smethod_0();
		base._002Ector();
	}

	static Class30()
	{
		_003CModule_003E.Class0.smethod_0();
		string_0 = "117399";
		string_1 = "JfesjZV9Gh2iRdvhQhKQLVfFxyJcpJftdMF";
		string_2 = "98817927642272211586711231727377242611632514718892551";
		string_3 = "1.0";
	}
}
