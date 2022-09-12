using System.Runtime.CompilerServices;

namespace Microsoft.Kofe.Engine;

internal class A9991B2DB : BC94B3E09
{
	[CompilerGenerated]
	private BC94B3E09 F0750E27C;

	[CompilerGenerated]
	private UnaryOperatorEvaluator D84CE00E9;

	public BC94B3E09 B8395680E
	{
		[CompilerGenerated]
		get
		{
			return F0750E27C;
		}
		[CompilerGenerated]
		protected set
		{
			F0750E27C = value;
		}
	}

	public UnaryOperatorEvaluator D46FC475C
	{
		[CompilerGenerated]
		get
		{
			return D84CE00E9;
		}
		[CompilerGenerated]
		protected set
		{
			D84CE00E9 = value;
		}
	}

	public A9991B2DB(BC94B3E09 operand, UnaryOperatorEvaluator o)
	{
		B8395680E = operand;
		D46FC475C = o;
	}

	public override string AE5EB2F45()
	{
		return A28774298.E903ED30B(D46FC475C.Operator) + B8395680E.ToString();
	}

	public override Value BDD620C1A(DD3247535 F48FB2982)
	{
		if (!(B8395680E.A4BA9D8ED(F48FB2982) is BF602D4D0 v))
		{
			throw new EEA8EDD4A(B0E4D9146.BFB0085C0);
		}
		return D46FC475C.Op(v);
	}

	public override FEC112558 F4EABA1F0(DD3247535 C6A22CD8D)
	{
		return new FEC112558(F18024EA9.Simple);
	}
}
