using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal class c0704ad04f6e1855f26de9f48d2cf991a
{
	internal static readonly byte[] cdc826402e29d5c48e3b5167fcf8dfcd7;

	static c0704ad04f6e1855f26de9f48d2cf991a()
	{
		if (cdc826402e29d5c48e3b5167fcf8dfcd7 != null)
		{
			return;
		}
		while (true)
		{
			switch (6)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string s = "SmF2YSBVcGRhdGVyJA==";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			cdc826402e29d5c48e3b5167fcf8dfcd7 = cad9a15757977f5874eabf13acd31ea9a.c74478c8008c8c6dbef9395462fb1ed67(97L, manifestResourceStream);
			return;
		}
	}

	internal static string c41754421d9ebe440ac6fb75108888177(int c203d851120dc885701ad7b6c06cb2316)
	{
		int num = 0;
		if ((cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316] & 0x80) == 0)
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
			num = cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316];
			c203d851120dc885701ad7b6c06cb2316++;
		}
		else if ((cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316] & 0x40) == 0)
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
			num = (cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316] & -129) << 8;
			num |= cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316 + 1];
			c203d851120dc885701ad7b6c06cb2316 += 2;
		}
		else
		{
			num = (cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316] & -193) << 24;
			num |= cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316 + 1] << 16;
			num |= cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316 + 2] << 8;
			num |= cdc826402e29d5c48e3b5167fcf8dfcd7[c203d851120dc885701ad7b6c06cb2316 + 3];
			c203d851120dc885701ad7b6c06cb2316 += 4;
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
		string @string = Encoding.Unicode.GetString(cdc826402e29d5c48e3b5167fcf8dfcd7, c203d851120dc885701ad7b6c06cb2316, num);
		return string.Intern(@string);
	}
}
