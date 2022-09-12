using System;

namespace ns6;

internal class Class125
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 74840;
		string text = string.Empty;
		while (*(int*)ptr <= 99099)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 97914;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 4039;
		*(int*)((byte*)ptr + 8) = 55950;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 34277);
	}
}
