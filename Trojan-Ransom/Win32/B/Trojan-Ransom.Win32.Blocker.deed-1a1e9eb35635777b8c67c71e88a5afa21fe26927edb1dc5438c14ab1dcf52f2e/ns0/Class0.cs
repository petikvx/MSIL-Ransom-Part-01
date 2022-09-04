using System;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;
using e1t9ZoIMs7pU1MfVBaV;
using eC98jAqdnPLlDITmK6;
using etKNQTu9kgqwCqmIAv;

namespace ns0;

[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
[CompilerGenerated]
internal sealed class Class0
{
	private static ResourceManager resourceManager_0;

	private static CultureInfo cultureInfo_0;

	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk eDHHd4vO3FpvmheVMk_0;

	[SpecialName]
	internal static ResourceManager smethod_0()
	{
		ResourceManager object_ = default(ResourceManager);
		try
		{
			if (eNpdJYVVbGXP9Iy98V(resourceManager_0, null))
			{
				_ = 0;
				if (eT21Kf4IurQ0aOuCIU())
				{
					object_ = new ResourceManager(eDHHd4vO3FpvmheVMk_0(21934), eg0EBlT4jGewaA1oRs(typeof(Class0).TypeHandle).Assembly);
				}
				resourceManager_0 = object_;
			}
			return resourceManager_0;
		}
		catch (Exception object_2)
		{
			ResourceManager object_3 = default(ResourceManager);
			echDh7GC8ZSjnpuydS(object_2, object_3, object_);
			throw;
		}
	}

	[SpecialName]
	internal static string smethod_1()
	{
		try
		{
			return (string)edgOdl1dGTap1oj8MU(eV2sVGtBt9TLmZmHyn(), eDHHd4vO3FpvmheVMk_0(21963), cultureInfo_0);
		}
		catch (Exception object_)
		{
			string object_2 = default(string);
			eqTV7tRCmNECm01wKT(object_, object_2);
			throw;
		}
	}

	static Class0()
	{
		erW1P7q1VlnLFFYE1o(eg0EBlT4jGewaA1oRs(typeof(Class0).TypeHandle));
	}

	internal static bool eNpdJYVVbGXP9Iy98V(object object_0, object object_1)
	{
		return object.ReferenceEquals(object_0, object_1);
	}

	internal static Type eg0EBlT4jGewaA1oRs(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void echDh7GC8ZSjnpuydS(object object_0, object object_1, object object_2)
	{
		eEJNauItTVW1j8pluTb.e9jslfSvk((Exception)object_0, object_1, object_2);
	}

	internal static bool eT21Kf4IurQ0aOuCIU()
	{
		return true;
	}

	internal static bool eqCYYqpgfFooNAEQlg()
	{
		return false;
	}

	internal static object eV2sVGtBt9TLmZmHyn()
	{
		return smethod_0();
	}

	internal static object edgOdl1dGTap1oj8MU(object object_0, object object_1, object object_2)
	{
		return ((ResourceManager)object_0).GetString((string)object_1, (CultureInfo?)object_2);
	}

	internal static void eqTV7tRCmNECm01wKT(object object_0, object object_1)
	{
		eEJNauItTVW1j8pluTb.ecs0D1Zdd((Exception)object_0, object_1);
	}

	internal static void erW1P7q1VlnLFFYE1o(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
