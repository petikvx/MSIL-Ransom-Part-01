using System;

namespace ns1;

internal class Class120
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 29187;
		string text = string.Empty;
		while (*(int*)ptr <= 41458)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 5020;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 78636;
		*(int*)((byte*)ptr + 8) = 20548;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 12863);
	}
}
