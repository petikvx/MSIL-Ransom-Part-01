using System;
using System.IO;
using System.Reflection;
using System.Text;
using EhdA9I4ntZdCXaNotex;
using HrqeXu48u5BWvM2U05m;
using JAhEyh46uvA1xwWjvIk;
using T7eunHzmke0yeryayX;
using oHDygP8UHs3jGn3SAa;

namespace MRruVVqlPmmnrAAGS3;

internal class f8F0bInV17iDeAuVHn
{
	internal static readonly byte[] YkU4Jkc6jp;

	internal readonly int Mw64enjm8u;

	private static f8F0bInV17iDeAuVHn Qgc40lodAY;

	static f8F0bInV17iDeAuVHn()
	{
		K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		dgESvv1N6();
		if (YkU4Jkc6jp == null)
		{
			string s = sD2Wk4DskFhChtylq3.vXpe4HnnoY(0);
			byte[] array = Convert.FromBase64String(s);
			s = (string)A9uDJSgnc(Encoding.UTF8, array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			YkU4Jkc6jp = (byte[])Cn4zRy8MH(97L, manifestResourceStream);
		}
	}

	public f8F0bInV17iDeAuVHn()
	{
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
		base._002Ector();
	}

	internal static int DMNoUaDCL(int int_0)
	{
		return BitConverter.ToInt32(YkU4Jkc6jp, int_0);
	}

	internal static long mySIAA7Df(int int_0)
	{
		return BitConverter.ToInt64(YkU4Jkc6jp, int_0);
	}

	internal static float EotCZ2E4t(int int_0)
	{
		return BitConverter.ToSingle(YkU4Jkc6jp, int_0);
	}

	internal static double RhSmsy3Yh(int int_0)
	{
		return BitConverter.ToDouble(YkU4Jkc6jp, int_0);
	}

	internal static void TUnuBvTQS(Array array_0, int int_0)
	{
		int num = 6;
		while (true)
		{
			int num2 = 0;
			num = 5;
			while (true)
			{
				IL_010a:
				if ((YkU4Jkc6jp[int_0] & 0x80u) != 0)
				{
					if ((YkU4Jkc6jp[int_0] & 0x40) == 0)
					{
						goto IL_0076;
					}
					num2 = (YkU4Jkc6jp[int_0] & -193) << 24;
					num2 |= YkU4Jkc6jp[int_0 + 1] << 16;
					num2 |= YkU4Jkc6jp[int_0 + 2] << 8;
					num2 |= YkU4Jkc6jp[int_0 + 3];
					int_0 += 4;
					goto IL_00e8;
				}
				num2 = YkU4Jkc6jp[int_0];
				int num3 = 3;
				if (Pfy44nuFvd() != null)
				{
					goto IL_00a2;
				}
				goto IL_00bb;
				IL_00bb:
				while (true)
				{
					switch (num3)
					{
					case 4:
						break;
					case 3:
						int_0++;
						num3 = 2;
						if (!OAZ4YH3PXY())
						{
							continue;
						}
						goto IL_00e8;
					default:
						return;
					case 1:
						int_0 += 2;
						goto IL_00e8;
					case 2:
						goto IL_00e8;
					case 5:
						goto IL_010a;
					case 6:
						goto end_IL_010a;
					case 0:
						return;
					}
					break;
				}
				goto IL_0076;
				IL_00e8:
				if (num2 < 1)
				{
					num3 = 0;
					if (Pfy44nuFvd() != null)
					{
						goto IL_00a2;
					}
					goto IL_00bb;
				}
				Buffer.BlockCopy(YkU4Jkc6jp, int_0, array_0, 0, num2);
				return;
				IL_00a2:
				num3 = num;
				goto IL_00bb;
				IL_0076:
				num2 = (YkU4Jkc6jp[int_0] & -129) << 8;
				num2 |= YkU4Jkc6jp[int_0 + 1];
				num3 = 1;
				if (Pfy44nuFvd() != null)
				{
					goto IL_00a2;
				}
				goto IL_00bb;
				continue;
				end_IL_010a:
				break;
			}
		}
	}

	internal static void dgESvv1N6()
	{
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
	}

	internal static object A9uDJSgnc(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static object Cn4zRy8MH(long long_0, object object_0)
	{
		return CNZkc41wwVeHFDb1SW.NIU4jCRtQE(long_0, (Stream)object_0);
	}

	internal static bool OAZ4YH3PXY()
	{
		return Qgc40lodAY == null;
	}

	internal static f8F0bInV17iDeAuVHn Pfy44nuFvd()
	{
		return Qgc40lodAY;
	}
}
