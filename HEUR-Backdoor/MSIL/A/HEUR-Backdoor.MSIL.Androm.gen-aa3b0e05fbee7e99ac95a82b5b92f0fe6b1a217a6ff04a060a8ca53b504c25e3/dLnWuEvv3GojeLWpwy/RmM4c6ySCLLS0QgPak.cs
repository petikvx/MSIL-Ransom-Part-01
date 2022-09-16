using System;
using System.IO;
using System.Reflection;
using EhdA9I4ntZdCXaNotex;
using HrqeXu48u5BWvM2U05m;
using JAhEyh46uvA1xwWjvIk;
using bnPwHtrfCdH7uGRHDh;
using cgJuIS3Y42vtcmltot;
using feOruubbqssrynGUrM;
using oHDygP8UHs3jGn3SAa;

namespace dLnWuEvv3GojeLWpwy;

internal class RmM4c6ySCLLS0QgPak
{
	private static readonly Assembly oPRgruVVl;

	internal static RmM4c6ySCLLS0QgPak MmmKnrAAG;

	static RmM4c6ySCLLS0QgPak()
	{
		K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
		((AppDomain)zHtGgs4la()).ResourceResolve += AB8O64US8;
		((AppDomain)zHtGgs4la()).AssemblyResolve += aHBFQ52PH;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string object_ = VYgBx36jx(executingAssembly);
		oPRgruVVl = (Assembly)EqYTgNucX(object_);
	}

	public RmM4c6ySCLLS0QgPak()
	{
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		j5TbrF7D1();
		base._002Ector();
	}

	internal static void jqkZJ2e00()
	{
	}

	private static Assembly aHBFQ52PH(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = (string)f8FA0bIV1(executingAssembly);
		int num;
		if (resolveEventArgs_0.Name.StartsWith(text))
		{
			num = 1;
			if (UFVEvcEjV() == null)
			{
				goto IL_002c;
			}
			goto IL_003d;
		}
		return null;
		IL_002c:
		num = 0;
		if (!v1VMNFi9E())
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
			rawAssembly = CNZkc41wwVeHFDb1SW.NIU4jCRtQE(97L, manifestResourceStream);
			goto case 2;
		}
		case 2:
			return Assembly.Load(rawAssembly);
		}
		goto IL_002c;
	}

	private static string VYgBx36jx(Assembly assembly_0)
	{
		int num = 1;
		while (true)
		{
			string text = assembly_0.FullName;
			int num2 = 0;
			if (UFVEvcEjV() != null)
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
			return (string)kiDQeAuVH(text, '&');
		}
	}

	private static Assembly AB8O64US8(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		int num = 1;
		string string_ = default(string);
		int num3 = default(int);
		string[] manifestResourceNames = default(string[]);
		while ((object)oPRgruVVl != null)
		{
			int num2 = 0;
			if (UFVEvcEjV() != null)
			{
				num2 = num;
			}
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (!f2edCiE3phBltiVo1R.VPVJnopFQ6(string_, resolveEventArgs_0.Name))
					{
						num3++;
						goto IL_0027;
					}
					return oPRgruVVl;
				case 2:
					num3 = 0;
					goto IL_0027;
				default:
					manifestResourceNames = oPRgruVVl.GetManifestResourceNames();
					num2 = 2;
					if (!v1VMNFi9E())
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
					if (num3 < (int)(nuint)tB1HWWclJR8ErhoNeF.RqAJEWVswX(manifestResourceNames))
					{
						string_ = manifestResourceNames[num3];
						num2 = 4;
						if (v1VMNFi9E())
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
		return oPRgruVVl;
	}

	internal static object zHtGgs4la()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object EqYTgNucX(object object_0)
	{
		return Assembly.Load((string)object_0);
	}

	internal static bool v1VMNFi9E()
	{
		return MmmKnrAAG == null;
	}

	internal static RmM4c6ySCLLS0QgPak UFVEvcEjV()
	{
		return MmmKnrAAG;
	}

	internal static void j5TbrF7D1()
	{
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
	}

	internal static object f8FA0bIV1(object object_0)
	{
		return VYgBx36jx((Assembly)object_0);
	}

	internal static object kiDQeAuVH(object object_0, object object_1)
	{
		return OmvWN69YeOfK4dK8GE.VWuJFEdYiI(object_0, object_1);
	}
}
