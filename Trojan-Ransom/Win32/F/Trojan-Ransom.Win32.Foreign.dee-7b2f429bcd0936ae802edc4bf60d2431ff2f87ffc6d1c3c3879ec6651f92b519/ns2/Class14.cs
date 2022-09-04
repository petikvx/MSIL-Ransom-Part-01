using System;
using System.IO;
using Microsoft.VisualBasic.CompilerServices;
using ns0;

namespace ns2;

internal class Class14
{
	public static string[] string_0;

	private static string string_1 = "MasterPassword12345!";

	public static void smethod_0(string string_2)
	{
		if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\settings.crypt"))
		{
			try
			{
				string_0 = File.ReadAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\settings.crypt").Split(new char[1] { '\\' });
				Class1.smethod_2().method_0().string_0 = Class8.smethod_7(string_0[0], string_1);
				Class1.smethod_2().method_0().bool_0 = Conversions.ToBoolean(string_0[1]);
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				smethod_1(string_2, bool_0: false);
				ProjectData.ClearProjectError();
				return;
			}
		}
		smethod_1(string_2, bool_0: false);
	}

	public static void smethod_1(string string_2, bool bool_0)
	{
		File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\settings.crypt", Class8.smethod_5(string_2, string_1) + "\\" + bool_0);
	}
}
