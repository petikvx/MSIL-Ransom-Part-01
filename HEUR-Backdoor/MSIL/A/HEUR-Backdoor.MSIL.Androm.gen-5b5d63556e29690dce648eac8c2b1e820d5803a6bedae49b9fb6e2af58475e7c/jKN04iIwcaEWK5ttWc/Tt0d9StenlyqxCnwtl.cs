using System;
using System.IO;
using System.Reflection;
using System.Text;
using ACOVXNuRhOUrWxigRt;
using CywHuCRSJ9Nc0dmtm00;
using Hk5mQDzNwF2uhvmw1b;
using SRo1MyRyNCF0HMnMeRy;
using mqTn2KRuHaeVC7qZfAP;

namespace jKN04iIwcaEWK5ttWc;

internal class Tt0d9StenlyqxCnwtl
{
	internal static readonly byte[] yPOR5JAXVH;

	private static Tt0d9StenlyqxCnwtl yK0RMs3Ar7;

	static Tt0d9StenlyqxCnwtl()
	{
		uOxwGiRTS5ExO0AcR6j.vIHvRlxcnv();
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		NYjo1bRqUlt4IQc9SFk.Vax9ZyXknj();
		if (yPOR5JAXVH == null)
		{
			string s = (string)O7QRHMl7Pt(28);
			byte[] array = Convert.FromBase64String(s);
			s = ((Encoding)LgdRVOPfHL()).GetString(array, 0, array.Length);
			Stream object_ = (Stream)QivRCqHElf(lUHRntPNGf(), s);
			yPOR5JAXVH = (byte[])Vi8RBZQ06B(97L, object_);
		}
	}

	public Tt0d9StenlyqxCnwtl()
	{
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		WGyRNSAKNd();
		base._002Ector();
	}

	internal static string vkLRvHQlkJ(int int_0)
	{
		int num = 1;
		string @string = default(string);
		while (true)
		{
			int num2 = 0;
			int num3 = 0;
			if (!JSERgt6RUx())
			{
				goto IL_000b;
			}
			goto IL_002b;
			IL_002b:
			switch (num3)
			{
			case 1:
				continue;
			case 2:
				goto IL_0084;
			case 5:
				goto IL_00ac;
			case 6:
				goto IL_00be;
			case 3:
				goto IL_00cf;
			case 4:
				goto IL_0118;
			case 7:
				goto end_IL_0052;
			}
			goto IL_000b;
			IL_00ac:
			num2 = yPOR5JAXVH[int_0];
			int_0++;
			goto IL_00f4;
			IL_000b:
			if ((yPOR5JAXVH[int_0] & 0x80) == 0)
			{
				num3 = 5;
				if (!JSERgt6RUx())
				{
					num3 = num;
				}
				goto IL_002b;
			}
			if ((yPOR5JAXVH[int_0] & 0x40) == 0)
			{
				goto IL_0084;
			}
			num2 = (yPOR5JAXVH[int_0] & -193) << 24;
			goto IL_00be;
			IL_00cf:
			num2 |= yPOR5JAXVH[int_0 + 2] << 8;
			num2 |= yPOR5JAXVH[int_0 + 3];
			int_0 += 4;
			goto IL_00f4;
			IL_00f4:
			if (num2 < 1)
			{
				num = 7;
				break;
			}
			@string = Encoding.Unicode.GetString(yPOR5JAXVH, int_0, num2);
			goto IL_0118;
			IL_0084:
			num2 = (yPOR5JAXVH[int_0] & -129) << 8;
			num2 |= yPOR5JAXVH[int_0 + 1];
			int_0 += 2;
			goto IL_00f4;
			IL_0118:
			return string.Intern(@string);
			IL_00be:
			num2 |= yPOR5JAXVH[int_0 + 1] << 16;
			goto IL_00cf;
			continue;
			end_IL_0052:
			break;
		}
		return string.Empty;
	}

	internal static object O7QRHMl7Pt(int int_0)
	{
		return oxfevuxb8f51pPM8uj.ADIaRIoIY4(int_0);
	}

	internal static object LgdRVOPfHL()
	{
		return Encoding.UTF8;
	}

	internal static object lUHRntPNGf()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object QivRCqHElf(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object Vi8RBZQ06B(long long_0, object object_0)
	{
		return ajyaamTDLVqY4QEdvS.ilvRtPhKkE(long_0, (Stream)object_0);
	}

	internal static bool JSERgt6RUx()
	{
		return yK0RMs3Ar7 == null;
	}

	internal static Tt0d9StenlyqxCnwtl gtSRmbmdwg()
	{
		return yK0RMs3Ar7;
	}

	internal static void WGyRNSAKNd()
	{
		NYjo1bRqUlt4IQc9SFk.Vax9ZyXknj();
	}
}
