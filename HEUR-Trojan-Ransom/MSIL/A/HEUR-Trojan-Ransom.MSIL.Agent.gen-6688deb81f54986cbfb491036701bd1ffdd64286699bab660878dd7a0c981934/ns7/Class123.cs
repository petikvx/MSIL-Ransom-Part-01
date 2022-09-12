using System;

namespace ns7;

internal class Class123
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 13259;
		string text = string.Empty;
		while (*(int*)ptr <= 66135)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 98981;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 53717;
		*(int*)((byte*)ptr + 8) = 21677;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 75972);
	}
}
