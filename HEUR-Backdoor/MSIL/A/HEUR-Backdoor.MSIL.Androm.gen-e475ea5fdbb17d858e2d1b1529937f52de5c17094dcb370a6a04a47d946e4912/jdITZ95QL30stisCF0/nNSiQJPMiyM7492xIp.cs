using System;
using System.IO;
using System.Reflection;
using System.Text;
using OyfHrs96YBnkeHQJdZ;
using Pj91rV27dKBAsuQFb5U;
using WEVFYJ2WPuik8y16vgG;
using m45bGeWJrrCnJ05dZo;
using piO3af2M2LrtQb05a7e;

namespace jdITZ95QL30stisCF0;

internal class nNSiQJPMiyM7492xIp
{
	internal static readonly byte[] T7c22Go8MC;

	internal static nNSiQJPMiyM7492xIp nlE2IXiFUD;

	static nNSiQJPMiyM7492xIp()
	{
		nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
		if (T7c22Go8MC == null)
		{
			string s = A2IykMCm48qOE9ZWAc.VCEIRVFYJP(36);
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream object_ = (Stream)eVqCyTerb(Assembly.GetExecutingAssembly(), s);
			T7c22Go8MC = (byte[])p519lQGrH(97L, object_);
		}
	}

	public nNSiQJPMiyM7492xIp()
	{
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
		base._002Ector();
	}

	internal static string osQQ5tI2L(int int_0)
	{
		int num = 1;
		int num2;
		while (true)
		{
			num2 = 0;
			int num3 = 0;
			if (!gT5uRX2b9())
			{
				goto IL_000e;
			}
			goto IL_006f;
			IL_006f:
			switch (num3)
			{
			case 1:
				continue;
			case 2:
				num2 |= T7c22Go8MC[int_0 + 2] << 8;
				num2 |= T7c22Go8MC[int_0 + 3];
				int_0 += 4;
				goto end_IL_0099;
			case 6:
				goto IL_00d5;
			case 5:
			case 7:
				num2 = T7c22Go8MC[int_0];
				int_0++;
				goto end_IL_0099;
			case 3:
			case 4:
				goto end_IL_0099;
			}
			goto IL_000e;
			IL_000e:
			if ((T7c22Go8MC[int_0] & 0x80) == 0)
			{
				num3 = 7;
				if (Sjuz8jPmZ() != null)
				{
					goto IL_006b;
				}
			}
			else
			{
				if ((T7c22Go8MC[int_0] & 0x40) == 0)
				{
					goto IL_00d5;
				}
				num2 = (T7c22Go8MC[int_0] & -193) << 24;
				num2 |= T7c22Go8MC[int_0 + 1] << 16;
				num3 = 2;
				if (Sjuz8jPmZ() != null)
				{
					goto IL_006b;
				}
			}
			goto IL_006f;
			IL_00d5:
			num2 = (T7c22Go8MC[int_0] & -129) << 8;
			num2 |= T7c22Go8MC[int_0 + 1];
			int_0 += 2;
			break;
			IL_006b:
			num3 = num;
			goto IL_006f;
			continue;
			end_IL_0099:
			break;
		}
		if (num2 < 1)
		{
			return string.Empty;
		}
		string str = (string)lWr2ZI7Yd1(Encoding.Unicode, T7c22Go8MC, int_0, num2);
		return string.Intern(str);
	}

	internal static object eVqCyTerb(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object p519lQGrH(long long_0, object object_0)
	{
		return O3VQEjJqutgUVAK2W9.GMZ2q5hytC(long_0, (Stream)object_0);
	}

	internal static bool gT5uRX2b9()
	{
		return nlE2IXiFUD == null;
	}

	internal static nNSiQJPMiyM7492xIp Sjuz8jPmZ()
	{
		return nlE2IXiFUD;
	}

	internal static object lWr2ZI7Yd1(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}
}
