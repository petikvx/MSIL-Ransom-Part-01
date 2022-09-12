using System;

namespace ns4;

internal class Class121
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 21047;
		string text = string.Empty;
		while (*(int*)ptr <= 97944)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 27517;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 4702;
		*(int*)((byte*)ptr + 8) = 54437;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 42320);
	}
}
