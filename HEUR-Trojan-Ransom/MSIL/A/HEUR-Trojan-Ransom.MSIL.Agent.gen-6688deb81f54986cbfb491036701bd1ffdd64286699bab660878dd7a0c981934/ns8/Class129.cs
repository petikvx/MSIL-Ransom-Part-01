using System;

namespace ns8;

internal class Class129
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 56912;
		string text = string.Empty;
		while (*(int*)ptr <= 75468)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 19782;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 29047;
		*(int*)((byte*)ptr + 8) = 84066;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 53078);
	}
}
