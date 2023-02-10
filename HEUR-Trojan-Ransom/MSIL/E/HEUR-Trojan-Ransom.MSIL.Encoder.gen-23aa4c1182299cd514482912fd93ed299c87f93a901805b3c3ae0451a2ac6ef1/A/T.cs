using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal sealed class T
{
	internal static readonly byte[] D;

	internal readonly int D;

	static T()
	{
		if (T.D != null)
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
			string s = "S2FzcGVyc2t5JQ==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			T.D = A.D(97L, manifestResourceStream);
			return;
		}
	}

	internal static int D(int P_0)
	{
		return BitConverter.ToInt32(T.D, P_0);
	}

	internal static long D(int P_0)
	{
		return BitConverter.ToInt64(T.D, P_0);
	}

	internal static float D(int P_0)
	{
		return BitConverter.ToSingle(T.D, P_0);
	}

	internal static double D(int P_0)
	{
		return BitConverter.ToDouble(T.D, P_0);
	}

	internal static void D(Array P_0, int P_1)
	{
		int num = 0;
		if ((T.D[P_1] & 0x80) == 0)
		{
			while (true)
			{
				switch (1)
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
			num = T.D[P_1];
			P_1++;
		}
		else if ((T.D[P_1] & 0x40) == 0)
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
			num = (T.D[P_1] & -129) << 8;
			num |= T.D[P_1 + 1];
			P_1 += 2;
		}
		else
		{
			num = (T.D[P_1] & -193) << 24;
			num |= T.D[P_1 + 1] << 16;
			num |= T.D[P_1 + 2] << 8;
			num |= T.D[P_1 + 3];
			P_1 += 4;
		}
		if (num < 1)
		{
			while (true)
			{
				switch (1)
				{
				case 0:
					break;
				default:
					return;
				}
			}
		}
		Buffer.BlockCopy(T.D, P_1, P_0, 0, num);
	}
}
