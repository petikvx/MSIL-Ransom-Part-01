using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace ns1;

public struct GStruct0
{
	private readonly MemberDescriptor memberDescriptor_0;

	public static readonly GStruct0 gstruct0_0;

	internal object object_0;

	public bool IsEmpty => object_0 == null;

	public MemberDescriptor Member => memberDescriptor_0;

	public object Owner => object_0;

	public GStruct0(object owner, MemberDescriptor member)
	{
		object obj = (object_0 = owner);
		memberDescriptor_0 = member;
	}

	internal static bool smethod_0(object object_1, ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0)
	{
		AppDomain appDomain_ = (AppDomain)object_1;
		if (GClass1.smethod_0(resolveEventArgs_0, out assembly_0, appDomain_))
		{
			return true;
		}
		assembly_0 = null;
		return false;
	}

	public override bool vmethod_0(object object_1)
	{
		if (!(object_1 is GStruct0 gStruct))
		{
			return false;
		}
		if (gStruct.Owner == Owner)
		{
			return gStruct.Member == Member;
		}
		return false;
	}

	public override int vmethod_1()
	{
		if (object_0 == null)
		{
			return GetHashCode();
		}
		return object_0.GetHashCode() ^ memberDescriptor_0.GetHashCode();
	}

	[SpecialName]
	public static bool smethod_1(GStruct0 gstruct0_1, GStruct0 gstruct0_2)
	{
		if (gstruct0_1.Owner == gstruct0_2.Owner)
		{
			return gstruct0_1.Member == gstruct0_2.Member;
		}
		return false;
	}

	[SpecialName]
	public static bool smethod_2(GStruct0 gstruct0_1, GStruct0 gstruct0_2)
	{
		return !smethod_1(gstruct0_1, gstruct0_2);
	}
}
