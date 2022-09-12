using System.Runtime.CompilerServices;

internal class c7674047 : Interface1
{
	[SpecialName]
	public byte imethod_0()
	{
		return c34ccaf0.byte_41;
	}

	private static ulong c73880fa(ulong ulong_0, ulong ulong_1)
	{
		ulong num = ulong_0 & 0xFFFFFFFFuL;
		ulong num2 = ulong_0 >> 32;
		ulong num3 = ulong_1 & 0xFFFFFFFFuL;
		ulong num4 = ulong_1 >> 32;
		ulong num5 = num * num3;
		num5 = num2 * num3 + (num5 >> 32);
		ulong num6 = num5 & 0xFFFFFFFFuL;
		ulong num7 = num5 >> 32;
		num5 = num6 + num * num4;
		num6 = num5 & 0xFFFFFFFFuL;
		return num7 + num2 * num4 + (num5 >> 32);
	}

	public void imethod_1(Class54 class54_0, out a0aa499b a0aa499b_0)
	{
		uint num = class54_0.feeb32c3_0[c34ccaf0.byte_3].method_0();
		feeb32c3 feeb32c4 = class54_0.class55_0.ff4c393f(num - 1);
		feeb32c3 feeb32c5 = class54_0.class55_0.ff4c393f(num);
		num--;
		class54_0.class55_0.method_1(num);
		class54_0.feeb32c3_0[c34ccaf0.byte_3].method_1(num);
		byte b = class54_0.feeb32c3_0[c34ccaf0.byte_4].f939861c();
		feeb32c3 feeb32c3_ = default(feeb32c3);
		ulong num2 = feeb32c4.d9a53946() * feeb32c5.d9a53946();
		feeb32c3_.b67abfed(num2);
		class54_0.class55_0.method_0(num, feeb32c3_);
		byte byte_ = (byte)(c34ccaf0.d094b329 | c34ccaf0.byte_8 | c34ccaf0.byte_9);
		byte b2 = (byte)(c34ccaf0.byte_7 | c34ccaf0.b9f4359f);
		byte b3 = 0;
		if ((b & c34ccaf0.byte_9) != 0)
		{
			if (c73880fa(feeb32c4.d9a53946(), feeb32c5.d9a53946()) > 0L)
			{
				b3 = b2;
			}
		}
		else if (num2 >> 63 != (feeb32c4.d9a53946() ^ feeb32c5.d9a53946()) >> 63)
		{
			b3 = b2;
		}
		b = (byte)((b & ~b2) | b3);
		b23ec9a0.e2d89109(feeb32c4.method_0(), feeb32c5.d9a53946(), feeb32c3_.d9a53946(), feeb32c3_.d9a53946(), ref b, byte_);
		class54_0.feeb32c3_0[c34ccaf0.byte_4].e885eacb(b);
		a0aa499b_0 = (a0aa499b)0;
	}
}
