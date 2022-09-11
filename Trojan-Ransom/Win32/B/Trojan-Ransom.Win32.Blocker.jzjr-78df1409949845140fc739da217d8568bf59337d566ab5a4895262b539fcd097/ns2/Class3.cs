using System.Collections.Generic;
using System.IO;
using System.Reflection;
using ns1;
using ns3;

namespace ns2;

internal sealed class Class3
{
	public List<byte[]> list_0;

	public List<MemoryStream> list_1 = new List<MemoryStream>();

	public object[] object_0 = new object[2];

	public Class2 class2_0;

	public Class3()
	{
		class2_0 = new Class2();
		list_0 = new List<byte[]>();
		list_0.Add(null);
		list_0.Add(new byte[32]);
		list_0.Add(new byte[16]);
	}

	public void method_0(byte[] byte_0)
	{
		list_0[1] = byte_0;
	}

	public void method_1(byte[] byte_0)
	{
		list_0[2] = byte_0;
	}

	public unsafe bool method_2()
	{
		void* ptr = stackalloc byte[5];
		((byte*)ptr)[4] = ((list_0[0] != null) ? ((byte)1) : ((byte)0));
		return ((byte*)ptr)[4] != 0;
	}

	public byte[] method_3()
	{
		return list_0[0];
	}

	public void method_4(Assembly assembly_0)
	{
		object_0[0] = assembly_0;
	}

	public Class4 method_5()
	{
		if (object_0[0] == null)
		{
			int num = -1911698351;
			uint num2 = 355655701u;
			return null;
		}
		return new Class4((Assembly)object_0[0]);
	}

	public void method_6(byte[] byte_0)
	{
		if (byte_0 == null)
		{
			int num = 128576408;
			uint num2 = 128576407u;
		}
		else
		{
			list_0[0] = class2_0.method_0(byte_0);
		}
	}

	public byte[] method_7()
	{
		return list_0[1];
	}

	public byte[] method_8()
	{
		return list_0[2];
	}

	private unsafe bool method_9()
	{
		void* ptr = stackalloc byte[5];
		Class4 @class = method_5();
		string text = @class.ToString();
		@class.method_1(text);
		((byte*)ptr)[4] = 1;
		return ((byte*)ptr)[4] != 0;
	}

	public void method_10()
	{
		method_9();
	}
}
