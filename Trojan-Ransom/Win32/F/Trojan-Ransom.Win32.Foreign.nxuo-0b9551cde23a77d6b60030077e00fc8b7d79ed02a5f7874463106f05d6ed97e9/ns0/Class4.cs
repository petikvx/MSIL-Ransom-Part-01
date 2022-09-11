using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace ns0;

internal class Class4
{
	public List<byte[]> list_0;

	public List<MemoryStream> list_1 = new List<MemoryStream>();

	public object[] object_0 = new object[2];

	public Class3 class3_0;

	private Class4()
	{
		class3_0 = new Class3();
		list_0 = new List<byte[]>();
		list_0.Add(null);
		list_0.Add(new byte[32]);
		list_0.Add(new byte[16]);
	}

	public static Class4 smethod_0()
	{
		return new Class4();
	}

	public void method_0(byte[] byte_0)
	{
		list_0[1] = byte_0;
	}

	public void method_1(byte[] byte_0)
	{
		list_0[2] = byte_0;
	}

	public bool method_2()
	{
		return list_0[0] != null;
	}

	public byte[] method_3()
	{
		return list_0[0];
	}

	public void method_4(Assembly assembly_0)
	{
		object_0[0] = assembly_0;
	}

	public Class5 method_5()
	{
		if (object_0[0] == null)
		{
			return null;
		}
		return new Class5((Assembly)object_0[0]);
	}

	public void method_6(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			goto IL_0003;
		}
		goto IL_002b;
		IL_002b:
		list_0[0] = class3_0.method_0(byte_0);
		int num = 1150591840;
		goto IL_0008;
		IL_0008:
		int num2 = num;
		switch ((uint)(-(-(num2 ^ 0xB3298DD))) % 4u)
		{
		case 0u:
			break;
		default:
			return;
		case 3u:
			goto IL_002b;
		case 1u:
			return;
		case 2u:
			return;
		}
		goto IL_0003;
		IL_0003:
		num = 204817095;
		goto IL_0008;
	}

	public byte[] method_7()
	{
		return list_0[1];
	}

	public byte[] method_8()
	{
		return list_0[2];
	}

	private bool method_9()
	{
		method_5().method_2();
		return true;
	}

	public void method_10()
	{
		method_9();
	}
}
