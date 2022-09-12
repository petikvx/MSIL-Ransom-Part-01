using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace A;

internal class cffd0443b4551df482d235e66317d4cd4
{
	internal static readonly byte[] cc11d141d3db70d189e5aa905b7781a7c;

	static cffd0443b4551df482d235e66317d4cd4()
	{
		if (cc11d141d3db70d189e5aa905b7781a7c == null)
		{
			string s = "T255eCQ=";
			byte[] array = Convert.FromBase64String(s);
			s = Encoding.UTF8.GetString(array, 0, array.Length);
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(s);
			cc11d141d3db70d189e5aa905b7781a7c = cc9dfbf4f37872fe06f4c3ae05af251a4.c6bca594a22afe7a66845ccfe2e37d922(97L, manifestResourceStream);
		}
	}

	internal static string ce57b55ca454aabe14bf635b4c85d996c(int ce17ba80a2ea63d6c3575a6c9b5e2ffe3)
	{
		int num = 0;
		if ((cc11d141d3db70d189e5aa905b7781a7c[ce17ba80a2ea63d6c3575a6c9b5e2ffe3] & 0x80) == 0)
		{
			num = cc11d141d3db70d189e5aa905b7781a7c[ce17ba80a2ea63d6c3575a6c9b5e2ffe3];
			ce17ba80a2ea63d6c3575a6c9b5e2ffe3++;
		}
		else if ((cc11d141d3db70d189e5aa905b7781a7c[ce17ba80a2ea63d6c3575a6c9b5e2ffe3] & 0x40) == 0)
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
			num = (cc11d141d3db70d189e5aa905b7781a7c[ce17ba80a2ea63d6c3575a6c9b5e2ffe3] & -129) << 8;
			num |= cc11d141d3db70d189e5aa905b7781a7c[ce17ba80a2ea63d6c3575a6c9b5e2ffe3 + 1];
			ce17ba80a2ea63d6c3575a6c9b5e2ffe3 += 2;
		}
		else
		{
			num = (cc11d141d3db70d189e5aa905b7781a7c[ce17ba80a2ea63d6c3575a6c9b5e2ffe3] & -193) << 24;
			num |= cc11d141d3db70d189e5aa905b7781a7c[ce17ba80a2ea63d6c3575a6c9b5e2ffe3 + 1] << 16;
			num |= cc11d141d3db70d189e5aa905b7781a7c[ce17ba80a2ea63d6c3575a6c9b5e2ffe3 + 2] << 8;
			num |= cc11d141d3db70d189e5aa905b7781a7c[ce17ba80a2ea63d6c3575a6c9b5e2ffe3 + 3];
			ce17ba80a2ea63d6c3575a6c9b5e2ffe3 += 4;
		}
		if (num < 1)
		{
			return string.Empty;
		}
		string @string = Encoding.Unicode.GetString(cc11d141d3db70d189e5aa905b7781a7c, ce17ba80a2ea63d6c3575a6c9b5e2ffe3, num);
		return string.Intern(@string);
	}
}
