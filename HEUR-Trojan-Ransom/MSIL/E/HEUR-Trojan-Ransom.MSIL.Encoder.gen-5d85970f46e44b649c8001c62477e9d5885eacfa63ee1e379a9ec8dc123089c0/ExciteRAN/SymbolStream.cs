using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace ExciteRAN;

internal sealed class SymbolStream
{
	internal static readonly byte[] lastHandler;

	static SymbolStream()
	{
		if (lastHandler != null)
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
			string s = "RXhjaXRlUkFOJA==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			lastHandler = PcitureStack.InsertProcess(97L, manifestResourceStream);
			return;
		}
	}

	internal static string SaveNetwork(int P_0)
	{
		int num = 0;
		if ((lastHandler[P_0] & 0x80) == 0)
		{
			while (true)
			{
				switch (2)
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
			num = lastHandler[P_0];
			P_0++;
		}
		else if ((lastHandler[P_0] & 0x40) == 0)
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
			num = (lastHandler[P_0] & -129) << 8;
			num |= lastHandler[P_0 + 1];
			P_0 += 2;
		}
		else
		{
			num = (lastHandler[P_0] & -193) << 24;
			num |= lastHandler[P_0 + 1] << 16;
			num |= lastHandler[P_0 + 2] << 8;
			num |= lastHandler[P_0 + 3];
			P_0 += 4;
		}
		if (num < 1)
		{
			while (true)
			{
				switch (7)
				{
				case 0:
					break;
				default:
					return string.Empty;
				}
			}
		}
		string @string = Encoding.Unicode.GetString(lastHandler, P_0, num);
		return string.Intern(@string);
	}
}
