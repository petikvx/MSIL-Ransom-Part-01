using System;
using System.IO;
using System.Reflection;
using System.Text;
using EhdA9I4ntZdCXaNotex;
using HrqeXu48u5BWvM2U05m;
using JAhEyh46uvA1xwWjvIk;
using T7eunHzmke0yeryayX;
using oHDygP8UHs3jGn3SAa;

namespace CJRm7NwEYMZs2pufgG;

internal class yeu6YIjFTsI06GHsRv
{
	internal static readonly byte[] TyL4p2uEwr;

	private static yeu6YIjFTsI06GHsRv Dd14dmAr8W;

	static yeu6YIjFTsI06GHsRv()
	{
		K1GfMT41V9bS6oPmMyh.cKXl4vhcQo();
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
		if (TyL4p2uEwr == null)
		{
			string s = (string)u1C4s2rnvB(28);
			byte[] array = Convert.FromBase64String(s);
			s = ((Encoding)f2e4VdCi3p()).GetString(array, 0, array.Length);
			Stream object_ = (Stream)Hse4yOruub(NBl42tiVo1(), s);
			TyL4p2uEwr = (byte[])pss4vrynGU(97L, object_);
		}
	}

	public yeu6YIjFTsI06GHsRv()
	{
		xvSuwU4RhceXCdhSJgI.d012lyPzTwFQy();
		Jkg4W55sQV();
		base._002Ector();
	}

	internal static string S1r4lW10HJ(int int_0)
	{
		int num = 1;
		string @string = default(string);
		while (true)
		{
			int num2 = 0;
			int num3 = 0;
			if (!JMc4atk5rg())
			{
				goto IL_000b;
			}
			goto IL_002b;
			IL_002b:
			switch (num3)
			{
			case 1:
				continue;
			case 2:
				goto IL_0084;
			case 5:
				goto IL_00ac;
			case 6:
				goto IL_00be;
			case 3:
				goto IL_00cf;
			case 4:
				goto IL_0118;
			case 7:
				goto end_IL_0052;
			}
			goto IL_000b;
			IL_00ac:
			num2 = TyL4p2uEwr[int_0];
			int_0++;
			goto IL_00f4;
			IL_000b:
			if ((TyL4p2uEwr[int_0] & 0x80) == 0)
			{
				num3 = 5;
				if (!JMc4atk5rg())
				{
					num3 = num;
				}
				goto IL_002b;
			}
			if ((TyL4p2uEwr[int_0] & 0x40) == 0)
			{
				goto IL_0084;
			}
			num2 = (TyL4p2uEwr[int_0] & -193) << 24;
			goto IL_00be;
			IL_00cf:
			num2 |= TyL4p2uEwr[int_0 + 2] << 8;
			num2 |= TyL4p2uEwr[int_0 + 3];
			int_0 += 4;
			goto IL_00f4;
			IL_00f4:
			if (num2 < 1)
			{
				num = 7;
				break;
			}
			@string = Encoding.Unicode.GetString(TyL4p2uEwr, int_0, num2);
			goto IL_0118;
			IL_0084:
			num2 = (TyL4p2uEwr[int_0] & -129) << 8;
			num2 |= TyL4p2uEwr[int_0 + 1];
			int_0 += 2;
			goto IL_00f4;
			IL_0118:
			return string.Intern(@string);
			IL_00be:
			num2 |= TyL4p2uEwr[int_0 + 1] << 16;
			goto IL_00cf;
			continue;
			end_IL_0052:
			break;
		}
		return string.Empty;
	}

	internal static object u1C4s2rnvB(int int_0)
	{
		return sD2Wk4DskFhChtylq3.vXpe4HnnoY(int_0);
	}

	internal static object f2e4VdCi3p()
	{
		return Encoding.UTF8;
	}

	internal static object NBl42tiVo1()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object Hse4yOruub(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static object pss4vrynGU(long long_0, object object_0)
	{
		return CNZkc41wwVeHFDb1SW.NIU4jCRtQE(long_0, (Stream)object_0);
	}

	internal static bool JMc4atk5rg()
	{
		return Dd14dmAr8W == null;
	}

	internal static yeu6YIjFTsI06GHsRv ktR47qjEUL()
	{
		return Dd14dmAr8W;
	}

	internal static void Jkg4W55sQV()
	{
		ud9OYc4i7bqX53MRDiY.tvE0cQ1Gob();
	}
}
