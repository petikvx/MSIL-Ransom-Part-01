using System;

namespace ns7;

internal class Class119
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 23230;
		string text = string.Empty;
		while (*(int*)ptr <= 46574)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 69147;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 43940;
		*(int*)((byte*)ptr + 8) = 48907;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 55894);
	}
}
