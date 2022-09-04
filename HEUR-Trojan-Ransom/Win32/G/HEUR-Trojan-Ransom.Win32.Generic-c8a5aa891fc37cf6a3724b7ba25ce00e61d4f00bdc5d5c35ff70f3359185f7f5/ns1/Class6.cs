using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal class Class6
{
	public static string smethod_0(string string_0, string string_1)
	{
		string @string = default(string);
		try
		{
			@string = Encoding.UTF8.GetString(smethod_1(Convert.FromBase64String(string_0), Encoding.UTF8.GetBytes(string_1)));
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static byte[] smethod_1(byte[] byte_0, byte[] byte_1)
	{
		checked
		{
			int num = byte_0[byte_0.Length - 1];
			byte[] array = new byte[byte_0.Length - 2 + 1];
			short num2 = 0;
			try
			{
				int num3 = byte_0.Length - 2;
				for (int i = 0; i <= num3; i++)
				{
					if (num2 >= byte_1.Length)
					{
						num2 = 0;
					}
					if (i < byte_0.Length - 1)
					{
						array[i] = Convert.ToByte(unchecked((int)byte_0[i]) - unchecked(array.Length % byte_1.Length) - unchecked((int)byte_1[num2]) + num);
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
