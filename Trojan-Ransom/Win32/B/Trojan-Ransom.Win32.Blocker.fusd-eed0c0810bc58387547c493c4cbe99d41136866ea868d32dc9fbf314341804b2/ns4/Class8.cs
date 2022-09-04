using System;
using System.Runtime.InteropServices;

namespace ns4;

[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
internal class Class8
{
	public unsafe static string smethod_0(string string_0, int int_0)
	{
		void* ptr = stackalloc byte[12];
		string text = "";
		byte* num = (byte*)ptr + 4;
		*(int*)((byte*)ptr + 8) = checked(string_0.Length - 1);
		*(int*)num = 0;
		while (*(int*)((byte*)ptr + 4) <= *(int*)((byte*)ptr + 8))
		{
			*(int*)ptr = Convert.ToInt32(string_0[*(int*)((byte*)ptr + 4)]);
			*(int*)ptr ^= int_0;
			text += char.ConvertFromUtf32(*(int*)ptr);
			checked
			{
				(*unchecked((int*)((byte*)ptr + 4)))++;
			}
		}
		return text;
	}
}
