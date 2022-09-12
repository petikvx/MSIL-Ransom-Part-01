using System.Runtime.CompilerServices;

namespace Microsoft.Kofe.Engine;

internal class A9E43674E : BC94B3E09
{
	[CompilerGenerated]
	private BC94B3E09 FC5ADB4F0;

	[CompilerGenerated]
	private BC94B3E09 C50A6E6CB;

	public BC94B3E09 A720FA9EE
	{
		[CompilerGenerated]
		get
		{
			return FC5ADB4F0;
		}
		[CompilerGenerated]
		protected set
		{
			FC5ADB4F0 = value;
		}
	}

	public BC94B3E09 A5DA73B33
	{
		[CompilerGenerated]
		get
		{
			return C50A6E6CB;
		}
		[CompilerGenerated]
		protected set
		{
			C50A6E6CB = value;
		}
	}

	public A9E43674E(BC94B3E09 operand, BC94B3E09 type)
	{
		A720FA9EE = operand;
		A5DA73B33 = type;
	}

	public override string B62F064EA()
	{
		return "(" + A5DA73B33.ToString() + ")" + A720FA9EE.ToString();
	}

	public override Value CD3741E82(DD3247535 C3466FEBF)
	{
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Invalid comparison between Unknown and I4
		if (!(A5DA73B33 is D63D3432B))
		{
			throw new EEA8EDD4A(B0E4D9146.CC4520D8D);
		}
		if (!(A720FA9EE.A4BA9D8ED(C3466FEBF) is BF602D4D0 bF602D4D))
		{
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		switch (((D63D3432B)A5DA73B33).FEE149994)
		{
		case DF0AD6554.Byte:
			return bF602D4D.BC31F8A4F();
		case DF0AD6554.Char:
			return bF602D4D.DFA073CE9();
		case DF0AD6554.Short:
			return bF602D4D.D05EEA502();
		case DF0AD6554.Int:
			return bF602D4D.D6D2BC94B();
		case DF0AD6554.Long:
			return bF602D4D.DBA29F744();
		case DF0AD6554.Float:
			return bF602D4D.A01087878();
		case DF0AD6554.Double:
			return bF602D4D.BB7441AF1();
		case DF0AD6554.Boolean:
			if ((int)bF602D4D.D305911E9 == 90)
			{
				return bF602D4D;
			}
			break;
		}
		throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
	}

	public override FEC112558 F001253BB(DD3247535 BD5DC94D9)
	{
		if (!(A5DA73B33 is D63D3432B))
		{
			return base.A7C3DB421(BD5DC94D9);
		}
		return new FEC112558(F18024EA9.Simple);
	}
}
