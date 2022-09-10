using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class LOOTCKC
{
	public static string IPNPIWT(string Input, string BEKFY)
	{
		string @string = default(string);
		try
		{
			@string = Encoding.UTF8.GetString(VOSEH(Convert.FromBase64String(Input), Encoding.UTF8.GetBytes(BEKFY)));
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static byte[] VOSEH(byte[] Input, byte[] BEKFY)
	{
		checked
		{
			int num = Input[Input.Length - 1];
			byte[] array = new byte[Input.Length - 2 + 1];
			short num2 = 0;
			try
			{
				int num3 = Input.Length - 2;
				for (int i = 0; i <= num3; i++)
				{
					if (num2 >= BEKFY.Length)
					{
						num2 = 0;
					}
					if (i < Input.Length - 1)
					{
						array[i] = Convert.ToByte(unchecked((int)Input[i]) - unchecked(array.Length % BEKFY.Length) - unchecked((int)BEKFY[num2]) + num);
						num2 = (short)(num2 + 1);
					}
				}
				return array;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				byte[] result = array;
				ProjectData.ClearProjectError();
				return result;
			}
		}
	}
}
