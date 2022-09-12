using System;

namespace ns8;

internal class Class118
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 34340;
		string text = string.Empty;
		while (*(int*)ptr <= 6622)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 87775;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 30938;
		*(int*)((byte*)ptr + 8) = 54211;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 15534);
	}
}
