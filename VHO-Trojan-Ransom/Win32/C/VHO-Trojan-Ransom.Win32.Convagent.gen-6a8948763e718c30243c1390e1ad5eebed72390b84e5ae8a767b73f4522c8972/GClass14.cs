using System;
using System.Runtime.CompilerServices;

public class GClass14
{
	private readonly GClass3.Class0 class0_0;

	private GClass14()
		: this(0uL)
	{
	}

	private GClass14(uint unAccountID, uint unInstance, GEnum3 eUniverse, GEnum2 eAccountType)
		: this()
	{
		method_0(unAccountID, unInstance, eUniverse, eAccountType);
	}

	public GClass14(ulong id)
	{
		class0_0 = new GClass3.Class0(id);
	}

	private GClass14(GStruct3 sid)
		: this(sid.uint_0, sid.uint_1 & 0xFFFFFu, (GEnum3)(sid.uint_1 >> 24), (GEnum2)((int)(sid.uint_1 >> 20) & 0xF))
	{
	}

	[SpecialName]
	public static ulong smethod_0(GClass14 gclass14_0)
	{
		return gclass14_0.class0_0.method_0();
	}

	[SpecialName]
	public static GClass14 smethod_1(ulong ulong_0)
	{
		return new GClass14(ulong_0);
	}

	[SpecialName]
	public static GClass14 smethod_2(GStruct3 gstruct3_0)
	{
		return new GClass14(gstruct3_0);
	}

	private void method_0(uint uint_0, uint uint_1, GEnum3 genum3_0, GEnum2 genum2_0)
	{
		method_3(uint_0);
		method_9(genum3_0);
		method_7(genum2_0);
		method_5(uint_1);
	}

	public ulong method_1()
	{
		return class0_0.method_0();
	}

	[SpecialName]
	private uint method_2()
	{
		return (uint)class0_0.method_2(0u, 4294967295uL);
	}

	[SpecialName]
	private void method_3(uint uint_0)
	{
		class0_0.method_3(0u, 4294967295uL, uint_0);
	}

	[SpecialName]
	private uint method_4()
	{
		return (uint)class0_0.method_2(32u, 1048575uL);
	}

	[SpecialName]
	private void method_5(uint uint_0)
	{
		class0_0.method_3(32u, 1048575uL, uint_0);
	}

	[SpecialName]
	private GEnum2 method_6()
	{
		return (GEnum2)class0_0.method_2(52u, 15uL);
	}

	[SpecialName]
	private void method_7(GEnum2 genum2_0)
	{
		class0_0.method_3(52u, 15uL, (ulong)genum2_0);
	}

	[SpecialName]
	private GEnum3 method_8()
	{
		return (GEnum3)class0_0.method_2(56u, 255uL);
	}

	[SpecialName]
	private void method_9(GEnum3 genum3_0)
	{
		class0_0.method_3(56u, 255uL, (ulong)genum3_0);
	}

	public string method_10()
	{
		switch (method_6())
		{
		default:
			return Convert.ToString(smethod_0(this));
		case GEnum2.k_EAccountTypeInvalid:
		case GEnum2.k_EAccountTypeIndividual:
			if (method_8() <= GEnum3.k_EUniversePublic)
			{
				return $"STEAM_0:{method_2() & 1u}:{method_2() >> 1}";
			}
			return string.Format("STEAM_{2}:{0}:{1}", method_2() & 1u, method_2() >> 1, (int)method_8());
		}
	}

	public override string ToString()
	{
		return method_10();
	}

	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (!(obj is GClass14 gClass))
		{
			return false;
		}
		return class0_0.method_0() == gClass.class0_0.method_0();
	}

	[SpecialName]
	public static bool smethod_3(GClass14 gclass14_0, GClass14 gclass14_1)
	{
		if (object.ReferenceEquals(gclass14_0, gclass14_1))
		{
			return true;
		}
		if (gclass14_0 == null || gclass14_1 == null)
		{
			return false;
		}
		return gclass14_0.class0_0.method_0() == gclass14_1.class0_0.method_0();
	}

	[SpecialName]
	public static bool smethod_4(GClass14 gclass14_0, GClass14 gclass14_1)
	{
		return !smethod_3(gclass14_0, gclass14_1);
	}

	public override int GetHashCode()
	{
		return class0_0.method_0().GetHashCode();
	}
}
