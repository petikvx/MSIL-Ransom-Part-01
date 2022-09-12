using System.Globalization;
using System.Runtime.CompilerServices;

namespace Microsoft.Kofe.Engine;

internal class EC93968E2 : BC94B3E09
{
	[CompilerGenerated]
	private readonly BC94B3E09 C5F60B55D;

	[CompilerGenerated]
	private readonly BC94B3E09 E052A87E5;

	public BC94B3E09 D539E9249
	{
		[CompilerGenerated]
		get
		{
			return C5F60B55D;
		}
	}

	public BC94B3E09 D01DC574B
	{
		[CompilerGenerated]
		get
		{
			return E052A87E5;
		}
	}

	public EC93968E2(BC94B3E09 a, BC94B3E09 i)
	{
		C5F60B55D = a;
		E052A87E5 = i;
	}

	public override string B2C387939()
	{
		return D539E9249.ToString() + "[" + D01DC574B.ToString() + "]";
	}

	public override Value CE961ABA9(DD3247535 AE15D96E0)
	{
		Value value = D539E9249.A4BA9D8ED(AE15D96E0);
		if (!(value is C61B1F4EE))
		{
			throw new EEA8EDD4A(string.Format(CultureInfo.CurrentCulture, B0E4D9146.CC5BD5E78, new object[1] { D539E9249.ToString() }));
		}
		C61B1F4EE obj = (C61B1F4EE)value;
		Value value2 = D01DC574B.A4BA9D8ED(AE15D96E0);
		if (!(value2 is BF602D4D0) || !((BF602D4D0)value2).FC5DF890C)
		{
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		BF602D4D0 bF602D4D = (BF602D4D0)value2;
		return obj.CBC57F609(bF602D4D.D6D2BC94B().FF9267D3B());
	}

	public override FEC112558 AE97F5AE0(DD3247535 F33515DF4)
	{
		FEC112558 fEC = D539E9249.A7C3DB421(F33515DF4);
		if (fEC.D60DB5B8A != null)
		{
			return new FEC112558(F18024EA9.Object, fEC.D60DB5B8A);
		}
		return new FEC112558(F18024EA9.Simple);
	}
}
