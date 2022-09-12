using System.Collections.Generic;
using System.Threading;
using ns0;
using ns5;
using ns7;

namespace ns9;

internal sealed class Class44
{
	public static readonly int int_0 = 3600000;

	public static void smethod_0()
	{
		do
		{
			List<string> list_ = Class25.smethod_1();
			List<string> list = Class25.smethod_0(list_);
			try
			{
				foreach (string item in list)
				{
					Class18.smethod_13(item);
				}
			}
			catch
			{
			}
			Thread.Sleep(int_0);
		}
		while (Class34.bool_0);
	}
}
