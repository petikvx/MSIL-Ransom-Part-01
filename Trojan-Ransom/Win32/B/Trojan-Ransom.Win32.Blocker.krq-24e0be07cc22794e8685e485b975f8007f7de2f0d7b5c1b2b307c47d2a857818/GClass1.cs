using System;
using System.Runtime.CompilerServices;
using IgfxManager.My.Resources;

public class GClass1 : IDisposable
{
	public static byte[] byte_0 = new byte[874];

	private bool bool_0;

	public GClass1()
	{
		Random random = new Random(Guid.NewGuid().GetHashCode());
		random.NextBytes(byte_0);
	}

	public void method_0()
	{
	}

	protected virtual void vmethod_0(bool bool_1)
	{
		if (!bool_0 && bool_1)
		{
			GClass2 gClass = new GClass2();
			gClass.method_0(RuntimeHelpers.GetObjectValue(Resources.Object_0[3]));
		}
		bool_0 = true;
	}

	public void Dispose()
	{
		vmethod_0(bool_1: true);
		GC.SuppressFinalize(this);
	}
}
