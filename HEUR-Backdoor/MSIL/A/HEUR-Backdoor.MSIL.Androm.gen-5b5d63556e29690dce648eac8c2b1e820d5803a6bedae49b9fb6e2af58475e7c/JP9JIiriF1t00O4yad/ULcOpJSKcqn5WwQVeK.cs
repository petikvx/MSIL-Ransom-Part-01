using System;
using System.IO;
using System.Reflection;
using System.Text;
using ACOVXNuRhOUrWxigRt;
using CywHuCRSJ9Nc0dmtm00;
using Hk5mQDzNwF2uhvmw1b;
using SRo1MyRyNCF0HMnMeRy;
using mqTn2KRuHaeVC7qZfAP;

namespace JP9JIiriF1t00O4yad;

internal class ULcOpJSKcqn5WwQVeK
{
	internal static readonly byte[] S6SRFiAE57;

	internal readonly int aafRa6vqGh;

	private static ULcOpJSKcqn5WwQVeK YNyR9fCw7e;

	static ULcOpJSKcqn5WwQVeK()
	{
		uOxwGiRTS5ExO0AcR6j.vIHvRlxcnv();
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		yaflfG2jl();
		if (S6SRFiAE57 == null)
		{
			string s = oxfevuxb8f51pPM8uj.ADIaRIoIY4(0);
			byte[] array = Convert.FromBase64String(s);
			s = (string)JutxD43Jb(Encoding.UTF8, array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			S6SRFiAE57 = (byte[])A9izLvxcQ(97L, manifestResourceStream);
		}
	}

	public ULcOpJSKcqn5WwQVeK()
	{
		h5jVfKRi6h9cyEPcYxd.nviIH7hzRoY0Y();
		NYjo1bRqUlt4IQc9SFk.Vax9ZyXknj();
		base._002Ector();
	}

	internal static int LotJkZ06x(int int_0)
	{
		return BitConverter.ToInt32(S6SRFiAE57, int_0);
	}

	internal static long mnUowbP97(int int_0)
	{
		return BitConverter.ToInt64(S6SRFiAE57, int_0);
	}

	internal static float iURYeNjLb(int int_0)
	{
		return BitConverter.ToSingle(S6SRFiAE57, int_0);
	}

	internal static double nTGQG1doL(int int_0)
	{
		return BitConverter.ToDouble(S6SRFiAE57, int_0);
	}

	internal static void QnnddT6Ck(Array array_0, int int_0)
	{
		int num = 6;
		while (true)
		{
			int num2 = 0;
			num = 5;
			while (true)
			{
				IL_010a:
				if ((S6SRFiAE57[int_0] & 0x80u) != 0)
				{
					if ((S6SRFiAE57[int_0] & 0x40) == 0)
					{
						goto IL_0076;
					}
					num2 = (S6SRFiAE57[int_0] & -193) << 24;
					num2 |= S6SRFiAE57[int_0 + 1] << 16;
					num2 |= S6SRFiAE57[int_0 + 2] << 8;
					num2 |= S6SRFiAE57[int_0 + 3];
					int_0 += 4;
					goto IL_00e8;
				}
				num2 = S6SRFiAE57[int_0];
				int num3 = 3;
				if (ffTRRae1TN() != null)
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
						if (!gRgRUnwIW9())
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
					if (ffTRRae1TN() != null)
					{
						goto IL_00a2;
					}
					goto IL_00bb;
				}
				Buffer.BlockCopy(S6SRFiAE57, int_0, array_0, 0, num2);
				return;
				IL_00a2:
				num3 = num;
				goto IL_00bb;
				IL_0076:
				num2 = (S6SRFiAE57[int_0] & -129) << 8;
				num2 |= S6SRFiAE57[int_0 + 1];
				num3 = 1;
				if (ffTRRae1TN() != null)
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

	internal static void yaflfG2jl()
	{
		NYjo1bRqUlt4IQc9SFk.Vax9ZyXknj();
	}

	internal static object JutxD43Jb(object object_0, object object_1, int int_0, int int_1)
	{
		return ((Encoding)object_0).GetString((byte[])object_1, int_0, int_1);
	}

	internal static object A9izLvxcQ(long long_0, object object_0)
	{
		return ajyaamTDLVqY4QEdvS.ilvRtPhKkE(long_0, (Stream)object_0);
	}

	internal static bool gRgRUnwIW9()
	{
		return YNyR9fCw7e == null;
	}

	internal static ULcOpJSKcqn5WwQVeK ffTRRae1TN()
	{
		return YNyR9fCw7e;
	}
}
