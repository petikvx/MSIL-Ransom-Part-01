using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace ns4;

internal sealed class Class17
{
	[CompilerGenerated]
	internal sealed class Class18
	{
		public string string_0;
	}

	public static void smethod_0(string string_0)
	{
		char c = string_0[0];
		bool flag = true;
		while (flag)
		{
			try
			{
				Thread.Sleep(27000);
				Class23.smethod_33();
			}
			catch
			{
			}
			try
			{
				if (!Class23.smethod_95(Class8.int_1) && c == 'C')
				{
					Class8.int_1 = Class23.smethod_44('K', Process.GetCurrentProcess().Id.ToString());
					flag = false;
				}
				if (!Class23.smethod_95(Class8.int_1) && c == 'K')
				{
					Class8.int_0 = Class23.smethod_44('C', Process.GetCurrentProcess().Id.ToString());
					Class23.smethod_92(Class8.int_0.ToString(), "K");
					flag = false;
				}
			}
			catch
			{
			}
		}
	}
}
