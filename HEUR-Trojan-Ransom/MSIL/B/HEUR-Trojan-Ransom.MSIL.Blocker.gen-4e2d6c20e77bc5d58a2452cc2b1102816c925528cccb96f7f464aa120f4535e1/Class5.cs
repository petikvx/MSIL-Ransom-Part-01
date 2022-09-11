using System.Collections.Generic;
using System.Reflection;
using System.Threading;

internal class Class5
{
	public Dictionary<int, int> dictionary_0 = new Dictionary<int, int>();

	public List<object> list_0 = new List<object>();

	public Assembly assembly_0;

	public Class4 class4_0;

	public void method_0(int int_0, int int_1)
	{
		dictionary_0[0] = int_0;
		dictionary_0[1] = int_1;
	}

	public void method_1()
	{
		class4_0 = new Class4(dictionary_0[0], dictionary_0[1]);
	}

	public bool method_2()
	{
		return (object)assembly_0 != null;
	}

	public Class6 method_3()
	{
		if ((object)assembly_0 == null)
		{
			return null;
		}
		return new Class6(assembly_0);
	}

	public bool method_4(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			return false;
		}
		try
		{
			assembly_0 = Class7.smethod_2(class4_0.method_0(byte_0));
		}
		catch
		{
			return false;
		}
		return true;
	}

	private bool method_5()
	{
		Class6 @class = method_3();
		while (true)
		{
			int num = 1545611468;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)(-(-((~num2 - 1232846246) * -346849219)))) % 5u)
				{
				case 3u:
				{
					int num4;
					int num5;
					if (@class != null)
					{
						num4 = 317884054;
						num5 = 317884054;
					}
					else
					{
						num4 = -1425889166;
						num5 = -1425889166;
					}
					num = num4 ^ (int)(num3 * 1719012140);
					continue;
				}
				case 2u:
					@class.method_1();
					num = (int)(num3 * 1720109158) ^ -572635715;
					continue;
				case 4u:
					break;
				default:
					return true;
				case 1u:
					return false;
				}
				break;
			}
		}
	}

	public void method_6()
	{
		if (method_2())
		{
			method_5();
		}
	}

	public void method_7()
	{
		Thread.Sleep(1);
	}
}
