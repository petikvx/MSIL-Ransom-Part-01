using System;
using System.Runtime.Remoting.Channels;
using System.Security;

namespace ns0;

internal sealed class Class2
{
	internal Class3[] class3_0;

	internal Class3[] Class3_0 => class3_0;

	internal int Int32_0
	{
		get
		{
			if (class3_0 == null)
			{
				return 0;
			}
			return class3_0.Length;
		}
	}

	internal int Int32_1
	{
		get
		{
			if (class3_0 == null)
			{
				return 0;
			}
			int num = 0;
			for (int i = 0; i < class3_0.Length; i++)
			{
				if (method_2(i))
				{
					num++;
				}
			}
			return num;
		}
	}

	internal Class2()
	{
		Class3[] array = (class3_0 = new Class3[0]);
	}

	internal Class2(Class3[] class3_1)
	{
		Class3[] array = (class3_0 = class3_1);
	}

	internal IChannel method_0(int int_0)
	{
		return class3_0[int_0].IChannel_0;
	}

	internal bool method_1(int int_0)
	{
		return class3_0[int_0].vmethod_0();
	}

	internal bool method_2(int int_0)
	{
		return class3_0[int_0].vmethod_1();
	}

	internal int method_3(IChannel ichannel_0)
	{
		int num = 0;
		while (true)
		{
			if (num < class3_0.Length)
			{
				if (ichannel_0 == method_0(num))
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}

	[SecurityCritical]
	internal int method_4(string string_0)
	{
		int num = 0;
		while (true)
		{
			if (num < class3_0.Length)
			{
				if (string.Compare(string_0, method_0(num).get_ChannelName(), StringComparison.OrdinalIgnoreCase) == 0)
				{
					break;
				}
				num++;
				continue;
			}
			return -1;
		}
		return num;
	}
}
