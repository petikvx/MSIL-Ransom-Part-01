using System;

namespace Gecko.Interop;

internal static class MemCopy
{
	internal unsafe static void Copy(void* source, void* destination, int count)
	{
		int num = count / IntPtr.Size;
		int num2 = count % IntPtr.Size;
		for (int i = 0; i < num; i++)
		{
			*(IntPtr*)((byte*)destination + (nint)i * (nint)sizeof(IntPtr)) = *(IntPtr*)((byte*)source + (nint)i * (nint)sizeof(IntPtr));
		}
		byte* ptr = (byte*)source + num * IntPtr.Size;
		byte* ptr2 = (byte*)destination + num * IntPtr.Size;
		for (int j = 0; j < num2; j++)
		{
			ptr2[j] = ptr[j];
		}
	}
}
