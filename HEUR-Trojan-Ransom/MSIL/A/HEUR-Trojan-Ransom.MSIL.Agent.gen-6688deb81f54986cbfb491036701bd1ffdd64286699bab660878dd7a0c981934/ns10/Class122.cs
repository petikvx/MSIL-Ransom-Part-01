using System;

namespace ns10;

internal class Class122
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 94450;
		string text = string.Empty;
		while (*(int*)ptr <= 67577)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 24288;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 15678;
		*(int*)((byte*)ptr + 8) = 87203;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 33363);
	}
}
