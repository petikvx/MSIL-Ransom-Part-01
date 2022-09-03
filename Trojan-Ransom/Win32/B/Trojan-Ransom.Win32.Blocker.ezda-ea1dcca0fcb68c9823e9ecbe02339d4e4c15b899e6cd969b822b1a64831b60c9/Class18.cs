using System.Net;

internal class Class18
{
	public static IPAddress smethod_0(bool bool_0)
	{
		return Delegate263.smethod_0(Delegate116.smethod_0(Delegate70.smethod_22()), bool_0);
	}

	public static IPAddress smethod_1(IPHostEntry iphostEntry_0, bool bool_0)
	{
		if (iphostEntry_0 == null)
		{
			throw Delegate264.smethod_0((string)_003CModule_003E.smethod_0(3348184906u));
		}
		if (Delegate117.smethod_0(iphostEntry_0).Length != 1)
		{
			IPAddress[] array = Delegate117.smethod_0(iphostEntry_0);
			foreach (IPAddress iPAddress in array)
			{
				bool flag;
				if (!(flag = Delegate265.smethod_0(iPAddress)) || !bool_0)
				{
					if (!flag && !bool_0)
					{
						return iPAddress;
					}
					continue;
				}
				return iPAddress;
			}
		}
		return Delegate117.smethod_0(iphostEntry_0)[0];
	}

	public static bool smethod_2(IPAddress ipaddress_0)
	{
		if (ipaddress_0 == null)
		{
			throw Delegate264.smethod_0((string)_003CModule_003E.smethod_0(3150563332u));
		}
		byte[] array = Delegate259.smethod_0(ipaddress_0);
		if (array[0] != 10 && (array[0] != 192 || array[1] != 168))
		{
			if (array[0] == 172 && array[1] >= 16)
			{
				return array[1] <= 31;
			}
			return false;
		}
		return true;
	}
}
