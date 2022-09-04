using System;
using System.Diagnostics;

namespace ns1;

internal class Class5
{
	private const int int_0 = 0;

	private const int int_1 = 5;

	private bool bool_0;

	private int int_2 = 255 + Environment.OSVersion.Version.Minor;

	public bool method_0()
	{
		if (int_2 > Environment.OSVersion.Version.Major)
		{
			return true;
		}
		return false;
	}

	public void method_1(string string_0, bool bool_1, string string_1, string string_2)
	{
		string text = GClass0.smethod_0("/");
		text = ((!bool_1) ? GClass0.smethod_0("}") : GClass0.smethod_0("/"));
		Process process = new Process();
		if (!bool_0 && string_2 != null)
		{
			process.StartInfo.WorkingDirectory = string_2;
		}
		process.StartInfo.FileName = string_0 + text + string_1;
		if (method_0())
		{
			process.StartInfo.CreateNoWindow = true;
		}
		process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		if (method_2())
		{
			process.Start();
		}
	}

	public bool method_2()
	{
		if (DateTime.Now.Minute < 1000)
		{
			if (5 + DateTime.Now.Second > 1)
			{
				return true;
			}
			return false;
		}
		return false;
	}
}
