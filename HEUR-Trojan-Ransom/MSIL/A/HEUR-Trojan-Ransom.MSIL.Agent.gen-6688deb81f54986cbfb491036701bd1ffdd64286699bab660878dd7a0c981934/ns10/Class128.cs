using System;

namespace ns10;

internal class Class128
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 91245;
		string text = string.Empty;
		while (*(int*)ptr <= 7553)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 59370;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 35785;
		*(int*)((byte*)ptr + 8) = 30682;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 82770);
	}
}
