using System;
using System.IO;
using System.Reflection;
using ACOVXNuRhOUrWxigRt;
using BDa4ZXKErShorWxMGI;
using CywHuCRSJ9Nc0dmtm00;
using HvqHEl8fYi8ZQ06B4S;
using LuMNwH4UctLAkIv5W5;
using SRo1MyRyNCF0HMnMeRy;
using mqTn2KRuHaeVC7qZfAP;

namespace pXkqK9B9pPITqPYcS8;

internal class g3BLb5CjQF1c3TOo8w
{
	private static readonly Assembly OePh9JIii;

	internal static g3BLb5CjQF1c3TOo8w c1tk00O4y;

	static g3BLb5CjQF1c3TOo8w()
	{
		uOxwGiRTS5ExO0AcR6j.vIHvRlxcnv();
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		NYjo1bRqUlt4IQc9SFk.Vax9ZyXknj();
		((AppDomain)A9V1ifBRH()).ResourceResolve += eTRfCXXlM;
		((AppDomain)A9V1ifBRH()).AssemblyResolve += tlLAra0me;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string object_ = aQq2T2RHq(executingAssembly);
		OePh9JIii = (Assembly)RLT3pdcP0(object_);
	}

	public g3BLb5CjQF1c3TOo8w()
	{
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		HYk8iC3Ay();
		base._002Ector();
	}

	internal static void HTtLDY51n()
	{
	}

	private static Assembly tlLAra0me(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = (string)ULcPOpJKc(executingAssembly);
		int num;
		if (resolveEventArgs_0.Name.StartsWith(text))
		{
			num = 1;
			if (dDUGdhQ2m() == null)
			{
				goto IL_002c;
			}
			goto IL_003d;
		}
		return null;
		IL_002c:
		num = 0;
		if (!KkyXaxKBX())
		{
			int num2 = default(int);
			num = num2;
		}
		goto IL_003d;
		IL_003d:
		byte[] rawAssembly = default(byte[]);
		switch (num)
		{
		case 1:
			break;
		default:
		{
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
			rawAssembly = ajyaamTDLVqY4QEdvS.ilvRtPhKkE(97L, manifestResourceStream);
			goto case 2;
		}
		case 2:
			return Assembly.Load(rawAssembly);
		}
		goto IL_002c;
	}

	private static string aQq2T2RHq(Assembly assembly_0)
	{
		int num = 1;
		while (true)
		{
			string text = assembly_0.FullName;
			int num2 = 0;
			if (dDUGdhQ2m() != null)
			{
				num2 = num;
			}
			switch (num2)
			{
			case 1:
				continue;
			}
			int num3 = text.IndexOf(',');
			if (num3 >= 0)
			{
				text = text.Substring(0, num3);
			}
			return (string)nn5cWwQVe(text, '&');
		}
	}

	private static Assembly eTRfCXXlM(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		int num = 1;
		string string_ = default(string);
		int num3 = default(int);
		string[] manifestResourceNames = default(string[]);
		while ((object)OePh9JIii != null)
		{
			int num2 = 0;
			if (dDUGdhQ2m() != null)
			{
				num2 = num;
			}
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (!LgdOPfGHLNUHtPNGfs.H26FSYbgOA(string_, resolveEventArgs_0.Name))
					{
						num3++;
						goto IL_0027;
					}
					return OePh9JIii;
				case 2:
					num3 = 0;
					goto IL_0027;
				default:
					manifestResourceNames = OePh9JIii.GetManifestResourceNames();
					num2 = 2;
					if (!KkyXaxKBX())
					{
						continue;
					}
					goto case 2;
				case 1:
					break;
				case 3:
					{
						return null;
					}
					IL_0027:
					if (num3 < (int)(nuint)cOIbIOZHwFMDJdNyEW.V1TFG0esE7(manifestResourceNames))
					{
						string_ = manifestResourceNames[num3];
						num2 = 4;
						if (KkyXaxKBX())
						{
							continue;
						}
						goto case 4;
					}
					goto case 3;
				}
				break;
			}
		}
		return OePh9JIii;
	}

	internal static object A9V1ifBRH()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object RLT3pdcP0(object object_0)
	{
		return Assembly.Load((string)object_0);
	}

	internal static bool KkyXaxKBX()
	{
		return c1tk00O4y == null;
	}

	internal static g3BLb5CjQF1c3TOo8w dDUGdhQ2m()
	{
		return c1tk00O4y;
	}

	internal static void HYk8iC3Ay()
	{
		NYjo1bRqUlt4IQc9SFk.Vax9ZyXknj();
	}

	internal static object ULcPOpJKc(object object_0)
	{
		return aQq2T2RHq((Assembly)object_0);
	}

	internal static object nn5cWwQVe(object object_0, object object_1)
	{
		return SEqHl2e31VBEXe2O2k.YpXFA4UZW0(object_0, object_1);
	}
}
