using System.Collections.Generic;
using System.Threading;
using ns1;
using ns2;
using ns4;

namespace ns9;

internal sealed class Class33
{
	public static readonly int int_0 = 3600000;

	public static void smethod_0()
	{
		do
		{
			List<string> list_ = Class36.smethod_1();
			List<string> list = Class36.smethod_0(list_);
			try
			{
				foreach (string item in list)
				{
					Class2.smethod_13(item);
				}
			}
			catch
			{
			}
			Thread.Sleep(int_0);
		}
		while (Class1.bool_0);
	}
}
