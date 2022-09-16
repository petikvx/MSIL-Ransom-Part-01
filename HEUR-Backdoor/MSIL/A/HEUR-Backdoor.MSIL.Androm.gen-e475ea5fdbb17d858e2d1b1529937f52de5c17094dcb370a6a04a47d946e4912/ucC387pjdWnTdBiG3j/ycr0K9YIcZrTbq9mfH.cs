using System;
using System.IO;
using System.Reflection;
using BJrZjRSiEILMZ5hytC;
using Pj91rV27dKBAsuQFb5U;
using WEVFYJ2WPuik8y16vgG;
using m45bGeWJrrCnJ05dZo;
using piO3af2M2LrtQb05a7e;
using sYYA3w7ZQygyyhIQss;
using zAMfY5AOEEX9XRKiyG;

namespace ucC387pjdWnTdBiG3j;

internal class ycr0K9YIcZrTbq9mfH
{
	private static readonly Assembly AFE36qEuF;

	private static ycr0K9YIcZrTbq9mfH oHdUvDJEe;

	static ycr0K9YIcZrTbq9mfH()
	{
		nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
		hj5jty8qU(rs0WWYoFZ(), new ResolveEventHandler(oMDJ4Nu26));
		AppDomain.CurrentDomain.AssemblyResolve += uTdPBiG3j;
		Assembly assembly_ = (Assembly)uiXvFWSx5();
		string assemblyString = kHi5ZbmMy(assembly_);
		AFE36qEuF = Assembly.Load(assemblyString);
	}

	public ycr0K9YIcZrTbq9mfH()
	{
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		FPpyvtWjL();
		base._002Ector();
	}

	internal static void MC3s87jdW()
	{
	}

	private static Assembly uTdPBiG3j(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		string text = kHi5ZbmMy(executingAssembly);
		if (resolveEventArgs_0.Name.StartsWith(text))
		{
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(text);
			if (bIdnMs9Dh() == null)
			{
				switch (0)
				{
				}
			}
			byte[] rawAssembly = O3VQEjJqutgUVAK2W9.GMZ2q5hytC(97L, manifestResourceStream);
			return Assembly.Load(rawAssembly);
		}
		return null;
	}

	private static string kHi5ZbmMy(Assembly assembly_0)
	{
		string text = assembly_0.FullName;
		int num = text.IndexOf(',');
		int num2 = 1;
		if (bIdnMs9Dh() != null)
		{
			int num3 = default(int);
			num2 = num3;
		}
		switch (num2)
		{
		case 1:
			if (num < 0)
			{
				break;
			}
			goto default;
		default:
			text = text.Substring(0, num);
			break;
		}
		return wDln0gl2pRUmSt7QCe.P2bIfnvmm8(text, '&');
	}

	private static Assembly oMDJ4Nu26(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		int num = 4;
		int num3 = default(int);
		while ((object)AFE36qEuF != null)
		{
			while (true)
			{
				string[] manifestResourceNames = AFE36qEuF.GetManifestResourceNames();
				int num2 = 1;
				if (bIdnMs9Dh() != null)
				{
					goto IL_0030;
				}
				goto IL_0049;
				IL_0049:
				switch (num2)
				{
				case 1:
					break;
				default:
					goto IL_0030;
				case 3:
					continue;
				case 4:
					goto end_IL_0064;
				case 2:
					return null;
				}
				num3 = 0;
				goto IL_000e;
				IL_0030:
				num3++;
				goto IL_000e;
				IL_000e:
				if (num3 < (int)(nuint)ufevL0e6AUn8FAIkEf.QJQI6tDGCl(manifestResourceNames))
				{
					string string_ = manifestResourceNames[num3];
					if (SvJyS0LIqAEUBCJArd.SitIDycgsb(string_, resolveEventArgs_0.Name))
					{
						return AFE36qEuF;
					}
					goto IL_0030;
				}
				num2 = 2;
				if (bIdnMs9Dh() != null)
				{
					num2 = num;
				}
				goto IL_0049;
				continue;
				end_IL_0064:
				break;
			}
		}
		return AFE36qEuF;
	}

	internal static object rs0WWYoFZ()
	{
		return AppDomain.CurrentDomain;
	}

	internal static void hj5jty8qU(object object_0, object object_1)
	{
		((AppDomain)object_0).ResourceResolve += (ResolveEventHandler?)object_1;
	}

	internal static object uiXvFWSx5()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static bool En5BawgM2()
	{
		return oHdUvDJEe == null;
	}

	internal static ycr0K9YIcZrTbq9mfH bIdnMs9Dh()
	{
		return oHdUvDJEe;
	}

	internal static void FPpyvtWjL()
	{
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
	}
}
