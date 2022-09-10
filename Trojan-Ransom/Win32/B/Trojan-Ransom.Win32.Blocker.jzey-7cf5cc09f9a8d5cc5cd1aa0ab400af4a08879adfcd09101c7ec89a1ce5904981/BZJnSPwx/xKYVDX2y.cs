using System.Collections.Generic;
using CCfpfC7h;
using di1mqJMz;
using iiraiv39;
using qGIjTe0w;

namespace BZJnSPwx;

internal class xKYVDX2y : Zgdu3ojh
{
	public xKYVDX2y(ref Class2 Si2ScGEJ)
		: base(ref Si2ScGEJ)
	{
	}

	public string BuoiT0mu()
	{
		string text = ivlgLlId.jnXal2jf(uwtJIsFs(), jPuAefZQ, 28657);
		for (int num = 0; num == 0; num = 1)
		{
			text = FFXb5i9i.Be2UxXd8(new string[6]
			{
				text,
				ggD0kan7(),
				jPuAefZQ,
				vFuKo6Cj(),
				jPuAefZQ,
				M4dGM1uI()
			}, 53581);
		}
		return text;
	}

	private string ggD0kan7()
	{
		return FFXb5i9i.smethod_0(FFXb5i9i.MhuSoiDL(FFXb5i9i.MhuSoiDL(FFXb5i9i.MhuSoiDL(FFXb5i9i.Be2UxXd8(new string[8] { "void LecturaEntrades(void)", jPuAefZQ, "{", jPuAefZQ, hevTs6I2, "LecturaEntradesFisiques();", jPuAefZQ, jPuAefZQ }, 53581), hevTs6I2, "FlancP.all = EntradaDig.all & ~EntradaDigAux.all;", jPuAefZQ, 9407), hevTs6I2, "FlancB.all = ~EntradaDig.all & EntradaDigAux.all;", jPuAefZQ, 9407), hevTs6I2, "EntradaDigAux.all = EntradaDig.all;", jPuAefZQ, 9407), "}", jPuAefZQ, 52605);
	}

	private string vFuKo6Cj()
	{
		string text = FFXb5i9i.MhuSoiDL("void LecturaEntradesFisiques(void)", jPuAefZQ, "{", jPuAefZQ, 9407);
		for (int num = 0; num == 0; num = 1)
		{
			text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "EntradaDig.all = 0x0000;", jPuAefZQ, 9407);
			foreach (KeyValuePair<cXJ3GNUP, int> item in RuM7nYib.icvnXNHx)
			{
				text = FFXb5i9i.Be2UxXd8(new string[6]
				{
					text,
					hevTs6I2,
					"if (",
					FFXb5i9i.UUMks6OM(item.Key.PYBbtbg6, 63152),
					") {",
					jPuAefZQ
				}, 53581);
				text = FFXb5i9i.Be2UxXd8(new string[7]
				{
					text,
					hevTs6I2,
					hevTs6I2,
					"EntradaDig.bits.bit",
					item.Value.ToString(),
					" = 1;",
					jPuAefZQ
				}, 53581);
				text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "}", jPuAefZQ, 9407);
			}
			text = FFXb5i9i.smethod_0(text, "}", jPuAefZQ, 52605);
		}
		return text;
	}

	private string M4dGM1uI()
	{
		string text = FFXb5i9i.MhuSoiDL("void SortidesFisiques(void)", jPuAefZQ, "{", jPuAefZQ, 9407);
		foreach (KeyValuePair<int, cXJ3GNUP> item in RuM7nYib.ej0keUOA_2)
		{
			text = FFXb5i9i.Be2UxXd8(new string[6]
			{
				text,
				hevTs6I2,
				"if (SortidaDig.bits.bit",
				item.Key.ToString(),
				") {",
				jPuAefZQ
			}, 53581);
			text = FFXb5i9i.Be2UxXd8(new string[6]
			{
				text,
				hevTs6I2,
				hevTs6I2,
				item.Value.PYBbtbg6,
				" = 1;",
				jPuAefZQ
			}, 53581);
			text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "} else {", jPuAefZQ, 9407);
			text = FFXb5i9i.Be2UxXd8(new string[6]
			{
				text,
				hevTs6I2,
				hevTs6I2,
				item.Value.PYBbtbg6,
				" = 0;",
				jPuAefZQ
			}, 53581);
			text = FFXb5i9i.MhuSoiDL(text, hevTs6I2, "}", jPuAefZQ, 9407);
		}
		return FFXb5i9i.smethod_0(text, "}", jPuAefZQ, 52605);
	}
}
