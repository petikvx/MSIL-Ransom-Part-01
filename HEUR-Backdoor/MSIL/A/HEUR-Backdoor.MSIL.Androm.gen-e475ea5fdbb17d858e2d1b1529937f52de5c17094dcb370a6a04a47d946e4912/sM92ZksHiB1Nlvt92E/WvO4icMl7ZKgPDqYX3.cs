using System;
using System.IO;
using System.Reflection;
using System.Text;
using OyfHrs96YBnkeHQJdZ;
using Pj91rV27dKBAsuQFb5U;
using WEVFYJ2WPuik8y16vgG;
using m45bGeWJrrCnJ05dZo;
using piO3af2M2LrtQb05a7e;

namespace sM92ZksHiB1Nlvt92E;

internal class WvO4icMl7ZKgPDqYX3
{
	internal static readonly byte[] n4WrIj0Qe;

	internal readonly int yAMFPDn8Y;

	internal static WvO4icMl7ZKgPDqYX3 rrAX8fCqo;

	static WvO4icMl7ZKgPDqYX3()
	{
		nohvtg2Jq63jo2SldqX.Yg2TdiiKvR();
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		G8Tbjf2Dg();
		if (n4WrIj0Qe == null)
		{
			string s = A2IykMCm48qOE9ZWAc.VCEIRVFYJP(0);
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			n4WrIj0Qe = O3VQEjJqutgUVAK2W9.GMZ2q5hytC(97L, manifestResourceStream);
		}
	}

	public WvO4icMl7ZKgPDqYX3()
	{
		SRi2wG2ekq8Qq3o8MsP.BBNk2FYz0y7N1();
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
		base._002Ector();
	}

	internal static int PqfcKIHO4(int int_0)
	{
		return BitConverter.ToInt32(n4WrIj0Qe, int_0);
	}

	internal static long jAFwIabfG(int int_0)
	{
		return Db0ke0n5l(n4WrIj0Qe, int_0);
	}

	internal static float xsy0EGt8s(int int_0)
	{
		return BitConverter.ToSingle(n4WrIj0Qe, int_0);
	}

	internal static double aPFdIT2U0(int int_0)
	{
		return BitConverter.ToDouble(n4WrIj0Qe, int_0);
	}

	internal static void gaCRytehj(Array array_0, int int_0)
	{
		int num = 0;
		int num2;
		if ((n4WrIj0Qe[int_0] & 0x80) == 0)
		{
			num2 = 2;
			if (vMug9dE8v() != null)
			{
				goto IL_00b5;
			}
		}
		else
		{
			if ((n4WrIj0Qe[int_0] & 0x40u) != 0)
			{
				num = (n4WrIj0Qe[int_0] & -193) << 24;
				num |= n4WrIj0Qe[int_0 + 1] << 16;
				num |= n4WrIj0Qe[int_0 + 2] << 8;
				num |= n4WrIj0Qe[int_0 + 3];
				goto IL_0085;
			}
			num2 = 5;
			if (vMug9dE8v() != null)
			{
				goto IL_0099;
			}
		}
		goto IL_00c0;
		IL_0085:
		int_0 += 4;
		num2 = 0;
		if (vMug9dE8v() != null)
		{
			goto IL_0099;
		}
		goto IL_00c0;
		IL_0099:
		int num3 = default(int);
		num2 = num3;
		goto IL_00c0;
		IL_00b5:
		num = n4WrIj0Qe[int_0];
		goto IL_009f;
		IL_009f:
		int_0++;
		num2 = 1;
		if (!O8DtLfH0v())
		{
			goto IL_0099;
		}
		goto IL_00c0;
		IL_00c0:
		switch (num2)
		{
		case 6:
			break;
		case 3:
			goto IL_009f;
		case 2:
			goto IL_00b5;
		case 4:
		case 5:
			num = (n4WrIj0Qe[int_0] & -129) << 8;
			num |= n4WrIj0Qe[int_0 + 1];
			int_0 += 2;
			goto default;
		default:
			if (num >= 1)
			{
				Buffer.BlockCopy(n4WrIj0Qe, int_0, array_0, 0, num);
			}
			return;
		}
		goto IL_0085;
	}

	internal static void G8Tbjf2Dg()
	{
		qrfVDV24YoTFkucSFup.SUCTSny3c8();
	}

	internal static bool O8DtLfH0v()
	{
		return rrAX8fCqo == null;
	}

	internal static WvO4icMl7ZKgPDqYX3 vMug9dE8v()
	{
		return rrAX8fCqo;
	}

	internal static long Db0ke0n5l(object object_0, int int_0)
	{
		return BitConverter.ToInt64((byte[])object_0, int_0);
	}
}
