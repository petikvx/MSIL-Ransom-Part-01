using System;

namespace ns5;

internal class Class126
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 92763;
		string text = string.Empty;
		while (*(int*)ptr <= 89396)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 95549;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 73754;
		*(int*)((byte*)ptr + 8) = 27313;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 65617);
	}
}
