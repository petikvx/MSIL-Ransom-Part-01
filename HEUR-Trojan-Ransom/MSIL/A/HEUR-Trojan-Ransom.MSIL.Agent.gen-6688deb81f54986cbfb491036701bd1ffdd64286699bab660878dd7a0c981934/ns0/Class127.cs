using System;

namespace ns0;

internal class Class127
{
	public unsafe void method_0()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 60410;
		string text = string.Empty;
		while (*(int*)ptr <= 29639)
		{
			text = text + *(int*)ptr + " ";
			*(int*)ptr *= 52184;
		}
		Console.WriteLine(text);
		*(int*)((byte*)ptr + 4) = 45455;
		*(int*)((byte*)ptr + 8) = 36487;
		do
		{
			*(int*)((byte*)ptr + 4) *= *(int*)((byte*)ptr + 8);
			(*(int*)((byte*)ptr + 8))--;
		}
		while (*(int*)((byte*)ptr + 8) > 86633);
	}
}
