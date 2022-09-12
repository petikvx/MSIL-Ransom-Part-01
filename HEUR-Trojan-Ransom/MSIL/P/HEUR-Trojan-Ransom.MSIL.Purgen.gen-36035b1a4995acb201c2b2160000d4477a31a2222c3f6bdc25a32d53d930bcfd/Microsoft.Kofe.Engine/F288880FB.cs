using System.Runtime.CompilerServices;
using Microsoft.Kofe.IJDWP;

namespace Microsoft.Kofe.Engine;

internal class F288880FB : BC94B3E09
{
	[CompilerGenerated]
	private BC94B3E09 A11CF94FB;

	[CompilerGenerated]
	private BC94B3E09 A9E8CB358;

	[CompilerGenerated]
	private BinaryOperatorEvaluator AE67FDE6F;

	public BC94B3E09 B06E23822
	{
		[CompilerGenerated]
		get
		{
			return A11CF94FB;
		}
		[CompilerGenerated]
		protected set
		{
			A11CF94FB = value;
		}
	}

	public BC94B3E09 B8F6D50C2
	{
		[CompilerGenerated]
		get
		{
			return A9E8CB358;
		}
		[CompilerGenerated]
		protected set
		{
			A9E8CB358 = value;
		}
	}

	public BinaryOperatorEvaluator EED845669
	{
		[CompilerGenerated]
		get
		{
			return AE67FDE6F;
		}
		[CompilerGenerated]
		protected set
		{
			AE67FDE6F = value;
		}
	}

	private static BinaryOperatorEvaluator DD30E515A(DF0AD6554 DE2133F77)
	{
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		return DE2133F77 switch
		{
			DF0AD6554.Times => new D8DD9C1C7(), 
			DF0AD6554.Divide => new B3E9024A1(), 
			DF0AD6554.Modulus => new EBA494567(), 
			DF0AD6554.Plus => new B957B36FC(), 
			DF0AD6554.Minus => new ADF2672A9(), 
			DF0AD6554.LeftShift => new D928DB23E(), 
			DF0AD6554.RightShift => new E92DB67D5(), 
			DF0AD6554.UnsignedRightShift => new D56BA77F4(), 
			DF0AD6554.LessThan => new A7745B38F(), 
			DF0AD6554.GreaterThan => new F37297C0C(), 
			DF0AD6554.LessThanOrEqual => new EFC45D15C(), 
			DF0AD6554.GreaterThanOrEqual => new B5B8A899E(), 
			DF0AD6554.Equals => new A88C352C6(), 
			DF0AD6554.NotEqual => new FF4496471(), 
			DF0AD6554.BitwiseAnd => new FA4D7ABF2(), 
			DF0AD6554.BitwiseExclusiveOr => new B3CA46DA3(), 
			DF0AD6554.BitwiseOr => new CEADB72E4(), 
			DF0AD6554.And => new EEFCB628A(), 
			DF0AD6554.Or => new F5A9A694B(), 
			_ => throw new ComponentException(-2147467259), 
		};
	}

	public F288880FB(BC94B3E09 l, BC94B3E09 r, DF0AD6554 o)
	{
		B06E23822 = l;
		B8F6D50C2 = r;
		EED845669 = DD30E515A(o);
	}

	public override string ACC2A6796()
	{
		return B06E23822.ToString() + " " + A28774298.E903ED30B(EED845669.Operator) + " " + B8F6D50C2.ToString();
	}

	public override Value B5500F83A(DD3247535 B17503610)
	{
		Value l = B06E23822.A4BA9D8ED(B17503610);
		Value r = B8F6D50C2.A4BA9D8ED(B17503610);
		return EED845669.DoOp(l, r);
	}

	public override FEC112558 F26D548AF(DD3247535 CF47E6CAC)
	{
		return new FEC112558(F18024EA9.Simple);
	}
}
