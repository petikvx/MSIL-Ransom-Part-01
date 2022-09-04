using System;
using System.IO;
using System.Reflection;
using System.Text;

internal class n
{
	internal static readonly byte[] a;

	static n()
	{
		if (n.a != null)
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
			string text = _003CModule_003E.c(checked(1437083121 + -1437065163), (int)((nint)Type.EmptyTypes.LongLength + 18790), (int)((nint)Type.EmptyTypes.LongLength + 131));
			byte[] array = Convert.FromBase64String(text);
			text = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text);
			n.a = o.d(97L, manifestResourceStream);
			return;
		}
	}

	internal static string a(int P_0)
	{
		int num = 0;
		string text = default(string);
		if ((n.a[P_0] & 0x80) == 0)
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
			if (1 == 0)
			{
				/*OpCode not supported: LdMemberToken*/;
			}
			num = n.a[P_0];
			P_0++;
		}
		else if ((n.a[P_0] & 0x40) == 0)
		{
			while (true)
			{
				switch (6)
				{
				case 0:
					continue;
				}
				break;
			}
			num = (n.a[P_0] & -129) << 8;
			num |= n.a[P_0 + 1];
			P_0 += 2;
		}
		else
		{
			int num2 = (n.a[P_0] & -193) << 24;
			_003CModule_003E.a = text;
			num = num2;
			num |= n.a[P_0 + 1] << 16;
			int num3 = num;
			byte[] array = n.a;
			int num4 = P_0;
			_003CModule_003E.e = 1957620381;
			byte num5 = array[num4 + 2];
			_003CModule_003E.a = null;
			num = num3 | (num5 << 8);
			num |= n.a[P_0 + 3];
			int num6 = P_0;
			_003CModule_003E.g = null;
			P_0 = num6 + 4;
		}
		if (num < 1)
		{
			while (true)
			{
				_003CModule_003E.e = 1818084011;
				switch (3)
				{
				case 0:
					break;
				default:
					return string.Empty;
				}
			}
		}
		text = Encoding.Unicode.GetString(n.a, P_0, num);
		return string.Intern(text);
	}
}
