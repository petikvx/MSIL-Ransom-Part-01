using System;
using System.Collections.Generic;
using System.Linq;
using ns6;

namespace Cam3anulate;

public static class Acqu7s7t7ons
{
	public static string[] Ca4oma(string Sa6dlot)
	{
		return Misga1ged(Sa6dlot, ';');
	}

	public static string[] Misga1ged(string Terraq5eo5s, params char[] Superheatin4)
	{
		if (!string.IsNullOrEmpty(Terraq5eo5s))
		{
			return (from entry in Terraq5eo5s.Split(Superheatin4)
				select entry.Trim() into entry
				where entry.Length != 0
				select entry).ToArray();
		}
		return Array.Empty<string>();
	}

	public static string Proofroo7s(string R5curvat5)
	{
		if (R5curvat5 == null)
		{
			return null;
		}
		R5curvat5 = R5curvat5.Trim();
		if (R5curvat5.Length != 0)
		{
			return R5curvat5;
		}
		return null;
	}

	public static string[] Ekpw4l4(string[] Sub3i3t)
	{
		if (Sub3i3t == null)
		{
			return Array.Empty<string>();
		}
		return (from s in Sub3i3t
			select Proofroo7s(s) into s
			where s != null
			select s).ToArray();
	}

	public static bool S4ile44oes(string V0ulted)
	{
		return bool.TrueString.Equals(Proofroo7s(V0ulted), StringComparison.OrdinalIgnoreCase);
	}

	public static bool Glyca4s(string Z4rfs)
	{
		if (Proofroo7s(Z4rfs) != null)
		{
			return S4ile44oes(Z4rfs);
		}
		return true;
	}

	public static IEnumerable<Thermogr5phers> Pr6smato6ds(string S5oreroom)
	{
		string[] array = Misga1ged(S5oreroom, ';', ',');
		foreach (string text in array)
		{
			if (text.StartsWith("NU", StringComparison.OrdinalIgnoreCase) && Enum.TryParse<Thermogr5phers>(text, ignoreCase: true, out var result))
			{
				yield return result;
			}
		}
	}

	public static string Outbleat1(string Suffragis4)
	{
		return Suffragis4?.Replace(',', ';');
	}

	public static IEnumerable<Thermogr5phers> La7enter(IEnumerable<IEnumerable<Thermogr5phers>> Dilatatio4s)
	{
		if (Dilatatio4s.Count() > 0)
		{
			IEnumerable<Thermogr5phers> enumerable = Enumerable.Empty<Thermogr5phers>();
			bool flag = true;
			foreach (IEnumerable<Thermogr5phers> Dilatatio in Dilatatio4s)
			{
				if (flag)
				{
					enumerable = Dilatatio;
					flag = false;
				}
				else if (enumerable == null || Dilatatio == null || enumerable.Count() != Dilatatio.Count() || !enumerable.All((Func<Thermogr5phers, bool>)Dilatatio.Contains))
				{
					return Enumerable.Empty<Thermogr5phers>();
				}
			}
			return enumerable ?? Enumerable.Empty<Thermogr5phers>();
		}
		return Enumerable.Empty<Thermogr5phers>();
	}
}
