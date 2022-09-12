using System;

namespace ns0;

internal class Class124
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 94569;
		string text = string.Empty;
		while (*(int*)ptr <= 67468)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 26754;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 84578;
		*(int*)((byte*)ptr + 8) = 61626;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 46884);
	}
}
