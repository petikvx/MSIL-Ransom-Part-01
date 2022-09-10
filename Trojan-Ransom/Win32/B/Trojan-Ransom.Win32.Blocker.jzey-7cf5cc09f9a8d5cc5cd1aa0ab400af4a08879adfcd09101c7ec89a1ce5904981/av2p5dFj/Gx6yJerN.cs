using System;
using ZqaFD1Ap;
using di1mqJMz;
using geYLBm6w;
using iiraiv39;
using sReLFYF2;

namespace av2p5dFj;

internal class Gx6yJerN : VZxzVnkV
{
	protected int kDVj9YRi;

	protected int tPXs1krX;

	public int nv9d2LsG => kDVj9YRi;

	public override string zLvhmgIq
	{
		get
		{
			string text = FFXb5i9i.smethod_0(kDVj9YRi.ToString(), "s/", OGtSEGQU.rkg3zAUM(), 52605);
			if (tPXs1krX > 0)
			{
				text = FFXb5i9i.MhuSoiDL(text, "/", tPXs1krX.ToString(), "s", 9407);
			}
			return text;
		}
	}

	public int Bjc6RzC9 => tPXs1krX;

	public Gx6yJerN(string patpSVhD, ref GnNqYKdA gnNqYKdA_0)
		: base(ref gnNqYKdA_0)
	{
		string[] array = FFXb5i9i.fLadxka9(patpSVhD, new char[1] { '/' }, 33801);
		checked
		{
			if (array.Length < 2)
			{
				kDVj9YRi = 0;
			}
			else
			{
				string string_ = array[0];
				kDVj9YRi = ivlgLlId.PluO6Q6e(ivlgLlId.zIKBYyAm(string_, 1, ivlgLlId.f5lHgZCI(string_, 64616) - 1, 41221), 37974);
			}
			if (array.Length < 2)
			{
				OGtSEGQU = null;
			}
			else
			{
				string wQtXYJC = array[1];
				try
				{
					sm18FGKs E17tIWai = gnNqYKdA_0.L0TyRGNz();
					OGtSEGQU = new Class8(ref E17tIWai, wQtXYJC);
				}
				catch (Exception exception_)
				{
					m8meAX3U.L6HgMKrR(exception_, 21003);
					throw new ArgumentException("Invalid time dependent condition");
				}
			}
			if (array.Length < 3)
			{
				tPXs1krX = 0;
				return;
			}
			string string_2 = array[2];
			tPXs1krX = ivlgLlId.PluO6Q6e(ivlgLlId.zIKBYyAm(string_2, 1, ivlgLlId.f5lHgZCI(string_2, 64616) - 1, 41221), 37974);
		}
	}

	public override bool hdRfBnfa()
	{
		return true;
	}
}
