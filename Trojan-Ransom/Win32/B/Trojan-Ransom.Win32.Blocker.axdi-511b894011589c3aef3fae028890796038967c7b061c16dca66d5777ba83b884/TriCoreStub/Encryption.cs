using System;
using System.Diagnostics;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace TriCoreStub;

public class Encryption
{
	[DebuggerNonUserCode]
	public Encryption()
	{
	}

	public string Encrypt(string str, string password)
	{
		byte[] array = new byte[3];
		byte[] array3;
		checked
		{
			byte[] array2 = new byte[Strings.Len(str) + 1];
			int num = Strings.Len(password);
			int num2 = default(int);
			for (int i = 1; i <= num; i++)
			{
				num2 += Strings.Asc(Strings.Mid(password, i, 1));
			}
			array[0] = (byte)Math.Round((double)(num2 & 0xFF00) / 256.0);
			array[1] = (byte)(num2 & 0xFF);
			int num3 = 0;
			int num4 = Strings.Len(password);
			string text = default(string);
			for (int j = 1; j <= num4; j++)
			{
				if (num3 == 2)
				{
					num3 = 0;
				}
				text += Conversions.ToString(Strings.Chr(Strings.Asc(Strings.Mid(password, j, 1)) ^ array[num3]));
				num3++;
			}
			int num5 = Strings.Len(password);
			string text2 = default(string);
			for (int k = 1; k <= num5; k++)
			{
				text2 += Conversions.ToString(Strings.Chr(unchecked(Strings.Asc(Strings.Mid(text, k, 1)) % Strings.Asc(Strings.Mid(password, k, 1))) ^ array[1]));
			}
			num3 = 1;
			int num6 = Strings.Len(str);
			for (int l = 1; l <= num6; l++)
			{
				if (num3 == 9)
				{
					num3 = 1;
				}
				array2[l - 1] = (byte)(Strings.Asc(Strings.Mid(str, l, 1)) ^ Strings.Asc(Strings.Mid(text2, num3, 1)));
				num3++;
			}
			array3 = array2;
		}
		string text3 = default(string);
		foreach (byte b in array3)
		{
			text3 += Conversions.ToString(Strings.Chr((int)b));
		}
		return text3;
	}

	public object ToLen(string str)
	{
		string text = str;
		while (Strings.Len(text) != 2)
		{
			text = "0" + text;
		}
		return text;
	}
}
