using System;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace _0023f;

internal class _0023Ob
{
	public static string _00235G(string P_0, string P_1)
	{
		try
		{
			string @string = Encoding.UTF8.GetString(_00236G(Convert.FromBase64String(P_0), Encoding.UTF8.GetBytes(P_1)));
			if (0 == 0)
			{
				return @string;
			}
			string result = default(string);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = null;
			if (0 == 0)
			{
				ProjectData.ClearProjectError();
				return result;
			}
			return result;
		}
	}

	public static byte[] _00236G(byte[] P_0, byte[] P_1)
	{
		try
		{
			byte num = P_0[^1];
			int num2 = default(int);
			if (0 == 0)
			{
				num2 = num;
			}
			int num3 = P_0.Length;
			byte[] array2 = default(byte[]);
			short num4;
			int num5;
			int num6;
			int num7;
			if (0 == 0)
			{
				byte[] array = new byte[num3 - 2 + 1];
				if (0 == 0)
				{
					array2 = array;
				}
				if (6u != 0)
				{
					num4 = 0;
				}
				num5 = 0;
				num6 = P_0.Length;
				num7 = 2;
				goto IL_0031;
			}
			goto IL_0078;
			IL_0084:
			int num8;
			int num9;
			int num10;
			if (num8 <= num9)
			{
				if (num4 >= P_1.Length)
				{
					if (3u != 0)
					{
						num4 = 0;
					}
				}
				num5 = num10;
				num6 = P_0.Length;
				num7 = 1;
				if (num7 == 0)
				{
					goto IL_0031;
				}
				if (num5 < num6 - num7)
				{
					array2[num10] = Convert.ToByte(P_0[num10] - array2.Length % P_1.Length - P_1[num4] + num2);
					num3 = (short)(num4 + 1);
					goto IL_0078;
				}
			}
			else
			{
				byte[] result = array2;
				if (0 == 0)
				{
					return result;
				}
			}
			goto IL_0079;
			IL_0082:
			num8 = num10;
			goto IL_0084;
			IL_0078:
			num4 = (short)num3;
			goto IL_0079;
			IL_0031:
			int num11 = num6 - num7;
			if (6u != 0)
			{
				num9 = num11;
			}
			if (true)
			{
				num10 = num5;
			}
			goto IL_0082;
			IL_0079:
			num8 = num10 + 1;
			if (0 == 0)
			{
				num10 = num8;
				goto IL_0082;
			}
			goto IL_0084;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			byte[] result = null;
			ProjectData.ClearProjectError();
			return result;
		}
	}
}
