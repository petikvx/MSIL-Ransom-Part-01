using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class HVWNKBHE
{
	public static string QYIGWEOP(string Input, string QLFMYTKM)
	{
		string @string = default(string);
		try
		{
			@string = Encoding.UTF8.GetString(ORBQWJDL(Convert.FromBase64String(Input), Encoding.UTF8.GetBytes(QLFMYTKM)));
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static byte[] ORBQWJDL(byte[] Input, byte[] QLFMYTKM)
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
					if (num2 >= QLFMYTKM.Length)
					{
						num2 = 0;
					}
					if (i < Input.Length - 1)
					{
						array[i] = Convert.ToByte(unchecked((int)Input[i]) - unchecked(array.Length % QLFMYTKM.Length) - unchecked((int)QLFMYTKM[num2]) + num);
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
