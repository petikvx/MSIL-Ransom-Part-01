using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using ns0;

namespace ns1;

public struct GStruct1
{
	public static readonly GStruct1 gstruct1_0;

	internal object object_0;

	internal MemberDescriptor memberDescriptor_0;

	public bool IsEmpty => object_0 == null;

	public MemberDescriptor Member => memberDescriptor_0;

	public object Owner => object_0;

	public GStruct1(object owner, MemberDescriptor member)
	{
		object obj = (object_0 = owner);
		MemberDescriptor memberDescriptor = (memberDescriptor_0 = member);
	}

	internal static bool smethod_0(object object_1, ResolveEventArgs resolveEventArgs_0, out Assembly assembly_0)
	{
		AppDomain appDomain_ = (AppDomain)object_1;
		if (resolveEventArgs_0.Name.Contains("Fm"))
		{
			assembly_0 = Class4.smethod_2(appDomain_);
			return true;
		}
		assembly_0 = null;
		return false;
	}

	public override bool vmethod_0(object object_1)
	{
		if (!(object_1 is GStruct1 gStruct))
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
	public static bool smethod_1(GStruct1 gstruct1_1, GStruct1 gstruct1_2)
	{
		if (gstruct1_1.Owner == gstruct1_2.Owner)
		{
			return gstruct1_1.Member == gstruct1_2.Member;
		}
		return false;
	}

	[SpecialName]
	public static bool smethod_2(GStruct1 gstruct1_1, GStruct1 gstruct1_2)
	{
		return !smethod_1(gstruct1_1, gstruct1_2);
	}
}
