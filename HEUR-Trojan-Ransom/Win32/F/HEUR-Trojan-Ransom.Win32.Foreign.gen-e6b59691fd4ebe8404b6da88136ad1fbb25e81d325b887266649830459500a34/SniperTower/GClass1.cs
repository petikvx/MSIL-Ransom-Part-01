using System;
using System.ComponentModel;
using System.Reflection;

namespace SniperTower;

public class GClass1 : Component
{
	private IContainer icontainer_0 = null;

	public static object smethod_0(Type type_0, string string_0, object[] object_0)
	{
		return type_0.InvokeMember(string_0, BindingFlags.InvokeMethod, null, null, object_0);
	}

	public static byte[] smethod_1(byte[] byte_0)
	{
		checked
		{
			byte[] array = new byte[byte_0.Length - 16 - 1 + 1];
			Array.Copy(byte_0, 16, array, 0, array.Length);
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				array[i] ^= byte_0[unchecked(i % 16)];
			}
			return array;
		}
	}

	public GClass1()
	{
		method_0();
	}

	public GClass1(IContainer icontainer_1)
	{
		icontainer_1.Add(this);
		method_0();
	}

	protected override void vmethod_0(bool bool_0)
	{
		if (bool_0 && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		base.Dispose(bool_0);
	}

	private void method_0()
	{
		icontainer_0 = new Container();
	}
}
