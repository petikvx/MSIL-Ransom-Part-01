using System;
using System.Globalization;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class C61B1F4EE : FD2C728AB, ParentValue
{
	public const string FAEA6949B = "[]";

	public const int F059B65C2 = 1048576;

	private int? E88C61E07;

	private long EA4A11CD0 => base.CF06FB109.AsArray();

	private string EB399B14C()
	{
		uint radix = BF602D4D0.E0EE62C88;
		if (radix == 16)
		{
			return "0x" + B1522128E().ToString("x", CultureInfo.CurrentCulture);
		}
		return B1522128E().ToString(CultureInfo.CurrentCulture);
	}

	public int B1522128E()
	{
		if (!E88C61E07.HasValue)
		{
			E88C61E07 = ((EA4A11CD0 != 0L) ? _jdbg.GetArrayLength(EA4A11CD0) : 0);
		}
		return E88C61E07.Value;
	}

	public static bool BECBAF04D(JdwpValueTag EC75EE6CC)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		return (int)EC75EE6CC == 91;
	}

	public ADB5C0658[] F115D6684(ADB5C0658 F303542F6)
	{
		int num = Math.Min(B1522128E(), 1048576);
		ADB5C0658[] array = new ADB5C0658[num];
		if (num > 0)
		{
			IJdwpValue[] arrayValues = _jdbg.GetArrayValues(EA4A11CD0, 0, num);
			for (int i = 0; i < num; i++)
			{
				array[i] = new E48D53BC7(i, EA4A11CD0, F303542F6);
				array[i].FC3E9C6DA = A002C58D2.A17FDB047(_jdbg, arrayValues[i]);
			}
		}
		return array;
	}

	public Value CBC57F609(int C9E64691F)
	{
		if (C9E64691F < 0 || C9E64691F >= B1522128E())
		{
			return new A8926EF2A(string.Format(CultureInfo.CurrentCulture, B0E4D9146.D2B2CABD6, new object[1] { C9E64691F }));
		}
		IJdwpValue[] arrayValues = _jdbg.GetArrayValues(EA4A11CD0, C9E64691F, 1);
		if (arrayValues == null || arrayValues.Length == 0)
		{
			return new A8926EF2A(B0E4D9146.A1ECE95BF);
		}
		return A002C58D2.A17FDB047(_jdbg, arrayValues[0]);
	}

	public ADB5C0658 A268FBA04(string C7057AB54, ADB5C0658 F58210280)
	{
		return null;
	}

	public C61B1F4EE(IJDbg jdbg, IJdwpValue value)
		: base(jdbg, value)
	{
		if (EA4A11CD0 != 0L)
		{
			string text = F63D7E302().get_DisplaySignature();
			if (text.Length > 2)
			{
				text = text.Substring(0, text.Length - 2);
			}
			base.C78736E72 = string.Format(CultureInfo.CurrentUICulture, "{{{0}[{1}]}}", new object[2]
			{
				text,
				EB399B14C()
			});
		}
		else
		{
			base.C78736E72 = "null";
		}
	}
}
