using System;
using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns1;

internal class Class12
{
	private string string_0;

	private string string_1;

	private int int_0;

	private char[] char_0;

	private char[] char_1;

	[SpecialName]
	protected internal void method_0(string string_2)
	{
		string_0 = string_2;
	}

	[SpecialName]
	protected internal void method_1(string string_2)
	{
		string_1 = string_2;
	}

	[SpecialName]
	protected internal void method_2(int int_1)
	{
		int_0 = int_1;
	}

	public unsafe string method_3()
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
