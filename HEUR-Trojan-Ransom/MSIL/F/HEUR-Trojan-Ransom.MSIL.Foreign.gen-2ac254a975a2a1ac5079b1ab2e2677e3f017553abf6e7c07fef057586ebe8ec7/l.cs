using System;
using System.IO;
using System.Reflection;
using System.Text;

internal class l
{
	internal static readonly byte[] a;

	internal readonly int b;

	unsafe static l()
	{
		if (l.a != null)
		{
			return;
		}
		while (true)
		{
			switch (1)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			int num = _003CModule_003E.n;
			nint intPtr = ((((uint)num >> 25) + 18178048 != (uint)num % 168693468u >> 17) ? ((((307757056 * num) | 0x57F) - 16441344 == -(num & 0x24D0) << 11) ? checked(-1204285898 + -222226629) : (((((uint)(num * 264 + num * 1784) >> 5 >> 6) & 1) == (uint)(1 & -num)) ? (((((uint)(7364 + (num << 29)) >> 29) & 2) != (uint)((~num - 2958) & 2)) ? (-1673074294 ^ 0x23DD4E3) : ((((((uint)(num * -1073741824) >> 10) ^ (uint)(num * 57 + 7 * num)) & 0x39u) != 0) ? ((nint)Type.EmptyTypes.LongLength + 695708289) : ((nint)Type.EmptyTypes.LongLength + 67894))) : (sizeof(Guid) + 829527825))) : (-809697324 ^ 0x16F8A304));
			IntPtr intPtr2;
			if ((uint)num / 16039u != 2449857621u)
			{
				int num2 = _003CModule_003E.o;
				intPtr2 = ((5009 + (num2 << 20) + 483840 != (int)((uint)(~(num2 * 1073741824)) >> 17)) ? ((nint)Type.EmptyTypes.LongLength + 68839) : ((nint)Type.EmptyTypes.LongLength + -1963321438));
			}
			else
			{
				int num3 = h.a;
				intPtr2 = ((num3 * 12966 - -131 == (int)((uint)num3 % 256u / 1972u >> 23)) ? ((nint)Type.EmptyTypes.LongLength + 1457581078) : ((nint)Type.EmptyTypes.LongLength + -884098835));
			}
			string text = _003CModule_003E.c((int)intPtr, (int)(nint)intPtr2, (int)((nint)Type.EmptyTypes.LongLength + 69));
			byte[] array = Convert.FromBase64String(text);
			text = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
			l.a = o.d(97L, manifestResourceStream);
			return;
		}
	}

	internal static int a(int P_0)
	{
		return BitConverter.ToInt32(l.a, P_0);
	}

	internal static long b(int P_0)
	{
		return BitConverter.ToInt64(l.a, P_0);
	}

	internal static float c(int P_0)
	{
		return BitConverter.ToSingle(l.a, P_0);
	}

	internal static double d(int P_0)
	{
		return BitConverter.ToDouble(l.a, P_0);
	}

	internal unsafe static void e(Array P_0, int P_1)
	{
		int num = 0;
		int num2 = l.a[P_1] & 0x80;
		_003CModule_003E.k = -1592258590;
		if (num2 == 0)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					continue;
				}
				break;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num = l.a[P_1];
			P_1++;
		}
		else if ((l.a[P_1] & 0x40) == 0)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					continue;
				}
				break;
			}
			num = (l.a[P_1] & -129) << 8;
			num |= l.a[P_1 + 1];
			P_1 += 2;
		}
		else
		{
			num = (l.a[P_1] & -193) << 24;
			num |= l.a[P_1 + 1] << 16;
			int num3 = num;
			byte[] array = l.a;
			int num4 = P_1 + 2;
			j.g = _003CModule_003E.c(sizeof(short) + 8824, (int)((nint)Type.EmptyTypes.LongLength + 9800), (int)((nint)Type.EmptyTypes.LongLength + 186));
			num = num3 | (array[num4] << 8);
			num |= l.a[P_1 + 3];
			P_1 += 4;
		}
		if (num < 1)
		{
			while (true)
			{
				switch (5)
				{
				case 0:
					break;
				default:
					_003CModule_003E.l = num;
					return;
				}
			}
		}
		Buffer.BlockCopy(l.a, P_1, P_0, 0, num);
		_003CModule_003E.f = num;
	}
}
