using System;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal class Class13
{
	private string string_0;

	private string string_1;

	private int int_0;

	private char[] char_0;

	private char[] char_1;

	protected internal string KeyLetters
	{
		set
		{
			string_0 = value;
		}
	}

	protected internal string KeyNumbers
	{
		set
		{
			string_1 = value;
		}
	}

	protected internal int KeyChars
	{
		set
		{
			int_0 = value;
		}
	}

	public unsafe string method_0()
	{
		void* ptr = stackalloc byte[14];
		StringBuilder stringBuilder = new StringBuilder();
		char_0 = string_0.ToCharArray();
		char_1 = string_1.ToCharArray();
		*(int*)((byte*)ptr + 8) = int_0;
		*(int*)ptr = 1;
		while (*(int*)ptr <= *(int*)((byte*)ptr + 8))
		{
			VBMath.Randomize();
			*(float*)((byte*)ptr + 4) = VBMath.Rnd();
			*(short*)((byte*)ptr + 12) = -1;
			if (checked((int)Math.Round(*unchecked((float*)((byte*)ptr + 4)) * 111f)) % 2 == 0)
			{
				while (*(short*)((byte*)ptr + 12) < 0)
				{
					*(short*)((byte*)ptr + 12) = Convert.ToInt16((float)char_0.GetUpperBound(0) * *(float*)((byte*)ptr + 4));
				}
				string value = Conversions.ToString(char_0[*(short*)((byte*)ptr + 12)]);
				if (checked((int)Math.Round(unchecked((float)(*(short*)((byte*)ptr + 12)) * *(float*)((byte*)ptr + 4)) * 99f)) % 2 != 0)
				{
					value = char_0[*(short*)((byte*)ptr + 12)].ToString();
					value = value.ToUpper();
				}
				stringBuilder.Append(value);
			}
			else
			{
				while (*(short*)((byte*)ptr + 12) < 0)
				{
					*(short*)((byte*)ptr + 12) = Convert.ToInt16((float)char_1.GetUpperBound(0) * *(float*)((byte*)ptr + 4));
				}
				stringBuilder.Append(char_1[*(short*)((byte*)ptr + 12)]);
			}
			checked
			{
				(*unchecked((int*)ptr))++;
			}
		}
		return stringBuilder.ToString();
	}
}
