using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class RUDUUFDP
{
	public static string CPMXFIPG(string Input, string GFEPPV)
	{
		string @string = default(string);
		try
		{
			@string = Encoding.UTF8.GetString(DFQMHV(Convert.FromBase64String(Input), Encoding.UTF8.GetBytes(GFEPPV)));
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static byte[] DFQMHV(byte[] Input, byte[] GFEPPV)
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
					if (num2 >= GFEPPV.Length)
					{
						num2 = 0;
					}
					if (i < Input.Length - 1)
					{
						array[i] = Convert.ToByte(unchecked((int)Input[i]) - unchecked(array.Length % GFEPPV.Length) - unchecked((int)GFEPPV[num2]) + num);
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
