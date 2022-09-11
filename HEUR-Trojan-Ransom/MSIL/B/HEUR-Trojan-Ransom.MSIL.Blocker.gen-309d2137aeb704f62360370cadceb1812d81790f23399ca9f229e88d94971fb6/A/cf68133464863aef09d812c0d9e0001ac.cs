using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal class cf68133464863aef09d812c0d9e0001ac
{
	internal static readonly byte[] c5699da6cff4aedcc02bab1c4aba70502;

	static cf68133464863aef09d812c0d9e0001ac()
	{
		if (c5699da6cff4aedcc02bab1c4aba70502 != null)
		{
			return;
		}
		while (true)
		{
			switch (2)
			{
			case 0:
				continue;
			}
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			string s = "cHR1bmEk";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			c5699da6cff4aedcc02bab1c4aba70502 = caaa9892e55af57ca7802d20b2cd5be85.c7e8eb5a938e48808a26d839d10c2ffcf(97L, manifestResourceStream);
			return;
		}
	}

	internal static string c69c1ed2a05d04d476de2d4bdc01d89a9(int P_0)
	{
		int num = 0;
		if ((c5699da6cff4aedcc02bab1c4aba70502[P_0] & 0x80) == 0)
		{
			num = c5699da6cff4aedcc02bab1c4aba70502[P_0];
			P_0++;
		}
		else if ((c5699da6cff4aedcc02bab1c4aba70502[P_0] & 0x40) == 0)
		{
			num = (c5699da6cff4aedcc02bab1c4aba70502[P_0] & -129) << 8;
			num |= c5699da6cff4aedcc02bab1c4aba70502[P_0 + 1];
			P_0 += 2;
		}
		else
		{
			num = (c5699da6cff4aedcc02bab1c4aba70502[P_0] & -193) << 24;
			num |= c5699da6cff4aedcc02bab1c4aba70502[P_0 + 1] << 16;
			num |= c5699da6cff4aedcc02bab1c4aba70502[P_0 + 2] << 8;
			num |= c5699da6cff4aedcc02bab1c4aba70502[P_0 + 3];
			P_0 += 4;
		}
		if (num < 1)
		{
			return string.Empty;
		}
		string @string = Encoding.Unicode.GetString(c5699da6cff4aedcc02bab1c4aba70502, P_0, num);
		return string.Intern(@string);
	}
}
