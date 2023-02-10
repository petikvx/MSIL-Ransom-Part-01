using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal sealed class R
{
	internal static readonly byte[] D;

	static R()
	{
		if (R.D != null)
		{
			return;
		}
		while (true)
		{
			switch (7)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string s = "S2FzcGVyc2t5JA==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			R.D = A.D(97L, manifestResourceStream);
			return;
		}
	}

	internal static string D(int P_0)
	{
		int num = 0;
		if ((R.D[P_0] & 0x80) == 0)
		{
			while (true)
			{
				switch (3)
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
			num = R.D[P_0];
			P_0++;
		}
		else if ((R.D[P_0] & 0x40) == 0)
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
			num = (R.D[P_0] & -129) << 8;
			num |= R.D[P_0 + 1];
			P_0 += 2;
		}
		else
		{
			num = (R.D[P_0] & -193) << 24;
			num |= R.D[P_0 + 1] << 16;
			num |= R.D[P_0 + 2] << 8;
			num |= R.D[P_0 + 3];
			P_0 += 4;
		}
		if (num < 1)
		{
			while (true)
			{
				switch (3)
				{
				case 0:
					break;
				default:
					return string.Empty;
				}
			}
		}
		string @string = Encoding.Unicode.GetString(R.D, P_0, num);
		return string.Intern(@string);
	}
}
