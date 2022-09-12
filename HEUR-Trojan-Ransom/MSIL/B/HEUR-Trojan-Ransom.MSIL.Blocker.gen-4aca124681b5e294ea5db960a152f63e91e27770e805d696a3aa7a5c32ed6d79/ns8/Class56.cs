namespace ns8;

internal sealed class Class56
{
	internal unsafe static uint smethod_0(string string_0)
	{
		void* ptr = stackalloc byte[12];
		if (string_0 != null)
		{
			*(int*)ptr = -2128831035;
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < string_0.Length)
			{
				*(uint*)ptr = (string_0[*(int*)((byte*)ptr + 4)] ^ *(uint*)ptr) * 16777619;
				(*(int*)((byte*)ptr + 4))++;
			}
		}
		*(int*)((byte*)ptr + 8) = *(int*)ptr;
		return *(uint*)((byte*)ptr + 8);
	}
}
