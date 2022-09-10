using TGaER2JO;
using iLd730DL;
using iiraiv39;
using p80hVGtz;
using wMk1FHff;

namespace CCfpfC7h;

internal class Uwq3BfOZ
{
	public static vilSnlZy smethod_0(string yQD3HGxO, string fgorXqpN, string gL0iIYxN, string string_0, string XS8zBG35, string V5zS1FJI, string yI6Hkfrz, bool iQVPJ7wP)
	{
		vilSnlZy result = null;
		if (uJu4hQbz(XS8zBG35, V5zS1FJI))
		{
			vilSnlZy vilSnlZy2 = null;
			if (ivlgLlId.smethod_3(V5zS1FJI, "BOOL", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(V5zS1FJI, "INT", bool_0: false, 3221) != 0)
				{
					if (ivlgLlId.smethod_3(V5zS1FJI, "REAL", bool_0: false, 3221) == 0)
					{
						vilSnlZy2 = new hK8QNa8w(yQD3HGxO, fgorXqpN, gL0iIYxN, string_0, Class15.SovO4tjC(XS8zBG35, vRvDyS3Z.smethod_0(Class15.kJu0kMKf(45123), 40301), 5098).ToString(), (TpkjKE5s)ivlgLlId.PluO6Q6e(yI6Hkfrz, 37974));
					}
				}
				else
				{
					vilSnlZy2 = new Class5(yQD3HGxO, fgorXqpN, gL0iIYxN, string_0, ivlgLlId.PluO6Q6e(XS8zBG35, 37974).ToString(), iQVPJ7wP, (TpkjKE5s)ivlgLlId.PluO6Q6e(yI6Hkfrz, 37974));
				}
			}
			else
			{
				vilSnlZy2 = new cXJ3GNUP(yQD3HGxO, fgorXqpN, gL0iIYxN, string_0, sSR2WoR5.TIlpptNk(XS8zBG35, 3804).ToString(), (TpkjKE5s)ivlgLlId.PluO6Q6e(yI6Hkfrz, 37974));
			}
			result = vilSnlZy2;
		}
		return result;
	}

	public static bool uJu4hQbz(string IVnCpELs, string string_0)
	{
		if (ivlgLlId.smethod_3(string_0, "BOOL", bool_0: false, 3221) != 0)
		{
			if (ivlgLlId.smethod_3(string_0, "INT", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(string_0, "REAL", bool_0: false, 3221) == 0)
				{
					return new hK8QNa8w().vmethod_0(IVnCpELs);
				}
				bool result = default(bool);
				return result;
			}
			return new Class5().vmethod_0(IVnCpELs);
		}
		return new cXJ3GNUP().vmethod_0(IVnCpELs);
	}

	public static string qygLLdlN(string zJohbEqI)
	{
		if (uJu4hQbz(zJohbEqI, "BOOL"))
		{
			return "BOOL";
		}
		if (uJu4hQbz(zJohbEqI, "REAL"))
		{
			return "REAL";
		}
		if (uJu4hQbz(zJohbEqI, "INT"))
		{
			return "INT";
		}
		return "";
	}

	public static string wwYoSPaE(string string_0)
	{
		if (ivlgLlId.smethod_3(string_0, "BOOL", bool_0: false, 3221) != 0)
		{
			if (ivlgLlId.smethod_3(string_0, "REAL", bool_0: false, 3221) != 0)
			{
				if (ivlgLlId.smethod_3(string_0, "INT", bool_0: false, 3221) != 0)
				{
					return null;
				}
				return "0";
			}
			return "0.0";
		}
		return "False";
	}
}
