using System.Collections.Generic;
using System.Reflection;

internal class Class6
{
	public Dictionary<int, int> dictionary_0 = new Dictionary<int, int>();

	public List<object> list_0 = new List<object>();

	public Assembly assembly_0;

	public Class5 class5_0;

	public void method_0(int int_0, int int_1)
	{
		dictionary_0[0] = int_0;
		dictionary_0[1] = int_1;
	}

	public void method_1()
	{
		class5_0 = new Class5(dictionary_0[0], dictionary_0[1]);
	}

	public bool method_2()
	{
		return (object)assembly_0 != null;
	}

	public Class7 method_3()
	{
		if ((object)assembly_0 == null)
		{
			return null;
		}
		return new Class7(assembly_0);
	}

	public bool method_4(byte[] byte_0)
	{
		//IL_0071: Incompatible stack heights: 0 vs 1
		//IL_0078: Incompatible stack heights: 0 vs 1
		if (byte_0 == null)
		{
			int num = 853129448;
			uint num2 = 519393500u;
			return false;
		}
		try
		{
			assembly_0 = Class8.smethod_2(class5_0.method_0(byte_0));
		}
		catch
		{
			bool result = default(bool);
			while (true)
			{
				_ = 826933361;
				while (true)
				{
					int num = (int)/*Error near IL_002f: Stack underflow*/;
					uint num2;
					switch ((num2 = (uint)(~(-((-((num ^ 0x469069BE) * -64197695) - 1514605118) ^ 0x623E6131)))) % 3u)
					{
					case 1u:
						result = false;
						_ = (num2 * 299641391) ^ 0x515B7408;
						continue;
					case 2u:
						break;
					default:
						return result;
					case 0u:
						return result;
					}
					break;
				}
			}
		}
		return true;
	}

	private bool method_5()
	{
		Class7 @class = method_3();
		while (true)
		{
			int num = -1758286871;
			while (true)
			{
				int num2 = num;
				uint num3;
				int num4;
				switch ((num3 = (uint)((-702082612 - ~(num2 * 2029261569 * -2042229033 + -2140645038 - -553261885)) * 1812512271)) % 4u)
				{
				case 1u:
				{
					int num5;
					if (@class != null)
					{
						num4 = 171334958;
						num5 = 171334958;
					}
					else
					{
						num4 = 535021121;
						num5 = 535021121;
					}
					goto IL_0022;
				}
				case 2u:
					break;
				default:
					return true;
				case 3u:
					@class.method_1();
					return false;
				}
				break;
				IL_0022:
				num = num4 ^ (int)(num3 * 1125454389);
			}
		}
	}

	public void method_6()
	{
		if (!method_2())
		{
			goto IL_0008;
		}
		goto IL_0031;
		IL_0031:
		method_5();
		int num = 729611068;
		goto IL_000d;
		IL_000d:
		int num2 = num;
		switch ((uint)(80378696 - -(-(-num2))) % 4u)
		{
		case 3u:
			break;
		default:
			return;
		case 2u:
			goto IL_0031;
		case 0u:
			return;
		case 1u:
			return;
		}
		goto IL_0008;
		IL_0008:
		num = 661751657;
		goto IL_000d;
	}
}
